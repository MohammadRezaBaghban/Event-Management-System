<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {
        var addDiv = $('#addinput');
        var i = $('#addinput p').size() + 2;

        $('#addNew').live('click', function () {
            if (i < 6) {
                $('<div id="person">' + '<p><strong>----------------------------------------------</strong> <div class="form-group " > <label for="fname" class="col-sm-2 control-label" >First Name</label> <div class="col-sm-10"> <input type="text" class="form-control" id="fname"placeholder="Enter your first name here"  name="fnames[]" required> </div> </div><div class="form-group"> <label for="lname" class="col-sm-2 control-label" >Last Name</label> <div class="col-sm-10"> <input type="text" class="form-control" id="lname"placeholder="Enter your last name here" name="lnames[]" required> </div> </div><div class="form-group"> <label for="mail" class="col-sm-2 control-label">Email</label><div class="col-sm-10"><div class="input-group input-group-sm"><span class="input-group-addon">@</span><input type="text" class="form-control" placeholder="" name="emails[]" required></div></div></div><a href="#" id="remNew">Remove</a> </p></div>').appendTo(addDiv);
                i++;

                return false;
            }
            else {
                $('<div id="person"><p ><strong>----------------------------------------------</strong> <div class="form-group" > <label for="fname" class="col-sm-2 control-label" >First Name</label> <div class="col-sm-10"> <input type="text" class="form-control" id="fname"placeholder="Enter your first name here"  name="fnames[]" required > </div> </div><div class="form-group"> <label for="lname" class="col-sm-2 control-label" >Last Name</label> <div class="col-sm-10"> <input type="text" class="form-control" id="lname"placeholder="Enter your last name here" name="lnames[]" required> </div> </div> <div class="form-group"> <label for="mail" class="col-sm-2 control-label">Email</label> <div class="col-sm-10"> <div class="input-group input-group-sm"> <span class="input-group-addon">@</span> <input type="text" class="form-control" placeholder="" name="emails[]" required> </div> </div> </div><a href="#" id="remNew">Remove</a> </p></div>').appendTo(addDiv);
                $('#addNew').toggle();
                return false;
            }
        });

        $('#remNew').live('click', function () {

            $('#person').remove();
            i--;

            return false;
        });
    });

</script>
<div>
<?php
if(isset($err2)){echo $err2;}
?>
</div>
<div class="container">
    <form class="form-horizontal" role="form" action="<?php if($_GET['type'] == 'vip'){echo htmlspecialchars("?page=signup&type=vip");}
    else if($_GET['type'] == 'group'){echo htmlspecialchars("?page=signup&type=group");} else{ echo htmlspecialchars("?page=signup&type=individual");} ?>" method="post"
          enctype="multipart/form-data">

        <div class="row">
            <div <?php if($_GET['type'] == 'individual'){ ?> class="col-sm-12" align="middle" <?php } if($_GET['type'] == 'group' || $_GET['type'] == 'vip'){ ?> class="col-sm-7" align="middle" <?php } ?>>
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Booking Form</h3>
                    </div>

                    <div class="panel-body">

                        <div class="form-group">
                            <label for="fname" class="col-sm-2 control-label">First Name</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" name="fname1"
                                       placeholder="Enter your first name here" required>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lname" class="col-sm-2 control-label">Last Name</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" name="lname1"
                                       placeholder="Enter your last name here" required>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="mail" class="col-sm-2 control-label">Email</label>
                            <div class="col-sm-10">
                                <div class="input-group input-group-sm">
                                    <span class="input-group-addon">@</span>
                                    <input type="text" class="form-control" placeholder="" name="email1" required>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="rep-mail" class="col-sm-2 control-label">Repeat mail</label>
                            <div class="col-sm-10">
                                <div class="input-group input-group-sm">
                                    <span class="input-group-addon">@</span>
                                    <input type="text" class="form-control" placeholder="" name="email2" required>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="password" class="col-sm-2 control-label">Password</label>
                            <div class="col-sm-10">
                                <input type="password" class="form-control" name="passwd1" required>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="password" class="col-sm-2 control-label">Confirm your password
                            </label>
                            <div class="col-sm-10">
                                <input type="password" class="form-control" name="passwd2" required>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="phonenr" class="col-sm-2 control-label">Phone Number</label>
                            <div class="col-sm-10">
                                <div class="input-group input-group-sm">
                                    <span class="input-group-addon">+</span>
                                    <input type="number" class="form-control" name="phonenr" placeholder="" required>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="iban" class="col-sm-2 control-label">IBAN</label>
                            <div class="col-sm-10">
                                <div class="input-group input-group-sm">
                                    <span class="input-group-addon">€</span>
                                    <input type="text" class="form-control" name="iban" placeholder="" required>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="initialbal" class="col-sm-2 control-label">Top Up*</label>
                            <div class="col-sm-10">
                                <div class="input-group input-group-sm">
                                    <span class="input-group-addon">€</span>
                                    <input type="number" class="form-control" name="initialbal" placeholder="" required>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="initialbal" class="col-sm-10">*Initial amount of 500 Euros will be added automatically for groups! </label>
                        </div>
                        <div class="form-group">
                            <label for="initialbal" class="col-sm-10">*Initial amount of 250 Euros will be added automatically for VIP! </label>
                        </div>
                        <div class="form-group">
                            <label for="initialbal" class="col-sm-10">*Initial amount of 65 Euros will be added automatically for individual! </label>
                        </div>


                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10 align-left">
                                <div class="checkbox">
                                    <label>
                                        <input type="checkbox" required>I accept terms and conditions of registration
                                        and refund policy
                                    </label>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
            </div>
            <?php if ($_GET['type'] == 'vip') { ?>
            <div class="col-sm-5" align="middle">

                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Camp reserve</h3>
                    </div>
                    <div class="panel-body">
                        <div class="form-group">
                            <label for="camp" class="col-sm-5 control-label">Camp Spot Number</label>
                            <div class="col-sm-7">
                                <input type="number" class="form-control" id="campspotnr" name="campspotnr"
                                       placeholder="Enter your preferred Camp Spot Nr." required>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-5 control-label">Payment??</label>
                            <div class="col-sm-7 control-label highlight" style="color: #2a6496;">
                                <label>
                                    No Extra Fees Applied!
                                </label>
                            </div>

                        </div>
                        <div class="panel-footer" style="overflow:hidden;text-align:right;">
                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-10">
                                    <button type="button" class="btn btn-sm">Check Availability</button>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                <?php } ?>

                <?php if ($_GET['type'] == 'group') { ?>
                    <div class="col-sm-5" align="middle">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">Camp reserve</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-group">
                                    <label for="camp" class="col-sm-2 control-label">Camp Spot Number</label>
                                    <div class="col-sm-10">
                                        <input type="number" class="form-control" id="campspotnr" name="campspotnr"
                                               placeholder="Enter your preferred Camp Spot Nr." required>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-sm-2 control-label">Pay now?</label>
                                    <div class="col-sm-10 align-left">
                                        <div class="radio-inline">
                                            <label>
                                                <input id="camppay" name="camppay" value="yes" type="radio" required>
                                                Yes!</label>
                                        </div>
                                        <div class="radio-inline">
                                            <label>
                                                <input id="camppay" name="camppay" value=no" type="radio">
                                                No</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="panel-footer" style="overflow:hidden;text-align:right;">
                                <div class="form-group">
                                    <div class="col-sm-offset-2 col-sm-10">
                                        <button type="button" class="btn btn-sm">Check Availability</button>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">Group Members</h3>
                            </div>
                            <div class="panel-body">

                                <p>----------------------------------------------</p>
                                <div class="form-group">
                                    <label for="fname" class="col-sm-2 control-label">First Name</label>
                                    <div class="col-sm-10">
                                        <input type="text" class="form-control" id="fname" name="fnames[]"
                                               placeholder="Enter your first name here" required>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="lname" class="col-sm-2 control-label">Last Name</label>
                                    <div class="col-sm-10">
                                        <input type="text" class="form-control" id="lname" name="lnames[]"
                                               placeholder="Enter your last name here" required>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="mail" class="col-sm-2 control-label">Email</label>
                                    <div class="col-sm-10">
                                        <div class="input-group input-group-sm">
                                            <span class="input-group-addon">@</span>
                                            <input type="text" class="form-control" placeholder="" name="emails[]" required>
                                        </div>
                                    </div>
                                </div>


                                <div id="addinput">
                                    <p>
                                        <a href="#" id="addNew">Add</a>
                                    </p>
                                </div>

                            </div>
                        </div>
                    </div>
                <?php } ?>
            </div>
        </div>
            <div class="form-register" style="overflow:hidden;text-align:center;">
                <button type="submit" class="btn btn-success bg-success" style="background-color: limegreen">Submit</button>

                <input class="btn btn-danger bg-warning" style="background-color: orangered" type="submit" value="Cancel"
                       onclick="window.location='?page=home';" />
            </div>
    </form>

</div>

