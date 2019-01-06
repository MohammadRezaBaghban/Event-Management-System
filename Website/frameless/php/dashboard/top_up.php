<?php

if (new DateTime() > new DateTime("2018-01-23 11:00:00")) {
    # current time is greater than 2018-01-23 12:00:00
    # in other words, 2018-01-23 12:00:00 has passed
    echo "OPS You are late, you can no longer top up from the website. You can still top up by using the ATMs at the Event)!";
    exit();
}
else{

$amount = $_REQUEST['$amount'];
$email = $_REQUEST['$email'];

$amount = trim($amount);
$email = trim($amount);


if($amount=="")
{
    echo "please select amount";
    exit();
}
else if($email=="")
{
        echo "please enter email";
        exit();
}
else
{  $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
// set the PDO error mode to exception
    $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION, PDO::ATTR_EMULATE_PREPARES);
    try{
        $myPDO->beginTransaction();

        $sql = 'insert into transactions values(transaction_id,:datetra,:timetra,(select account_id from accounts where email=:email),:amount,(select currentbal from accounts where email=:email)+:amount,:typetra)';
        $sth = $myPDO->prepare($sql);
        $datenow = date("Y-m-d");
        $timenow = date("h:i:s");


        $sth->execute([':datetra' => $datenow, ':timetra' => $timenow, ':email' => $email, ':amount' => $amount, ':typetra' => "deposit"]);

    $sql = 'update account set currentbal = currentbal + :amount WHERE email=:email';
    $sth = $myPDO->prepare($sql);
    $sth->execute([':amount' => $amount,':email' => $email]);
    $result = $sth->rowCount();

    
    $myPDO->commit();
    echo "Top Up succeeded";
        exit();
    }catch (PDOException $E){
        $myPDO->rollBack();
        echo "Top Up Failed";
        exit();
    }
    

}}
?>