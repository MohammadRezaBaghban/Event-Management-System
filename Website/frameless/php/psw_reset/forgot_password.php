<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8" />
        <title>HighLands Halloween Festival</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
        <meta content="HHF" name="SHEMA M.GAEL , SUBHI HAMIDI" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />

        <!-- App favicon -->
        <link rel="shortcut icon" href="assets/images/favicon.ico">

        <!-- App css -->
        <link href="SignUp-SignIn-SignOut/front_assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
        <link href="SignUp-SignIn-SignOut/front_assets/css/icons.css" rel="stylesheet" type="text/css" />
        <link href="SignUp-SignIn-SignOut/front_assets/css/style.css" rel="stylesheet" type="text/css" />

        <script src="assets/js/modernizr.min.js"></script>

    </head>

    <body>

        <div class="account-pages">
        <div class="wrapper-page">
            <div class="text-center">
                <a href="?page=home" class="logo"><span>HighLands Halloween <span>Festival</span></span></a>
            </div>
            <div class="m-t-40 card-box">
                <div class="text-center">
                    <h4 class="text-uppercase font-bold mb-0">Reset Password</h4>

                    <p class="text-muted m-b-0 font-13 m-t-20" style="color: black !important">Enter your email address and we'll send you an email with instructions to reset your password.  </p>
                </div>
                <div class="p-20">
                    <form class="form-horizontal m-t-20" action="./index.php?page=change" method="post">

                        <div class="form-group">
                            <div class="col-xs-12">
                                <input class="form-control" type="email" name="email" required>
                            </div>
                        </div>

                        <div class="form-group text-center m-t-20 mb-0">
                            <div class="col-xs-12">
                                <button class="btn btn-success btn-bordred btn-block waves-effect waves-light" type="submit" name="ForgotPassword" value=" Request Reset ">Send Email</button>
                            </div>
                        </div></form>
                    <form action="?page=home">
                        <button type="submit" class="btn btn-success btn-bordred btn-block waves-effect waves-light">Back Home</button>
                    </form>




                </div>
            </div>
            <!-- end card-box -->

            <div class="row">
                <div class="col-sm-12 text-center">
                    <p class="text">Already have account?<a href="?page=login" class="text-primary m-l-5"><b>Sign In</b></a></p>
                </div>
            </div>

        </div>
        <!-- end wrapper page -->
        </div>

    </body>
</html>