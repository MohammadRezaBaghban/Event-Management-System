<?php
session_start();
if (isset($_POST["formpassword"])) {
$mailchange = $_SESSION['email'];
$password = $_REQUEST['pass1'];
$confirmpassword = $_REQUEST['pass2'];


if($_SESSION['email']=="")
{
    echo "error recieving mail";
}
else
{  $myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi400320', 'dbi400320', '12345678');
// set the PDO error mode to exception
    $myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    function check($email)
    {
        $query = (object)$GLOBALS['myPDO']->prepare('SELECT * FROM accounts WHERE email = :email');
        $query->execute([':email' => $email]);
        $result = $query->fetch(PDO::FETCH_ASSOC);
        $user = $result['email'];
        return $user;
    }
    if (check($mailchange)!=null)
    {
        if ($password == $confirmpassword) {

            //has and secure the password

            $password = password_hash($password, PASSWORD_DEFAULT);


            // Update the user's password

            $query = $myPDO->prepare('UPDATE accounts SET password = :password WHERE email = :email');

            $query->bindParam(':password', $password);

            $query->bindParam(':email', $user);

            $query->execute();
            //delete the tokens to prevent reusing the link again

            $myPDO = null;
            echo "Your password has been successfully reset.";
            echo "<script>alert('successfully changed');</script>";
            echo "<script>setTimeout(function(){window.location.replace('../index.php?page=dashboard');}, 2000);</script>";


        } else
            echo "<script>alert('Your passwords do not match');</script>";
            echo "Your password's do not match.";

    }
}
}
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

        </div> <!-- end container -->
    </div>
    <!-- end topbar-main -->

    <div class="navbar-custom">
        <div class="container-fluid">
            <div id="navigation">
                <!-- Navigation Menu-->
                <ul class="navigation-menu">
                    <li><a href="/"><i class="mdi mdi-view-dashboard"></i><span>Home</span></a></li>

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
            <div class="col-xl-12">
                <div class="card-box">
                    <h4 class="header-title m-t-0 m-b-30">Reset Password Form</h4>

                    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>" method="post" data-parsley-validate="" novalidate="">
                        <input id="semail" type="hidden" value="<?php echo $_SESSION['email'];?>" name="email">
                        <div class="form-group">
                            <label for="userName">Old Password</label>
                            <input type="password" name="pass1" required class="form-control" id="password">
                        </div>
                        <div class="form-group">
                            <label for="emailAddress">New Password</label>
                            <input type="password" name="pass2" required class="form-control" id="password2">
                        </div>
                        <div class="form-group text-right m-b-0">
                            <button class="btn btn-primary waves-effect waves-light" type="submit" name="formpassword">
                                Submit
                            </button>
                        </div>

                    </form>
                </div>
            </div><!-- end col -->
        </div>
        <!-- end row -->
    </div> <!-- end container -->



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