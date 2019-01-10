<?php
$date = new DateTime("2018-01-21 11:00:00");
$datenow = new DateTime();
if ($date > $datenow) {
    # current time is greater than 2018-01-23 12:00:00
    # in other words, 2018-01-23 12:00:00 has passed
    echo "Ops, It's too late.";
exit();
}
else {
    if (!isset($_REQUEST['email'])) {
        echo "EMAIL NOT RECEIVED";
        exit;
    }
    $email = $_REQUEST['email'];

    $email = trim($email);


    try {

        $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
// set the PDO error mode to exception
        $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        $myPDO->beginTransaction();


        $sql = 'insert into transactions values(transaction_id,:datetra,:timetra,(select account_id from accounts where email=:email),(select currentbal from accounts where email=:email1),0,:typetra)';
        $sth = $myPDO->prepare($sql);
        $datenow = date("Y-m-d");
        $timenow = date("h:i:s");
        $sth->execute([':datetra' => $datenow, ':timetra' => $timenow, ':email' => $email,':email1' => $email,':typetra' => "cancel"]);


        $sql = 'UPDATE accounts  SET  is_valid="no", currentbal= 0 WHERE email=:email';
        $sth = $myPDO->prepare($sql);
        $sth->execute([':email' => $email]);
        $result = $sth->rowCount();

        $myPDO->commit();

    } catch
    (PDOException $e) {
        //an exception was thrown and this is the error
        $myPDO->rollBack();
        exit();

    }


    if ($result == 0) {
        echo "<div style='color: red; font-weight: bold; font-size: 16px'>Something went wrong!</div>";

    } else {
        echo "<div style='color: green; font-weight: bold; font-size: 18px'>Ticket Cancelled</div>";
    }

}exit();
?>