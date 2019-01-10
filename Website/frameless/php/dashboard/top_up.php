<?php
$date = new DateTime("2018-01-21 11:00:00");
$datenow = new DateTime();
if ($date > $datenow) {
    # current time is greater than 2018-01-23 12:00:00
    # in other words, 2018-01-23 12:00:00 has passed
    echo "Ops, you have to use the ATMs!";
exit();
}
else{

$amount = $_REQUEST['amount'];
$email = $_REQUEST['email'];




if($amount=="")
{
    echo "please select amount";
    exit();
}
else if($email=="")
{

        exit();
}
else
{  $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
// set the PDO error mode to exception
    $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    try{
        $myPDO->beginTransaction();

        $sql = 'insert into transactions values(transaction_id,:datetra,:timetra,(select account_id from accounts where email=:email),:amount,(select currentbal from accounts where email=:emails)+:amount,:typetra);';
        $sth = $myPDO->prepare($sql);
        $datenow = date("Y-m-d");
        $timenow = date("h:i:s");


        $sth->execute([':datetra' => $datenow, ':timetra' => $timenow, ':email' => $email, ':emails' => $email, ':amount' => $amount, ':typetra' => "deposit"]);

    $sql = 'update accounts set currentbal = currentbal + :amount WHERE email=:email';
    $sth = $myPDO->prepare($sql);
    $sth->execute([':amount' => $amount,':email' => $email]);
    $result = $sth->rowCount();

        if(isset($result)){
            echo "<p style='color: green'>Top Up succeeded</p>";

        }
        else {
            echo "<p style='color: red'>something went wrong!</p>";
        }

    $myPDO->commit();
        exit();

    }catch (PDOException $E){
        $myPDO->rollBack();
        echo "Top Up Failed";
        exit();
    }
    

}
}

?>
