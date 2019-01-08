<?php


function test_input($data)
{
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}

$err = "";

    // The request is using the POST method
    $name = $_REQUEST['name'];
    $email = test_input($_REQUEST['email']);
    $message = $_REQUEST['message'];

    $err = "";


    function validateform()
    {


        if (empty($GLOBALS['name'])) {
            $GLOBALS['err'] .= "~ name is empty ~";
            echo('<script>alert("Name field is empty");</script>');
        }

        if (empty($GLOBALS['email'])) {
            $GLOBALS['err'] .= "Email is empty";
            echo('<script>alert("Email field is empty");</script>');

        } else
            if (!filter_var($GLOBALS['email'], FILTER_VALIDATE_EMAIL)) {
            $GLOBALS['err'] .= "~ Email is not valid ~";
            echo('<script>alert("Email is not in its correct format!");</script>');
        }
        if (empty($GLOBALS['message'])) {
            $GLOBALS['err'] .= "~ Message is empty ~";
            echo('<script>alert("You did not type any message in the message box");</script>');
        }

        if ($GLOBALS['err'] == "") {
            return "validation check";
        } else {
            return $GLOBALS['err'];
        }

    }

    $temp = validateform();
    if ($temp === "validation check") {
        try {
            $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
            // set the PDO error mode to exception
            $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            $sql = 'insert into contactus values(id,:name,:email,:msj,:datenow,:timenow)';
            $sth = $myPDO->prepare($sql);
            $datenow = date("Y-m-d");
            $timenow = date("h:i:s");
            $sth->execute([':name' => $name, ':email' => $email, ':msj' => $message,':datenow'=>$datenow,':timenow'=>$timenow]);

            echo "<p style='color: green'>Submit Succeeded, Thank you!</p>";

        } catch (PDOException $e) {
            echo "Connection failed: " . $e->getMessage();
        }


    }


    if ($temp !== "validation check") {
        echo $temp;
    }

?>
