

<div class="account-pages"></div>
<div class="clearfix"></div>
<div class="wrapper-page">
    <div class="text-center">
        <a href="index.html" class="logo"><span>HighLands Halloween <span>Festival</span></span></a>
    </div>
    <div class="m-t-40 card-box">
        <div class="text-center">
            <h4 class="text-uppercase font-bold mb-0">Sign In</h4>
        </div>
        <div class="p-20">
            <form class="form-horizontal m-t-20" action="?page=loginhandler"  method="post">
                <?php if(isset($err)){echo $err;}?>
                <div class="form-group">
                    <div class="col-xs-12">
                        <input class="form-control" type="text" required="" placeholder="Username" name="login_email">
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-xs-12">
                        <input class="form-control" type="password" required="" placeholder="Password" name="login_password">
                    </div>
                </div>

                <div class="form-group ">
                    <div class="col-xs-12">
                        <div class="checkbox checkbox-custom">
                            <input id="checkbox-signup" type="checkbox">
                            <label for="checkbox-signup">
                                Remember me
                            </label>
                        </div>

                    </div>
                </div>

                <div class="form-group text-center m-t-30">
                    <div class="col-xs-12">
                        <button class="btn btn-success btn-bordred btn-block waves-effect waves-light" type="submit">Log In</button>
                        <button class="btn btn-primary btn-bordred btn-block waves-effect waves-light" href="/">Back Home</button>
                    </div>
                </div>

                <div class="form-group m-t-30 mb-0">
                    <div class="col-sm-12">
                        <a href="?page=forgot" class="text-muted"><i class="fa fa-lock m-r-5"></i> Forgot your password?</a>
                    </div>
                </div>
            </form>

        </div>
    </div>
    <!-- end card-box-->
</div>

<!-- jQuery  -->
<script src="assets/js/jquery.min.js"></script>
<script src="assets/js/popper.min.js"></script>
<script src="assets/js/bootstrap.min.js"></script>
<script src="assets/js/waves.js"></script>
<script src="assets/js/jquery.slimscroll.js"></script>

<!-- App js -->
<script src="assets/js/jquery.core.js"></script>
<script src="assets/js/jquery.app.js"></script>
