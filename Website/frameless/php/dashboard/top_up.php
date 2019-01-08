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
    function test()
    {

        var email = document.getElementById('email').value;
        var url = "../Others/cancel_ticket.php";

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
                    document.getElementById('spotnr').innerHTML =result ;
                }
            }
        }


        xmlhttp.open("POST",url,true);
        xmlhttp.setRequestHeader('Content-type','application/x-www-form-urlencoded');

        xmlhttp.send('email=email');
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
                           href="index.html#" role="button"
                           aria-haspopup="false" aria-expanded="false">
                            <img src="back_assets/images/users/avatar-1.jpg" alt="user" class="rounded-circle">
                        </a>
                        <div class="dropdown-menu dropdown-menu-right profile-dropdown ">
                            <a href="javascript:void(0);" class="dropdown-item notify-item">
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
<input id="email" type="hidden" value="<?php echo $_SESSION['email'];?>" name="email">
        </div> <!-- end container -->
    </div>
    <!-- end topbar-main -->

    <div class="navbar-custom">
        <div class="container-fluid">
            <div id="navigation">
                <!-- Navigation Menu-->
                <ul class="navigation-menu">
                    <li><a href="#"><i class="mdi mdi-view-dashboard"></i><span>Dashboard</span></a></li>
                    <li><a href="/php/dashboard/topup.php"><i class="mdi mdi-view-dashboard"></i><span>Top Up</span></a></li>
                    <li><a href="/php/dashboard/settings.php"><i class="mdi mdi-view-settings"></i><span>Settings</span></a></li>
                </ul>
                <!-- End navigation menu -->
            </div> <!-- end #navigation -->
        </div> <!-- end container -->
    </div> <!-- end navbar-custom -->
</header>
<!-- End Navigation Bar-->



<div class="col-xl-6">
                                    <h5 class="m-b-5"><b>Range validation</b></h5>
                                    <p class="text-muted font-13 m-b-30">
                                        Your awesome text goes here.
                                    </p>

                                    <form class="form-horizontal group-border-dashed" action="#" novalidate="">

                                        <div class="form-group row">
                                            <label class="col-sm-3 col-form-label">Min Length</label>
                                            <div class="col-sm-6">
                                                <input type="text" class="form-control" required="" data-parsley-minlength="6" placeholder="Min 6 chars.">
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-sm-3 col-form-label">Max Length</label>
                                            <div class="col-sm-6">
                                                <input type="text" class="form-control" required="" data-parsley-maxlength="6" placeholder="Max 6 chars.">
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-sm-3 col-form-label">Range Length</label>
                                            <div class="col-sm-6">
                                                <input type="text" class="form-control" required="" data-parsley-length="[5,10]" placeholder="Text between 5 - 10 chars length">
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-sm-3 col-form-label">Min Value</label>
                                            <div class="col-sm-6">
                                                <input type="text" class="form-control" required="" data-parsley-min="6" placeholder="Min value is 6">
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-sm-3 col-form-label">Max Value</label>
                                            <div class="col-sm-6">
                                                <input type="text" class="form-control" required="" data-parsley-max="6" placeholder="Max value is 6">
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-sm-3 col-form-label">Range Value</label>
                                            <div class="col-sm-6">
                                                <input class="form-control" required="" type="text range" min="6" max="100" placeholder="Number between 6 - 100">
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-sm-3 col-form-label">Regular Exp</label>
                                            <div class="col-sm-6">
                                                <input type="text" class="form-control" required="" data-parsley-pattern="#[A-Fa-f0-9]{6}" placeholder="Hex. Color">
                                            </div>
                                        </div>

                                        <div class="form-group row">
                                            <label class="col-sm-3 col-form-label">Min check</label>
                                            <div class="col-sm-6">
                                                <div class="checkbox checkbox-pink">
                                                    <input id="checkbox1" type="checkbox" data-parsley-multiple="groups" data-parsley-mincheck="2">
                                                    <label for="checkbox1"> And this </label>
                                                </div>
                                                <div class="checkbox checkbox-pink">
                                                    <input id="checkbox2" type="checkbox" data-parsley-multiple="groups" data-parsley-mincheck="2">
                                                    <label for="checkbox2"> Can't check this </label>
                                                </div>
                                                <div class="checkbox checkbox-pink">
                                                    <input id="checkbox3" type="checkbox" data-parsley-multiple="groups" data-parsley-mincheck="2" required="">
                                                    <label for="checkbox3"> This too </label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-sm-3 col-form-label">Max check</label>
                                            <div class="col-sm-6">
                                                <div class="checkbox checkbox-pink">
                                                    <input id="checkbox4" type="checkbox" data-parsley-multiple="group1">
                                                    <label for="checkbox4"> And this </label>
                                                </div>
                                                <div class="checkbox checkbox-pink">
                                                    <input id="checkbox5" type="checkbox" data-parsley-multiple="group1">
                                                    <label for="checkbox5"> Can't check this </label>
                                                </div>
                                                <div class="checkbox checkbox-pink">
                                                    <input id="checkbox6" type="checkbox" data-parsley-multiple="group1" data-parsley-maxcheck="1">
                                                    <label for="checkbox6"> This too </label>
                                                </div>

                                            </div>
                                        </div>

                                        <div class="form-group row m-b-0">
                                            <div class="offset-sm-3 col-sm-9 m-t-15">
                                                <button type="submit" class="btn btn-primary waves-effect waves-light">
                                                    Submit
                                                </button>
                                                <button type="reset" class="btn btn-secondary waves-effect m-l-5">
                                                    Cancel
                                                </button>
                                            </div>
                                        </div>
                                    </form>
                                </div>

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