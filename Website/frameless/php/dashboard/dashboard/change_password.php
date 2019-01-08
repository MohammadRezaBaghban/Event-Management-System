<?php
if(!isset($_REQUEST['$mailchange'])){
    echo "please set username";
    exit;
}
$mailchange = $_REQUEST['$mailchange'];

$mailchange = trim($mailchange);


if($mailchange=="")
{
    echo "error recieving mail";
}
else
{  $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
// set the PDO error mode to exception
    $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    function check($email)
    {
        $query = $GLOBALS['$myPDO']->prepare('SELECT * FROM accounts WHERE email > :email');
        $query->execute([':email' => $email]);
        $result = $query->fetch(PDO::FETCH_ASSOC);
        $user = $result['email'];
        return $user;
    }   
    if (!empty(check($mailchange)))
    {
        if ($password == $confirmpassword) {

            //has and secure the password

            $password = password_hash($password, PASSWORD_DEFAULT);


            // Update the user's password

            $query = $myPDO->prepare('UPDATE accounts SET password = :password WHERE email = :email');

            $query->bindParam(':password', $password);

            $query->bindParam(':email', $user);

            $query->execute();
            //delete the tokens to prevent reusing the link again

            $myPDO = null;
            echo "Your password has been successfully reset.";

        } else

            echo "Your password's do not match.";

    }
}
?>