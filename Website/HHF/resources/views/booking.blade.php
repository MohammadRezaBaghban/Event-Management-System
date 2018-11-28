@include('layouts.welcome-page-header')

<body>
@include('layouts.navigation')
<script  src="https://ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js"></script>
<script type="text/javascript">
    $(function() {
        var addDiv = $('#addinput');
        var i = $('#addinput p').size() + 2;

        $('#addNew').live('click', function() {
           if(i<6){ $('<div id="person">' + '<p><strong>----------------------------------------------</strong> <div class="form-group" > <label for="fname" class="col-sm-2 control-label" >First Name</label> <div class="col-sm-10"> <input type="text" class="form-control" id="fname"placeholder="Enter your first name here"  name="fname'+ i +'"> </div> </div><div class="form-group"> <label for="lname" class="col-sm-2 control-label" >Last Name</label> <div class="col-sm-10"> <input type="text" class="form-control" id="lname"placeholder="Enter your first name here" name="lname'+ i +'"> </div> </div> <div class="form-group"> <label for="phonenr" class="col-sm-2 control-label">Phone Number</label> <div class="col-sm-10"> <div class="input-group input-group-sm"> <span class="input-group-addon">+</span> <input type="number" class="form-control" placeholder="" name="phone'+ i +'"> </div> </div> </div><a href="#" id="remNew">Remove</a> </p></div>').appendTo(addDiv);
            i++;

            return false;}
            else {$('<div id="person"><p ><strong>----------------------------------------------</strong> <div class="form-group" > <label for="fname" class="col-sm-2 control-label" >First Name</label> <div class="col-sm-10"> <input type="text" class="form-control" id="fname"placeholder="Enter your first name here"  name="fname'+ i +'"> </div> </div><div class="form-group"> <label for="lname" class="col-sm-2 control-label" >Last Name</label> <div class="col-sm-10"> <input type="text" class="form-control" id="lname"placeholder="Enter your first name here" name="lname'+ i +'"> </div> </div> <div class="form-group"> <label for="phonenr" class="col-sm-2 control-label">Phone Number</label> <div class="col-sm-10"> <div class="input-group input-group-sm"> <span class="input-group-addon">+</span> <input type="number" class="form-control" placeholder="" name="phone'+ i +'"> </div> </div> </div><a href="#" id="remNew">Remove</a> </p></div>').appendTo(addDiv);
               $('#addNew').toggle();
               return false;
           }
        });

        $('#remNew').live('click', function() {

            $('#person').remove();
                i--;

                return false;
        });
    });

</script>
<div class="container">
    <div class="row">
        <div class="col-sm-7">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">New Registration Form</h3>
                </div>
                <div class="panel-body">
                    <form class="form-horizontal" role="form">
                        <div class="form-group">
                            <label for="fname" class="col-sm-2 control-label">First Name</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" name="fname"
                                       placeholder="Enter your first name here" required>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lname" class="col-sm-2 control-label">Last Name</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" name="lname"
                                       placeholder="Enter your last name here" required>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="mail" class="col-sm-2 control-label">Email</label>
                            <div class="col-sm-10">
                                <div class="input-group input-group-sm">
                                    <span class="input-group-addon">@</span>
                                    <input type="text" class="form-control" placeholder="" name="email" required>
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
                                <input type="password" class="form-control" name="passwd" required>
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
                            <label class="col-sm-2 control-label">VIP</label>
                            <div class="col-sm-10 align-left">
                                <div class="radio-inline">
                                    <label>
                                        <input id="withvip" name="withvip" value="vip" type="radio" >
                                        Of Course Yes!</label>
                                </div>
                                <div class="radio-inline">
                                    <label>
                                        <input id="name" name="novip" value="novip" type="radio" >
                                        No, Thanks!</label>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="phonenr" class="col-sm-2 control-label" >Phone Number</label>
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
                            <div class="col-sm-offset-2 col-sm-10 align-left">
                                <div class="checkbox">
                                    <label>
                                        <input type="checkbox">I accept terms and conditions of registration and refund policy
                                    </label>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
                <div class="panel-footer" style="overflow:hidden;text-align:right;">
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <button type="submit" class="btn btn-success btn-sm">Submit</button>
                            <button type="submit" class="btn btn-default btn-sm">Cancel</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>




        <div class="col-sm-5">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Camp reserve</h3>
                </div>
                <div class="panel-body">
                    <form class="form-horizontal" role="form">
                        <div class="form-group">
                            <label for="fname" class="col-sm-2 control-label">First Name</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="fname"
                                       placeholder="Enter your first name here">
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">VIP</label>
                            <div class="col-sm-10 align-left">
                                <div class="radio-inline">
                                    <label>
                                        <input id="withvip" name="withvip" value="" type="radio">
                                        Of Course Yes!</label>
                                </div>
                                <div class="radio-inline">
                                    <label>
                                        <input id="novip" name="novip" value="" type="radio">
                                        No, Thanks!</label>
                                </div>
                            </div>
                        </div>



                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10 align-left">
                                <div class="checkbox">
                                    <label>
                                        <input type="checkbox">I accept terms and conditions of registration and refund policy
                                    </label>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
                <div class="panel-footer" style="overflow:hidden;text-align:right;">
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <button type="submit" class="btn btn-success btn-sm">Submit</button>
                            <button type="submit" class="btn btn-default btn-sm">Cancel</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Group Members</h3>
                </div>
                <div class="panel-body">
                    <form class="form-horizontal" role="form">
                        <p>----------------------------------------------</p>
                        <div class="form-group">
                            <label for="fname" class="col-sm-2 control-label">First Name</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="fname"
                                       placeholder="Enter your first name here">
                            </div>
                        </div><div class="form-group">
                            <label for="lname" class="col-sm-2 control-label">Last Name</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="lname"
                                       placeholder="Enter your first name here">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="phonenr" class="col-sm-2 control-label">Phone Number</label>
                            <div class="col-sm-10">
                                <div class="input-group input-group-sm">
                                    <span class="input-group-addon">+</span>
                                    <input type="number" class="form-control" placeholder="">
                                </div>
                            </div>
                        </div>
                        <p>----------------------------------------------</p>
                        <div class="form-group">
                            <label for="fname" class="col-sm-2 control-label">First Name</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="fname"
                                       placeholder="Enter your first name here">
                            </div>
                        </div><div class="form-group">
                            <label for="lname" class="col-sm-2 control-label">Last Name</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="lname"
                                       placeholder="Enter your first name here">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="phonenr" class="col-sm-2 control-label">Phone Number</label>
                            <div class="col-sm-10">
                                <div class="input-group input-group-sm">
                                    <span class="input-group-addon">+</span>
                                    <input type="number" class="form-control" placeholder="">
                                </div>
                            </div>
                        </div>


                        <div id="addinput">
                            <p>
                            <a href="#" id="addNew">Add</a>
                            </p>
                        </div>
                    </form>
                </div>
                <div class="panel-footer" style="overflow:hidden;text-align:right;">
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <button type="submit" class="btn btn-success btn-sm">Submit</button>
                            <button type="submit" class="btn btn-default btn-sm">Cancel</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</div>

<div id="email-ticket" class="modal-window" data-modal="email-ticket" style="background-color:transparent;margin-top: 50px;">
    <div class="modal-box small animated" data-animation="zoomIn" data-duration="700">
        <span class="close-btn icon icon-office-52"></span>
        <h5 class="align-center"><span class="highlight">Contact Us</span></h5>
        <form class="form registration-form align-center">

            <div class="col-sm-12 ">
                <fieldset>
                    <label for="name">Name</label>
                    <input id="name" name="name" type="text">
                </fieldset>
            </div>

            <div class="col-sm-12">
                <fieldset>
                    <label for="email">Email</label>
                    <input id="email" name="email" type="email" class="valid">
                </fieldset>
            </div>

            <div class="col-sm-12">
                <fieldset>
                    <label for="message">Message</label>
                    <textarea id="message" name="message"></textarea>
                </fieldset>
            </div>
            <input type="submit" value="submit" class="btn">
        </form>

    </div>
</div>
@include('layouts.welcome-page-footer')
</body>
</html>
