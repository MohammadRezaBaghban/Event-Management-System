<?php
session_start();
try {
    $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
    $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

} catch (PDOException $ex) {
    echo $ex->getMessage();
}
if (isset($_SESSION['email'])) {
    $sumdeposit=$sumregistration=$sumitems=$sumfood=$sumloan=$currentbalance=$totalAmountSpent=$currentbalance=0;
    $paid="No";
    $campspot=0;

    $query = $myPDO->prepare('SELECT spot_nr,is_paid FROM camp_reservation where account_id=(select account_id from accounts where email=:mail);');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    $paid = $result['is_paid'];
    if($paid=="yes"){$paid  = "Paid";}else{$paid=="Payment Required";}
    $campspot=$result['spot_nr'];

    $query = $myPDO->prepare('SELECT currentbal as amount FROM accounts where email=:mail ;');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    $currentbalance = $result['amount'];

    //Sum deposit amount
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="deposit";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    if(isset( $result['amount'])){$sumdeposit = $result['amount'];}
    //Sum Food money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="food";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    if(isset( $result['amount'])){$sumfood = $result['amount'];}
    //sum loan money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="loan";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);

    if(isset( $result['amount'])){$sumloan = $result['amount'];}
    //sum items money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="items";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);

    if(isset( $result['amount'])){$sumitems = $result['amount'];}
    //some registeration money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="registration"');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    if(isset( $result['amount'])){$sumregistration = $result['amount'];}
    //sum camp money
    $query = $myPDO->prepare('SELECT sum(amount) as amount FROM transactions where account_id=(select account_id from accounts where email=:mail) and type="camp";');
    $query->execute([':mail' => $_SESSION['email']]);
    $result = $query->fetch(PDO::FETCH_ASSOC);
    if(isset( $result['amount'])){$sumregistration += $result['amount'];}
    $totalAmountSpent=$sumloan+$sumfood+$sumitems+$sumregistration;
    $data = array(round($sumloan, 0),round($sumfood, 0),round($sumitems, 0),round($sumregistration, 0),round($sumdeposit, 0));
?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <title>Dashboard</title>
    <meta name="author" content="SHEMA M.Gael , Subhi Hamidi , Reza Mohammad , Ryan Hermelijn">

    <!-- App css -->
    <link href="back_assets/css/bootstrap.min.css" rel="stylesheet" type="text/css"/>
    <link href="back_assets/css/icons.css" rel="stylesheet" type="text/css"/>
    <link href="back_assets/css/style.css" rel="stylesheet" type="text/css"/>

    <script src="back_assets/js/modernizr.min.js"></script>


</head>

<body>
<script>
    function cancelticket()
    {

        var email = document.getElementById('demail').value;
        var url = "cancel_ticket.php?email="+email;

        if (window.XMLHttpRequest)
        {// code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp=new XMLHttpRequest();
        }
        else
        {// code for IE6, IE5
            xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
        }

        xmlhttp.onreadystatechange=function()
        {
            if (xmlhttp.readyState==4 && xmlhttp.status==200)
            {

                var result = xmlhttp.responseText;
                if(xmlhttp.responseText!='')
                {


                    document.getElementById('cancelticket').innerHTML =result;
                    if(result.includes("Cancelled")){
                        document.getElementsById('contactSubmit').toggle();
                    setTimeout(function(){window.location.replace('../index.php?page=logout');}, 2000);

                      }
                }

            }
        }


        xmlhttp.open("GET",url,true);


        xmlhttp.send();
    }
</script>
<script src="code/highcharts.js"></script>
<script src="code/highcharts-3d.js"></script>
<script src="code/modules/exporting.js"></script>

<script src="code/modules/export-data.js"></script>
<!-- Navigation Bar-->

<header id="topnav">
    <div class="topbar-main">
        <div class="container-fluid">
            <div class="menu-extras topbar-custom">
                <ul class="list-unstyled topbar-right-menu float-right mb-0">
                    <li class="menu-item">
                        <!-- Mobile menu toggle-->
                        <a class="navbar-toggle nav-link">
                            <div class="lines">
                                <span></span>
                                <span></span>
                                <span></span>
                            </div>
                        </a>
                        <!-- End mobile menu toggle-->
                    </li>
                    <li class="dropdown notification-list">
                        <a class="nav-link dropdown-toggle waves-effect waves-light nav-user" data-toggle="dropdown"
                           href="/php/dashboard/dashboard.php" role="button"
                           aria-haspopup="false" aria-expanded="false">
                            <img src="back_assets/images/users/avatar-1.jpg" alt="user" class="rounded-circle">
                        </a>
                        <div class="dropdown-menu dropdown-menu-right profile-dropdown ">
                            <a href="/php/dashboard/settings.php" class="dropdown-item notify-item">
                                <i class="ti-settings m-r-5"></i> Settings
                            </a>
                            <a href="../?page=logout" class="dropdown-item notify-item">
                                <i class="ti-power-off m-r-5"></i> Logout
                            </a>

                        </div>
                    </li>
                </ul>
            </div>
            <!-- end menu-extras -->

            <div class="clearfix"></div>
<input id="demail" type="hidden" value="<?php echo $_SESSION['email'];?>" name="email">
        </div> <!-- end container -->
    </div>
    <!-- end topbar-main -->

    <div class="navbar-custom">
        <div class="container-fluid">
            <div id="navigation">
                <!-- Navigation Menu-->
                <ul class="navigation-menu">
                    <li><a href="/php/dashboard/dashboard.php"><i class="mdi mdi-view-dashboard"></i><span>Dashboard</span></a></li>
                    <li><a href="/php/dashboard/topup.php"><i class="mdi mdi-view-dashboard"></i><span>Top Up</span></a></li>
                    <li><a href="/php/dashboard/settings.php"><i class="mdi mdi-view-settings"></i><span>Settings</span></a></li>
                </ul>
                <!-- End navigation menu -->
            </div> <!-- end #navigation -->
        </div> <!-- end container -->
    </div> <!-- end navbar-custom -->
</header>
<!-- End Navigation Bar-->


<div class="wrapper">
    <div class="container-fluid">

        <div class="row">

            <div class="col-xl-4 col-md-6">
                <div class="card-box tilebox-one">
                    <i class="fi-tag float-right"></i>
                    <h4 class="header-title mt-0 m-b-30">Current Balance</h4>
                    <div class="widget-chart-1">
                        <div class="widget-detail-1">
                            <h2 class="p-t-10 mb-0"> €<?php echo $currentbalance?> </h2>
                        </div>
                    </div>
                </div>
            </div><!-- end col -->

            <div class="col-xl-4 col-md-6">
                <div class="card-box tilebox-one">
                    <i class="fi-tag float-right"></i>
                    <h4 class="header-title mt-0 m-b-30">Total Spent</h4>

                    <div class="widget-chart-1">
                        <div class="widget-detail-1">
                            <h2 class="p-t-10 mb-0"> €<?php echo $totalAmountSpent; ?> </h2>
                        </div>
                    </div>
                </div>
            </div><!-- end col -->

            <div class="col-xl-4 col-md-6">
                <div class="card-box tilebox-one">
                    <i class="fi-tag float-right"></i>
                    <h4 class="header-title mt-0 m-b-30">Ticket Status</h4>

                    <div class="widget-chart-1">
                        <div class="widget-detail-1">
                            <h2 class="p-t-10 mb-0"> VALID </h2>

                        </div>
                        <div id="cancelticket"></div>

                    </div>
                </div>

                <div class="text-right m-b-0">
                    <button class="btn btn-danger" type="submit"  style="margin-top: -120px;margin-right: 10px;" name="contactSubmit" id="contactSubmit" value="Validated" onclick="if(confirm('Are you sure that you want to cancel the ticket?! We will only refund 75% of the ticket fees')){cancelticket();} else {return false;}">
                        CANCEL TICKET
                    </button>
                </div>
            </div><!-- end col -->

        </div>
        <!-- end row -->

        <div class="row">
            <div class="col-xl-4">
                <div class="card-box">
                    <h4 class="header-title mt-0">Statistics</h4>
                    <div id="container" style="height: 400px; width: 100%; min-width: 310px;
    max-width: 800px;">
                        <script type='text/javascript'>

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
                                  data: [<?php echo join($data, ',') ?>]
                                }]
                            });
                        </script>

                    </div>
                </div>
            </div><!-- end col -->
            <div class="col-xl-8">
                <div class="card-box">

                    <h4 class="header-title mt-0 m-b-30">Group Members</h4>
                    <h4 class="header-title mt-0 m-b-30 float-left">Spot # : <?php echo $campspot; ?></h4>
                    <h4 class="header-title  mt-0 m-b-30 text-center" >Payment Status : <?php if($paid == "Paid"){echo "<span class='badge badge-success'>Paid</span>";}else{echo "<span class='badge badge-danger'>Pending</span>";} } ?></h4>

                    <div class="table-responsive">
                        <table class="table mb-0">
                            <thead>
                            <tr>
                                <th>#</th>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Email</th>
                            </tr>
                            </thead>
                            <tbody>
                            <?php

                            if (isset($_SESSION['email'])) {
                                $query = $myPDO->prepare('SELECT user_id as user_id, fname,lname,email FROM users where group_id=(select group_id from users where email=:mail) ORDER BY user_id;');
                                $query->execute([':mail' => $_SESSION['email']]);
                                while ($result = $query->fetch(PDO::FETCH_ASSOC)){
                                    extract($result);
                                ?>
                                <tr>
                                    <td><?php echo $user_id; ?></td>
                                    <td><?php echo $fname; ?></td>
                                    <td><?php echo $lname; ?></td>
                                    <td><?php echo $email; ?></td>
                                </tr>
                            <?php }} ?>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div><!-- end col -->
        </div> <!-- end container -->
        <!-- Footer -->
        <footer class="footer">
            <div class="container">
                <div class="row">
                    <div class="col-12 text-center">
                        2018 - 2019 © HIGHLANDS HALLOWEEN FESTIVAL
                    </div>
                </div>
            </div>
        </footer>
     



        <!-- jQuery  -->
        <script src="back_assets/js/jquery.min.js"></script>
        <script src="back_assets/js/popper.min.js"></script>
        <script src="back_assets/js/bootstrap.min.js"></script>
        <script src="back_assets/js/waves.js"></script>
        <script src="back_assets/js/jquery.slimscroll.js"></script>

        <!-- KNOB JS -->
        <!--[if IE]>
        <script  src="back_assets/js/canvasjs.min.js"></script>

        <![endif]-->
        <!--Morris Chart-->
        <script src="back_assets/plugins/morris/morris.min.js"></script>
        <script src="back_assets/plugins/raphael/raphael-min.js"></script>

        <!-- Dashboard init -->
        <script src="back_assets/pages/jquery.dashboard.js"></script>
        <!-- App js -->
        <script src="back_assets/js/jquery.core.js"></script>
        <script src="back_assets/js/jquery.app.js"></script>


</body>
</html>