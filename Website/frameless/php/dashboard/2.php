    <?php
session_start();
try {
    $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
    $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

} catch (PDOException $ex) {
echo $ex->getMessage();
}

    $sumdeposit = $sumregistration = $sumitems = $sumfood = $sumloan = $currentbalance = $totalAmountSpent = $currentbalance = 0;
    $paid = "No";
    $campspot = 0;
    $_SESSION['email'] = 'hamidisubhi@gmail.com';;
    $query = $myPDO->prepare('SELECT spot_nr,is_paid FROM camp_reservation where account_id=(select account_id from accounts where email=:mail);');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    $paid = $result['is_paid'];
    if ($paid == "yes") {
        $paid = "Paid";
    } else {
        $paid == "Payment Required";
    }
    $campspot = $result['spot_nr'];

    $query = $myPDO->prepare('SELECT currentbal as amount FROM accounts where email=:mail ;');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    $currentbalance = $result['amount'];

//Sum deposit amount
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="deposit";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    if (isset($result['amount'])) {
        $sumdeposit = $result['amount'];
    }
//Sum Food money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="food";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    if (isset($result['amount'])) {
        $sumfood = $result['amount'];
    }
//sum loan money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="loan";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);

    if (isset($result['amount'])) {
        $sumloan = $result['amount'];
    }
//sum items money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="items";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);

    if (isset($result['amount'])) {
        $sumitems = $result['amount'];
    }
//some registeration money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="registration"');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    if (isset($result['amount'])) {
        $sumregistration = $result['amount'];
    }
//sum camp money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="camp";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    if (isset($result['amount'])) {
        $sumregistration += $result['amount'];
    }
    $totalAmountSpent = $sumloan + $sumfood + $sumitems + $sumregistration;

?>
<!DOCTYPE HTML>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Highcharts Example</title>

		<style type="text/css">
#container {
    height: 400px; 
    min-width: 310px; 
    max-width: 800px;
    margin: 0 auto;
}
		</style>
	</head>
	<body>

<script src="code/highcharts.js"></script>
<script src="code/highcharts-3d.js"></script>
<script src="code/modules/exporting.js"></script>
<script src="code/modules/export-data.js"></script>

<div id="container" style="height: 400px"></div>

<script type="text/javascript">

    Highcharts.chart('container', {
        chart: {
            type: 'column',
            options3d: {
                enabled: true,
                alpha: 10,
                beta: 25,
                depth: 70
            }
        },
        title: {
            text: 'Total Spent Expenses'
        },
        subtitle: {
            text: 'The amounts has been split by category'
        },
        plotOptions: {
            column: {
                depth: 25
            }
        },
        xAxis: {
            categories: ['Loan','Food','Items','Registration','Total Deposit']
            labels: {
                skew3d: true,
                style: {
                    fontSize: '16px'
                }
            }
        },
        yAxis: {
            title: {
                text: null
            }
        },
        series: [{
            name: 'Amount',
            data: [<?php echo $sumloan; ?>, <?php echo $sumfood; ?>, <?php echo $sumitems; ?>, <?php echo $sumregistration; ?>, <?php echo $sumdeposit; ?>]
    }]
    });
</script>
	</body>
</html>
