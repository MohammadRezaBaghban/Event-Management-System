<?php
session_start();
echo '<html>';

if( isset($_GET['page']) )
    {
    $page = $_GET['page'];
    }else 
    {
        $page = "Home";
    }
    

include './Others/Head.php';    
include './Others/Navigationbar.php';
include './Others/modelform.php';

switch($page) {
    case "Home":
        include "home.php";
        break;

    case "schedule":
        echo '<body>';
        include './Others/schedule.php';
        break;

    case "login":
        echo '<body>';
        include "./FormHandlers/Login.php";
        break;
    case "privacy":
        echo '<body>';
        include "./Footer/Privacy.php";
        break;

    case "contact":
        echo '<body>';
        include "./FormHandlers/Contact.php";
        break;

    case "terms":
        echo '<body>';
        include "./Footer/Terms.php";
        break;
    case  "logout":
        echo '<body>';
        include "./SignUp-SignIn-SignOut/SignOut.php";
        break;
    case "forgot":
        echo '<body>';
        include "psw_reset/forgot_password.php";
        break;
    case "change":
        echo '<body>';
        include "psw_reset/change.php";
        break;
    case "resetpass" :
        echo '<body>';
        include "psw_reset/reset_password.php";
        break;
    case "reset":
        echo '<body>';
        include "psw_reset/reset.php";
        break;
    case "booking":
        echo '<body>';
        include "./SignUp-SignIn-SignOut/SignupForm.php";
        break;
        case "signup":
        echo '<body>';
        include "./FormHandlers/Sign-up.php";
        break;
    default:
        include "home.php";
}


require './Footer/Footer.php';
echo '</body>';
echo'</html>';
?>