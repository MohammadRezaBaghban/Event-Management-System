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
    $fnames[] = null;
    $lnames[] = null;
    $phones[] = null;

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


    if ($_GET['type'] === "group") {
        $i = 1;
        if (empty($_POST['camppay'])) {
            $err .= " The pay button is not selected empty |";
        } else {
            $camppay = test_input($_POST['camppay']);
        }

        if (isset($_POST['fnames']) && isset($_POST['lnames']) && isset($_POST['phones'])) {
            $nvals = count($_REQUEST['fnames']);
            $fnames=$_POST['fnames'];
            $lnames=$_POST['lnames'];
            $phones=$_POST['phones'];
//                $fnames[$i] = test_input($_POST['fname' . $i]);
//                $lnames[$i] = test_input($_POST['lname' . $i]);
//                $phones[$i] = test_input($_POST['phone' . $i]);
        }
    }

    if ($_GET['type'] === "group" || $_GET['type'] === "vip") {

        if (empty($_POST['campspotnr'])) {
            $err .= " The Camp number field is empty |";

        } else {
            $campSpotNr = test_input($_POST['campspotnr']);
        }
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
    if ($err2 === "") {
        return 1;
    } else {
        return 0;
    }
}

if ($_GET['type'] === "group" || $_GET['type'] === "individual" || $_GET['type'] === "vip") {
    if (validateform() == 1) {



        try {
            $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
            $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

            $myPDO->beginTransaction();
            if ($_GET['type'] === "group") {
                $initialbal += 500;
            } else if ($_GET['type'] === "individual") {
                $initialbal += 65;
            } else if ($_GET['type'] === "vip") {
                $initialbal += 250;
            }

            //create account for person 1
            $sql = 'insert into accounts values(account_id,:email,:psw,:iban,:initbal,:valid)';
            $sth = $myPDO->prepare($sql);
            $signup_psw = PASSWORD_HASH($signup_psw, PASSWORD_DEFAULT);
            $valid = "yes";
            $sth->execute([':email' => $signup_email, ':psw' => $signup_psw, ':iban' => $iban, ':initbal' => $initialbal, ':valid' => $valid]);

            //get account id for usage in creating users
            $query = $myPDO->prepare('SELECT account_id FROM accounts WHERE email=:email');
            $query->execute([':email' => $signup_email]);
            $result = $query->fetch(PDO::FETCH_ASSOC);
            $act_id = $result['account_id'];

            //if type of ticket is group do the following
            if ($_GET['type'] === "group") {

                //get the highest group id and add 1 to it to be assigned to the new group
                $query = $myPDO->prepare('SELECT max(group_id) FROM users');
                $query->execute();
                $result = $query->fetch(PDO::FETCH_ASSOC);
                if (!isset($result['group_id'])) {
                    $group_id = 1;
                } else {
                    $group_id = $result['group_id'] + 1;
                }

                // store the users information in the users table
                $sql = 'insert into users values(user_id,:fname,:lname,:actID,:phone,:grID,:admin,:status,:vip)';
                $sth = $myPDO->prepare($sql);

                //create the first user and assign him him as a master of his group
                $sth->execute([':fname' => $GLOBALS['fname'], ':lname' =>$GLOBALS['lname'], ':actID' => $act_id, ':phone' => $GLOBALS['phone'],
                    ':grID' => $group_id
                    , ':admin' => "yes", ':status' => null, ':vip' => "no"]);

                //see the last assigned user id in order to create the ticket of users
                $query = $myPDO->prepare('SELECT max(user_id) FROM users');
                $query->execute();
                $result = $query->fetch(PDO::FETCH_ASSOC);

                if (!isset($result['user_id'])) {
                    $user_id = 1;
                } else {
                    $user_id = $result['user_id'];
                }


                //create a ticket for the user
                $sql = 'insert into tickets values(ticket_id,:userid,:dt)';
                $sth = $myPDO->prepare($sql);
                $timestamp = date("Y-m-d h:i:s");
                $sth->execute([':userid' => $user_id,':dt'=>$timestamp]);
                // , ':timetamp' => $_SERVER['REQUEST_TIME']

                $user_id++;
                $i=0;
                //do the same steps as above to the rest members of the group
                while ($i < 5 && isset($fnames[$i])) {

                    $sql = 'insert into users values(user_id,:fname,:lname,:actID,:phone,:grID,:admin,:status,:vip)';
                    $sth = $myPDO->prepare($sql);
                    $sth->execute([':fname' => $fnames[$i], ':lname' => $lnames[$i], ':actID' => $act_id, ':phone' => $phones[$i],
                        ':grID' => $group_id
                        , ':admin' => "no", ':status' => null, ':vip' => "no"]);

                    $sql = 'insert into tickets values(ticket_id,:userid,:dt)';
                    $sth = $myPDO->prepare($sql);
                    $timestamp = date("Y-m-d h:i:s");
                    $sth->execute([':userid' => $user_id,':dt'=>$timestamp]);
                    $i++;
                    $user_id++;
                }

                //create a camp reservation for the group
                $sql = 'insert into camp_reservation values(:spot,:actid,:pay)';
                $sth = $myPDO->prepare($sql);
                $sth->execute([':spot' => $campSpotNr, ':actid' => $act_id, ':pay' => $camppay]);

                //add a new transaction of fees and if camp pay is selected then add addional camping fees
                $sql = 'insert into transactions values(transaction_id,:datetra,:timetra,:actID,:amount,:current_balance,:typetra)';
                $sth = $myPDO->prepare($sql);
                $datenow = date("Y-m-d");
                $timenow = date("h:i:s");
                $amount = 55 * count($fnames) + 10;

                if ($camppay == "yes") {
                    $amount += 20 * count($fnames);
                }

                $currentbal = $initialbal - $amount;
                $sth->execute([':datetra' => $datenow, ':timetra' => $timenow, ':actID' => $act_id, ':amount' => $amount,
                    ':current_balance' => $currentbal
                    , ':typetra' => "registration"]);


                //update the status of the camp spot to make it reserved
                $query = $myPDO->prepare('UPDATE camp_spots SET is_reserved = :reserv WHERE spot_nr = :nr');
                $query->execute([':nr' => $campSpotNr, ':reserv' => "yes"]);

            }

            //if no error then apply statements otherwise catch exception
            $myPDO->commit();
            $temp = $signup_email;
            echo "<div class='container'><div class='jumbotron' align='middle'><h1>Sign up succeeded</h1><h2>Your username is the same as your email: $temp</h2><h3>Redirecting to log in Page</h3></div></div>";
            RedirectToURL("?page=login", 4);
        } catch
        (PDOException $e) {
            //an exception was thrown and this is the error
            $myPDO->rollBack();
            echo $e;
            $temp = $_POST['email1'];
            echo "<div class='container'><div class='jumbotron' align='middle'><h1>Error!!!<h1><h2>An account with an email address of $temp has already been registered</h2><h3>Redirecting to log in Page</h3></div></div>";
            RedirectToURL("?page=login", 4);
        }
    }
}

?>
