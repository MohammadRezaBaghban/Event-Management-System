<section id="tickets" class="section align-center" style=" background-color: white;">
    <div class="container">
        <span class="icon section-icon icon-shopping-04"></span>
        <h3 style="color: black;">Tickets</h3>
        <p class="text-alt">Get yours while they are still <span class="highlight">available</span></p>
        <?php $date = new DateTime("2019-01-20 11:00:00");
        $datenow = new DateTime();
        if ($datenow > $date) {
            # current time is greater than 2018-01-23 12:00:00
            # in other words, 2018-01-23 12:00:00 has passed
            echo "<p style='color: red; font-size: 18px;'><strong>OPS You are late, you can no longer buy tickets from the website. You can still buy them from the event itself(Extra Fees Applied)!</strong></p>";
			
        }
        ?>
        <br/>
        <br/>

        <div class="row">
            <div class="col-sm-4">
                <div class="package-column">
                    <h6 class="package-title">Individual</h6>
                    <div class="package-price">
                        <span class="currency">€</span>55
                    </div>
                    <div class="package-detail">
                        <ul>
                            <li><span class="fa fa-info check-icon"></span>€10 Registration Fee</li>
                            <li><span class="fa fa-ban check-icon"></span>Camping <span class="bold">NOT</span> Available</li>
                        </ul>
                    </div>
                    <a href="?page=booking&type=individual" class="btn btn-lg btn-outline-clr">Buy now</a>
                </div>
            </div>

            <div class="col-sm-4">
                <div class="package-column special-column">
                    <span class="sale-label uppercase">Hot!</span>
                    <h6 class="package-title">VIP</h6>
                    <div class="package-price">
                        <span class="currency">€</span>150
                    </div>
                    <div class="package-detail">
                        <ul>
                            <li><span class="fa fa-minus check-icon"></span>Camping Fee: €130</li>
                            <li><span class="fa fa-info check-icon"></span>Furnished Tents</li>
                            <li><span class="fa fa-check check-icon"></span>Faster Check In</li>
                            <li><span class="fa fa-check check-icon"></span>Free Snacks</li>
                            <li><span class="fa fa-check check-icon"></span>Free Parking</li>

                        </ul>
                    </div>
                    <a href="?page=booking&type=vip" class="btn btn-lg">Buy now</a>
                </div>
            </div>

            <div class="col-sm-4">
                <div class="package-column">
                    <h6 class="package-title">Group(s)</h6>
                    <div class="package-price">
                        <span class="currency">€</span>55
                    </div>
                    <div class="package-detail">
                        <ul>
                            <li><span class="fa fa-info check-icon"></span>Price is Per Person</li>
                            <li><span class="fa fa-check check-icon"></span>Up to 6 People</li>
                            <li><span class="fa fa-check check-icon"></span>Camping Available for </li>
                            <li><span class="fa fa-info check-icon"></span>€20/Person</li>

                        </ul>
                    </div>
                    <a href="?page=booking&type=group" class="btn btn-lg btn-outline-clr">Buy now</a>
                </div>
            </div>
        </div>
    </div>
</section>