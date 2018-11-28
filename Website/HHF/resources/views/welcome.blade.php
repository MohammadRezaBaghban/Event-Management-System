@include('layouts.welcome-page-header')
<body>

<section id="hero" class="hero-section bg6 bg-cover overlay gradient-overlay window-height align-center light-text">
    <ul class="socials-nav">
        <li class="socials-nav-item"><a href="#"><span class="fa fa-twitter"></span></a></li>
        <li class="socials-nav-item"><a href="#"><span class="fa fa-facebook"></span></a></li>
        <li class="socials-nav-item"><a href="#"><span class="fa fa-instagram"></span></a></li>
    </ul>
    <div class="heading-block centered-block align-center">
        <div class="container">
            <h5 class="heading-alt" style="margin-bottom: 8px;">
                <span class="fa fa-calendar-o"></span>Oct 31<span class="fa fa-map-marker"
                                                                  style="margin-left: 14px;"></span>Eindhoven , NL</h5>
            <h1 class="extra-heading">HHF</h1>
            <h6 class="thin base-font">HighLands Halloween Festival</h6>
            <div class="btns-container">
                <a href="#" class="btn btn btn-md">GET TICKETS</a>
            </div>
        </div>
    </div>
</section>

@include('layouts.navigation')

<section id="about" class="section align-center" style="margin-top: -100px;">
    <div class="container">
        <h3>About Us</h3>
        <div class="tabs-wrapper tabs-horizontal">
            <ul class="nav nav-tabs">
                <li class="active">
                    <h6 class="heading-alt"><span class="fa fa-code"></span>General Information</h6>
                </li>
            </ul>

            <div class="tab-content">
                <div id="horizontal_tab1" class="tab-pane fade active in">
                    <div class="col-sm-5 img-column">
                        <img src="https://cdn8.bigcommerce.com/s-410a5/images/stencil/original/uploaded_images/logo-halloween-commerce.png?t=1509014739"
                             alt="" class="img-responsive"/>
                    </div>
                    <div class="col-sm-7 align-left">
                        <h6>About The Event</h6>
                        <p>“Highlands Halloween Festival” or “HHF”, is an event organized by StageBrite.
                            It’s a Halloween Spooktacular where you get to eat, play and be scary.
                        </p>
                        <p>The event will offer activities such as games, dancing, a photo booth and more.
                            Inside the event, you will be able to buy foods, beverages, and souvenirs
                            and also visitors can borrow materials such as Cameras, Torches, PowerBanks and more among them.
                        </p>

                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section id="activities" class="section align-center" style="background-color: #1f2125;">
    <div class="container">
        <span class="icon section-icon icon-badges-votes-01"></span>
        <h3 style="color: white">Activities</h3>
        <p class="text-alt"><span class="highlight">Interested?</span> <span style="color: white">Have A Look!</span></p>
        <br/>

        <div class="gallery masonry">
                <span class="masonry-item">
                    <img src="assets/img/activities_gallery/1.jpg" alt="">
                </span>

            <span class="masonry-item">
                    <img src="assets/img/activities_gallery/2.jpg" alt="">
                </span>

            <span class="masonry-item">
                    <img src="assets/img/activities_gallery/4.jpeg" alt="">
                </span>

            <span class="masonry-item">
                    <img src="assets/img/activities_gallery/3.jpeg" alt="">
                </span>

            <span class="masonry-item">
                    <img src="assets/img/activities_gallery/5.jpeg" alt="">
                </span>

            <span class="masonry-item">
                    <img src="assets/img/activities_gallery/6.jpeg" alt="">
                </span>
        </div>

    </div>
</section>

<section id="tickets" class="section align-center">
    <div class="container">
        <span class="icon section-icon icon-shopping-04"></span>
        <h3>Tickets</h3>
        <p class="text-alt">Get yours why they are still <span class="highlight">available</span></p>
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
                            <li><span class="fa fa-info check-icon"></span>€10 Registration Fee</li>
                        </ul>
                    </div>
                    <a href="/booking" class="btn btn-lg btn-outline-clr">Buy now</a>
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
                    <a href="/booking" class="btn btn-lg">Buy now</a>
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
                            <li><span class="fa fa-info check-icon"></span>€10 Registration Fee</li>
                        </ul>
                    </div>
                    <a href="/booking" class="btn btn-lg btn-outline-clr">Buy now</a>
                </div>
            </div>
        </div>
    </div>
</section>

<section class="footer">
    <div class="container">

        <div class="col-md-6">
            <div class="widget about-widget">
                <h6 class="widget-head">Quotes That We Believe In As <span class="highlight">HHF</span> Community </h6>
                <p class="text-alt" style="color: white;">
                    <small>
                        Productivity is never an accident. It is always
                        the result of a commitment to excellence,
                        intelligent planning, and focused effort.
                    </small>
                    <small>
                        Success depends upon previous preparation,
                        and without such preparation there is sure to be failure.
                    </small>
                    <small>
                        Alone we can do so little; together we can do so much.
                    </small>
                <small>
                    Without leaps of imagination, or dreaming,
                    we lose the excitement of possibilities. Dreaming, after all,
                    is a form of planning
                </small>

                </p>
            </div>
        </div>

        <div class="col-md-6 col-lg-3 col-lg-offset-1">
            <div class="widget twitter-widget">
                <h6 class="widget-head"><span class="fa fa-twitter"></span> Twitter Feed</h6>
                <iframe src="http://twubs.com/embed/HHF_NL/?messagesPerPage=10&headerBgColor=%231c6485&headerTextColor=%23ffffff"
                 width="500" height="450" frameborder="0">#HHF_NL</iframe>
            </div>
        </div>
    </div>
</section>


<div id="email-ticket" class="modal-window" data-modal="email-ticket"
     style="background-color:transparent;margin-top: 50px;">
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
