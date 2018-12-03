<?php

function RedirectToURL($url, $waitmsg = 0.4)
{
    header("Refresh:$waitmsg; URL= $url");
    exit;
}
function test_input($data) {
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}
$err= "" ;
if(!isset($_SESSION["email"]) || $_SESSION["email"] !== true){
    if ($_SERVER['REQUEST_METHOD'] == 'POST') {
// The request is using the POST method
        $loginemail = test_input($_POST['login_email']);
        $login_password = $_POST['login_password'];


        try {
            $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
// set the PDO error mode to exception
            $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

            $sql = 'select * from accounts where email = :email ';
            $sth = $myPDO->prepare($sql);
            $sth->execute([':email' => $loginemail]);
            $result = $sth->fetch();

            if(isset($result[0])==false){$GLOBALS['err']="Wrong Email or Email not registered";}

            if (password_verify($GLOBALS['login_password'], $result['password']) && isset($result)) {
                $_SESSION['email'] = $GLOBALS['loginemail'];
                if(isset($_SESSION['email'])){

                    $email = $_SESSION['email'];
                echo "<div class='container'><div class='jumbotron' align='middle'><h1>Hi, $email!</h1><h2>log in succeed</h2><h3>redirecting to Dashboard.....</h3></div></div><script>setTimeout(function(){window.location.replace('?page=dashboard');}, 3400);</script>";
                   }
             } else
               {  $GLOBALS['err'] .= ", Wrong Password";
            }
        } catch (PDOException $e) {
            echo "<div class='container'><div class='jumbotron' align='middle'><h1>ERROR, Could not connect to server</h2></div></div>";
        }
    }
    else{
        if(isset($_SESSION["email"])){
            echo "<div class='container' ><div class='jumbotron' align='middle' ><h1>You are already logged in</h1><p >redirecting to Dashboard.....</p></div></div><script>setTimeout(function() {window.location.replace('?page=dashboard');}, 3400);</script>";
     }
    }
}



?>

<?php if(!isset($_SESSION["email"])){

include './SignUp-SignIn-SignOut/LoginForm.php'; ?>

<?php } ?>
