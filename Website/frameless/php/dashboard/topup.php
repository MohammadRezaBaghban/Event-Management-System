topup.php

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
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>


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


<script type="text/javascript">
$(document).ready(function(){
$('.slectOne').on('change', function() {
   $('.slectOne').not(this).prop('checked', false);
   $('#result').html($(this).data( "id" ));
   if($(this).is(":checked"))
   	$('#result').html($(this).data( "id" ));
   else
   	$('#result').html('Empty...!');
});
});
</script>
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
<div class="wrapper" style="padding-top: 100px;">
	<div class="container-fluid">
		<div class="row">
            <div class="col-sm-12">
                <div class="card-box">

                    <h4 class="header-title m-t-0 m-b-30">Top Up Form</h4>

                    <div class="row">
                        <div class="col-xl-6">
                            <form class="form-horizontal group-border-dashed" action="#" novalidate="">
                                <div class="form-group row">
                                    <label class="col-sm-3 col-form-label">Choose Amount</label>
                                    <div class="col-sm-6">
                                        <div class="checkbox checkbox-pink">
                                            <input id="checkbox1" class="slectOne" type="checkbox" name="">
                                            <label for="checkbox1"> 30 Euros </label>
                                        </div>
                                        <div class="checkbox checkbox-pink">
                                            <input id="checkbox2" type="checkbox" class="slectOne" name="">
                                            <label for="checkbox2"> 40 Euros </label>
                                        </div>
                                        <div class="checkbox checkbox-pink">
                                            <input id="checkbox3" type="checkbox" class="slectOne" name="">
                                            <label for="checkbox3"> 50 Euros </label>
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
                        </div><!-- end col -->
                    </div><!-- end row -->
                </div>
            </div><!-- end col -->
        </div>
    </div>
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