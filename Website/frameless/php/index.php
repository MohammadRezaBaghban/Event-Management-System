<?php


session_start();
if (isset($_GET['page'])) {
    $page = $_GET['page'];
} else {
    $page = "Home";
}
if(isset($_SESSION['email'])){
    $login=1;
}
else $login=0;
echo '<html>';
include './Others/Head.php';

echo '<body>';
if($page != "login" && $page !="loginhandler" && $page !="forgot" && $page!="resetpass"){
    include './Others/Navigationbar.php';
}

if($page !="login" ){
include './Others/modelform.php';
}


switch ($page) {
    case "Home":
        include "home.php";
        break;
    case "schedule":
        include './Others/schedule.php';
        break;
    case "login":
        if(!isset($_SESSION["email"]) && $_SESSION["email"] !== true) {
            include "./SignUp-SignIn-SignOut/LoginForm.php";
        }
        else{echo "<script>setTimeout(function(){window.location.replace('/php/dashboard/dashboard.php');}, 0);</script>";}

        break;
    case "loginhandler":
        include "./FormHandlers/Login.php";
        break;
    case "privacy":
        include "./Footer/Privacy.php";
        break;
    case "dashboard":
        if(!isset($_SESSION["email"]) && $_SESSION["email"] !== true) {
            include "./SignUp-SignIn-SignOut/LoginForm.php";
        }
        else{echo "<script>setTimeout(function(){window.location.replace('/php/dashboard/dashboard.php');}, 0);</script>";}
        break;
    case "terms":
        include "./Footer/Terms.php";
        break;
    case  "logout":
        include "./SignUp-SignIn-SignOut/SignOut.php";
        break;
    case "forgot":
        include "psw_reset/forgot_password.php";
        break;
    case "change":
        include "psw_reset/change.php";
        break;
    case "resetpass" :
        include "psw_reset/reset_password.php";
        break;
    case "reset":
        include "psw_reset/reset.php";
        break;
    case "booking":
        include "./SignUp-SignIn-SignOut/SignupForm.php";
        break;
    case "signup":
        $date = new DateTime("2018-01-21 11:00:00");
        $datenow = new DateTime();
        if ($date > $datenow) {
            # current time is greater than 2018-01-23 12:00:00
            # in other words, 2018-01-23 12:00:00 has passed
            echo "Ops, It's too late.";
            exit();
        }
        else{
                include "./FormHandlers/Sign-up.php";
            }
        break;
    default:
        include "home.php";
}
if($page != "login" && $page !="loginhandler" && $page !="forgot" && $page!="resetpass"){
require './Footer/Footer.php';
}
echo '</body>';
echo '</html>';
?>