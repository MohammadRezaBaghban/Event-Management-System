<?php
if(!isset($_REQUEST['$spotnr'])){
    echo "please set username";
    exit;
}
$spotnr = $_REQUEST['$spotnr'];

$spotnr = trim($spotnr);


if($spotnr=="")
{
    echo "please enter spot nr";
}
else
{  $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
// set the PDO error mode to exception
    $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    $sql = 'SELECT * FROM camp_spots WHERE spot_nr=:spotnr and is_reserved= "yes"';
    $sth = $myPDO->prepare($sql);
    $sth->execute([':spotnr' => $spotnr]);
    $result = $sth->fetch();

    if (isset($result[0]) == false) {
       echo "<div style='color: red; font-weight: bold; font-size: 16px'>camp spot is already reserved</div>";
    }
    else{
        echo "<div style='color: green; font-weight: bold; font-size: 18px'>Spot Available</div>";
    }
}
?>