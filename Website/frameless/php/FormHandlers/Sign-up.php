<?php

function RedirectToURL($url, $waitmsg = 0.4)
{
    header("Refresh:$waitmsg; URL= $url");
    exit;
}

function test_input($data)
{

    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;

}

$err = "|";
$err2 = "";
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
// The request is using the POST method

    if (empty($_POST['fname1'])) {
        $err .= " The first name field is empty |";
    } else {
        $fname = test_input($_POST['fname1']);
    }

    if (empty($_POST['lname1'])) {
        $err .= " The last name field is empty |";
    } else {
        $lname = test_input($_POST['lname1']);
    }


    if (empty($_POST['email1'])) {
        $err .= " The email field is empty |";
    } else {
        $signup_email = test_input($_POST['email1']);
    }

    if (empty($_POST['email2'])) {
        $err .= " The email confirm field is empty |";
    } else {
        $signup_email_rep = test_input($_POST['email2']);
    }

    if (empty($_POST['passwd1'])) {
        $err .= "The password field is empty |";
    } else {
        $signup_psw = $_POST['passwd1'];

    }
    if (empty($_POST['passwd2'])) {
        $err .= "The password confirm field is empty |";
    } else {
        $signup_pswrep = $_POST['passwd2'];

    }
    if (empty($_POST['phonenr'])) {
        $err .= "The phone field is empty |";
    } else {
        $phone = test_input($_POST['phonenr']);
    }

    if (empty($_POST['iban'])) {
        $err .= "The IBAN field is empty |";
    } else {
        $iban = test_input($_POST['iban']);
    }

    if (empty($_POST['initialbal'])) {
        $err .= "The Top-Up field is empty |";
    } else {
        $initialbal = test_input($_POST['initialbal']);
    }
    if ($err !== "|") {
        echo "$err";
    }
}

function validateform()
{
    $err2 = "";
    //Here when the email does not in correct format it change the the value of $err
    if (!filter_var($GLOBALS['signup_email'], FILTER_VALIDATE_EMAIL)) {

        $err2 .= "| Invalid email |";
    }
    //Here when the password does not 6 characters or more, it change the the value of $err
    if (strlen($_POST['passwd1']) < 6) {
        $err2 .= "| Short password |";
    }

    if ($_POST['passwd2'] !== $_POST['passwd1']) {
        $err2 .= "| Passwords Dont Match |";
    }
    if ($_POST['email1'] !== $_POST['email2']) {
        $err2 .= "| emails Don't Match |";
    }

    //Then in the last block it check if the error didn't be set, it does not allow the input to be registered on server.
    if (isset($err2) != true) {
        return 1;
    } else {
        return 1;
    }
}



if (validateform()== 1) {
    echo validateform();
    echo "Connection ok!";
    $sqlerr = "";
    try {
        $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
        $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        $myPDO->beginTransaction();

        $sql = 'insert into accounts values(account_id,:email,:psw,:iban,:initbal,:valid)';
        $sth = $myPDO->prepare($sql);
        $signup_psw = PASSWORD_HASH($signup_psw, PASSWORD_DEFAULT);
        $valid = "yes";
        $sth->execute([':email' => $signup_email, ':psw' => $signup_psw, ':iban' => $iban, ':initbal' => $initialbal, ':valid' => $valid]);


        $query = $myPDO->prepare('SELECT account_id FROM accounts WHERE email=:email');
        $query->execute([':email' => $signup_email]);
        $result = $query->fetch(PDO::FETCH_ASSOC);
        $act_id=$result['account_id'];


        $admin = "yes";
        $vip = "no";
        $sql = 'insert into users values(user_id,:fname,:lname,:actID,:phone,:grID,:admin,:status,:vip)';
        $sth = $myPDO->prepare($sql);
        $signup_psw = PASSWORD_HASH($signup_psw, PASSWORD_DEFAULT);
        $valid = "yes";
        $sth->execute([':fname' => $fname, ':lname' => $lname, ':actID' => $act_id, ':phone' => $phone,
            ':grID'=>null
            ,':admin' => $valid,':status'=> null,':vip'=> $vip]);


        $myPDO->commit();
        $temp= $fname;
        echo "<div class='container'><div class='jumbotron' align='middle'><h1>Sign up succeeded</h1><h2>Your username is the same as your email: $temp</h2><h3>Redirecting to log in Page</h3></div></div>";
        RedirectToURL("?page=login", 4);
    } catch (PDOException $e) {
        $myPDO->rollBack();
        echo $e;
        $temp = $_POST['email1'];
        echo "<div class='container'><div class='jumbotron' align='middle'><h1>Error!!!<h1><h2>An account with an email address of $temp has already been registered</h2><h3>Redirecting to log in Page</h3></div></div>";
        RedirectToURL("?page=login", 4);
    }
}



?>
