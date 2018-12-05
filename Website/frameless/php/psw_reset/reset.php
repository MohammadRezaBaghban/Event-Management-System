<?php
/**
 * Created by PhpStorm.
 * User: Subhi hamidi
 * Date: 07/10/2018
 * Time: 03:43 PM
 */


function RedirectToURL($url, $waitmsg = 0.4)
{
    header("Refresh:$waitmsg; URL= $url");
    exit;
}

try {
    $conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
// set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);


} catch (PDexception $e) {

}
if (isset($_POST["ResetPasswordForm"])) {
    $selector = $_POST["selector"];
    $validator = $_POST["validator"];
    // Gather the post data

    $password = $_POST["password"];

    $confirmpassword = $_POST["confirmpassword"];


//diff methode
    $query = $conn->prepare('SELECT * FROM password_reset WHERE selector = :selector AND  expires > :timex');
//store the time to check whether the time has passed one hour
    $time = time();

    $query->execute([':timex' => $time, ':selector' => $selector]);

    $result = $query->fetch(PDO::FETCH_ASSOC);
    $user = $result['email'];
    $auth_token = $result['token'];
    $calc = hash('sha256', hex2bin($validator));
//check whether the there is a result fetched
    if (empty($result)) {
        echo "empty";
        return array('status' => 0, 'message' => 'There was an error processing your request. Error Code: 002');
    }


//validate whether the tokens match
    if (hash_equals($calc, $auth_token)) {
        if ($password == $confirmpassword) {

            //has and secure the password

            $password = password_hash($password, PASSWORD_DEFAULT);


            // Update the user's password

            $query = $conn->prepare('UPDATE accounts SET password = :password WHERE email = :email');

            $query->bindParam(':password', $password);

            $query->bindParam(':email', $user);

            $query->execute();
            //delete the tokens to prevent reusing the link again
            $query = $conn->prepare('delete from password_reset where email = :email');

            $query->bindParam(':email', $user);

            $query->execute();
            $conn = null;
            echo "Your password has been successfully reset.";

        } else

            echo "Your password's do not match.";

    } else

        echo "Your password reset key is invalid.";

}

?>