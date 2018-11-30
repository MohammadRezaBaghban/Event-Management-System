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
} $err= "" ;
if(!isset($_SESSION["email"]) || $_SESSION["email"] !== true){
    if ($_SERVER['REQUEST_METHOD'] == 'POST') {
// The request is using the POST method
        $loginemail = test_input($_POST['login_email']);
        $login_password = $_POST['login_password'];


        try {
            $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi378474', 'dbi378474', '123456789');
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
                echo "<div class='container'  style='background-image: url(../Images/Background/7.jpg);background-size: 100%;'><div class='jumbotron' align='middle'  style='background-image: url(../Images/Background/7.jpg);background-size: 100%;'><h1>Hi, $email!</h1><h2>log in succeed</h2>
        <h3>redirecting to basket.....</h3></div></div>";
                    RedirectToURL("?page=basket",3);
                   }
             } else
               {  $GLOBALS['err'] .= ", Wrong Password";
            }
        } catch (PDOException $e) {
            echo "<div class='container'><div class='jumbotron' align='middle'><h1>ERROR, Could not connect to server</h2></div></div>";
        }
    }
    else{if(isset($_SESSION["email"]) && $_SESSION['email']===true){

        echo "<div class='container' ><div class='jumbotron' align='middle'><h1>You are already logged in</h1>
        <p >redirecting to basket.....</p></div></div>";
         RedirectToURL("?page=basket",3);

     }
    }
}



?>

<?php if(!isset($_SESSION["email"])){

include './SignUp-SignIn-SignOut/LoginForm.php'; ?>

<?php } ?>
