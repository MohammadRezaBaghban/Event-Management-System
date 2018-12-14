<?php
require "../vendor/autoload.php";
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

        if (isset($_POST['fnames']) && isset($_POST['lnames']) && isset($_POST['emails'])) {
            $nvals = count($_REQUEST['fnames']);
            $fnames = $_POST['fnames'];
            $lnames = $_POST['lnames'];
            $emails = $_POST['emails'];

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

//for mailing the user his id
function SendMail($username, $userid, $mail)
{

    $generator = new \Picqer\Barcode\BarcodeGeneratorPNG();
    $barcode = $generator->getBarcode($userid, $generator::TYPE_CODABAR);

    $message = '<html><body>';
    $message .= 'Dear <strong>';
    $message .= $username . '!</strong>,<br> you have booked your place successfully in our <strong>HHF</strong> event.<strong><br>';
    $message .= $userid . '</strong> is your user id and below you code find your BarCode, in case of any accident you can always use them 
    for the entrance of the event.';
    $message .= '<br><br>';
    $message .= '<img src="data:image/png;base64,' . base64_encode($barcode) . '">';
    $message .= '<br> You will have a printed version of the barcode upon checking in!';
    $message .= '<br> Incase you need to contact us,<br> Feel free to send us an email at:<br><br>';
    $message .= 'Hamidisubhi@gmail.com <br> <strong>HHF Admins</strong>';
    $message .= '</body></html>';
    $headers = "MIME-Version: 1.0\r\n";
    $headers .= "Content-Type: text/html; charset=ISO-8859-1\r\n";

    mail($mail, " HHF || Booking confirmation", $message, $headers);

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
    try {
        $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
        $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        $query = $myPDO->prepare('SELECT is_reserved FROM camp_spots where spot_nr=:nr');
        $query->execute([':nr' => $_POST['campspotnr']]);
        $result = $query->fetch(PDO::FETCH_ASSOC);
    } catch (PDOException $e) {
        $err2 .= '| Could not validate spot |';
    }

    if (isset($result)) {
        if ($result['is_reserved'] == "yes") {
            $err2 .= "| Camp Spot is already reserved |";
        }
    }

    //Then in the last block it check if the error didn't be set, it does not allow the input to be registered on server.
    if ($err2 === "") {
        return 1;
    } else {
        return $err2;
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
            $sql = 'insert into accounts values(account_id,:email,:phone,:psw,:iban,:initbal,:bal,:valid)';
            $sth = $myPDO->prepare($sql);
            $signup_psw = PASSWORD_HASH($signup_psw, PASSWORD_DEFAULT);
            $valid = "yes";
            $sth->execute([':email' => $signup_email, ':phone' => $phone, ':psw' => $signup_psw, ':iban' => $iban,
                ':initbal' => $initialbal, ':bal' => $initialbal, ':valid' => $valid]);

            //get account id for usage in creating users
            $query = $myPDO->prepare('SELECT account_id FROM accounts WHERE email=:email');
            $query->execute([':email' => $signup_email]);
            $result = $query->fetch(PDO::FETCH_ASSOC);
            $act_id = $result['account_id'];

            //if type of ticket is group do the following
            if ($_GET['type'] === "group") {

                //get the highest group id and add 1 to it to be assigned to the new group
                $query = $myPDO->prepare('SELECT max(group_id) as group_id FROM users');
                $query->execute();
                $result = $query->fetch(PDO::FETCH_ASSOC);
                if (isset($result)) {
                    $group_id = (int)$result['group_id'];

                }
                $group_id++;
                // store the users information in the users table
                $sql = 'insert into users values(user_id,:fname,:lname,:actID,:mail,:grID,:admin,:status,:vip)';
                $sth = $myPDO->prepare($sql);

                //create the first user and assign him him as a master of his group
                $sth->execute([':fname' => $GLOBALS['fname'], ':lname' => $GLOBALS['lname'], ':actID' => $act_id, ':mail' => $GLOBALS['signup_email'],
                    ':grID' => $group_id
                    , ':admin' => "yes", ':status' => null, ':vip' => "no"]);


                //see the last assigned user id in order to create the ticket of users
                $query = $myPDO->prepare('SELECT max(user_id) as user_id FROM users');
                $query->execute();
                $result = $query->fetch(PDO::FETCH_ASSOC);

                $user_id = 0;
                if (isset($result['user_id'])) {
                    $user_id = (int)$result['user_id'];
                }
                SendMail($fname, $user_id, $signup_email);
                //create a ticket for the user
                $sql = 'insert into tickets values(ticket_id,:userid,:dt)';
                $sth = $myPDO->prepare($sql);
                $timestamp = date("Y-m-d h:i:s");
                $sth->execute([':userid' => $user_id, ':dt' => $timestamp]);


                $user_id++;
                $i = 0;
                //do the same steps as above to the rest members of the group
                while ($i < 5 && isset($fnames[$i])) {

                    $sql = 'insert into users values(user_id,:fname,:lname,:actID,:mail,:grID,:admin,:status,:vip)';
                    $sth = $myPDO->prepare($sql);
                    $sth->execute([':fname' => $fnames[$i], ':lname' => $lnames[$i], ':actID' => $act_id, ':mail' => $emails[$i],
                        ':grID' => $group_id
                        , ':admin' => "no", ':status' => null, ':vip' => "no"]);

                    $sql = 'insert into tickets values(ticket_id,:userid,:dt)';
                    $sth = $myPDO->prepare($sql);
                    $timestamp = date("Y-m-d h:i:s");
                    $sth->execute([':userid' => $user_id, ':dt' => $timestamp]);
                    SendMail($fnames[$i], $user_id, $emails[$i]);
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
                $amount = 55 * (count($fnames)+1);

                if ($camppay == "yes") {
                    $amount += 20 * (count($fnames) + 1);
                }

                $currentbal = $initialbal - $amount;
                $sth->execute([':datetra' => $datenow, ':timetra' => $timenow, ':actID' => $act_id, ':amount' => $amount,
                    ':current_balance' => $currentbal
                    , ':typetra' => "registration"]);


                //update the status of the camp spot to make it reserved
                $query = $myPDO->prepare('UPDATE camp_spots SET is_reserved = :reserv WHERE spot_nr = :nr');
                $query->execute([':nr' => $campSpotNr, ':reserv' => "yes"]);

            }

            if ($_GET['type'] === "vip" || $_GET['type'] === "individual") {


                $sql = 'insert into users values(user_id,:fname,:lname,:actID,:mail,:grID,:admin,:status,:vip)';
                $sth = $myPDO->prepare($sql);
                $vip = "no";
                if ($_GET['type'] === "vip") {
                    $vip = "yes";
                }


                //create the first user and assign him him as a master of his group
                $sth->execute([':fname' => $GLOBALS['fname'], ':lname' => $GLOBALS['lname'], ':actID' => $act_id, ':mail' => $GLOBALS['signup_email'],
                    ':grID' => null
                    , ':admin' => "yes", ':status' => null, ':vip' => $vip]);

                $query = $myPDO->prepare('SELECT max(user_id) as user_id FROM users');
                $query->execute();
                $result = $query->fetch(PDO::FETCH_ASSOC);

                if (isset($result['user_id'])) {
                    $user_id = (int)$result['user_id'];

                }
                SendMail($fname, $user_id, $signup_email);


                $sql = 'insert into tickets values(ticket_id,:userid,:dt)';
                $sth = $myPDO->prepare($sql);
                $timestamp = date("Y-m-d h:i:s");
                $sth->execute([':userid' => $user_id, ':dt' => $timestamp]);


                //add a new transaction of fees and if camp pay is selected then add addional camping fees
                $sql = 'insert into transactions values(transaction_id,:datetra,:timetra,:actID,:amount,:current_balance,:typetra)';
                $sth = $myPDO->prepare($sql);
                $datenow = date("Y-m-d");
                $timenow = date("h:i:s");
                if($_GET['type'] === "vip"){$amount=230;}
                else {$amount = 55;}
                $currentbal = $initialbal - $amount;
                $sth->execute([':datetra' => $datenow, ':timetra' => $timenow, ':actID' => $act_id, ':amount' => $amount,
                    ':current_balance' => $currentbal
                    , ':typetra' => "registration"]);
                //update current bal in act table
                $query = $myPDO->prepare('UPDATE accounts SET currentbal = :bal WHERE account_id = :nr');
                $query->execute([':nr' => $act_id, ':bal' => $currentbal]);
                if ($_GET['type'] === "vip") {
                    //create a camp reservation for the vip
                    $sql = 'insert into camp_reservation values(:spot,:actid,:pay)';
                    $sth = $myPDO->prepare($sql);
                    $sth->execute([':spot' => $campSpotNr, ':actid' => $act_id, ':pay' => "yes"]);


                    //update the status of the camp spot to make it reserved
                    $query = $myPDO->prepare('UPDATE camp_spots SET is_reserved = :reserv WHERE spot_nr = :nr');
                    $query->execute([':nr' => $campSpotNr, ':reserv' => "yes"]);
                }
            }

            //if no error then apply statements otherwise catch exception
            $myPDO->commit();


            $temp = $signup_email;
            echo "<div class='container'><div class='jumbotron' align='middle'><h1>Sign up succeeded</h1><h2>Your username is the same as your email: $temp</h2><h3> Redirecting to log in</h3></div></div><script>setTimeout(function(){window.location.replace('?page=login');}, 3500);</script>";

        } catch
        (PDOException $e) {
            //an exception was thrown and this is the error
            $myPDO->rollBack();
            echo $e;
            $temp = $_POST['email1'];
            echo "<div class='container'><div class='jumbotron' align='middle'>An account with an email address of $temp has already been registered<h3>redirection to login</h3></div></div><script>setTimeout(function(){window.location.replace('?page=login');}, 5000);</script>";
        }
    }
    else
        {
            echo "<script>setTimeout(function(){window.location.replace('?page=booking');}, 5000);</script>";
    }
}

?>
