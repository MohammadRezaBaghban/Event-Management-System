<script>function submitContact()
    {
        var name = document.getElementById('cname').value;
        var email = document.getElementById('cemail').value;
        var message = document.getElementById('cmessage').value;
        var url = "Others/contactus.php?name="+name+"&email="+email+"&message="+message;

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
                    document.getElementById('contactform').innerHTML =result ;
                }
            }
        }


        xmlhttp.open("GET",url,true);

        xmlhttp.send();

    }
</script>
<div id="email-ticket" class="modal-window" data-modal="email-ticket"
     style="background-color:transparent;margin-top: 50px;">
    <div class="modal-box small animated" data-animation="zoomIn" data-duration="700">
        <span class="close-btn icon icon-office-52"></span>
        <h5 class="align-center"><span class="highlight">Contact Us</span></h5>
        <form class="form registration-form align-center" >
            <div id="contactform"></div>
            <div class="col-sm-12 ">
                <fieldset>
                    <label for="name">Name</label>
                    <input id="cname" name="cname" type="text">
                </fieldset>
            </div>

            <div class="col-sm-12">
                <fieldset>
                    <label for="email">Email</label>
                    <input id="cemail" name="cemail" type="email" class="valid">
                </fieldset>
            </div>

            <div class="col-sm-12">
                <fieldset>
                    <label for="message">Message</label>
                    <textarea id="cmessage" name="cmessage"></textarea>
                </fieldset>
            </div>

            <button type="button" class="btn btn-sm" name="contactSubmit" id="contactSubmit" value="Validated" onclick="submitContact();">Submit!</button>

        </form>

    </div>
</div>