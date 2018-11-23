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
                    <img src="assets/img/activities_gallery/gallery1-thumb.png" alt="">
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
                            <li><span class="fa fa-check check-icon"></span>Regular Seating</li>
                            <li><span class="fa fa-check check-icon"></span>Free Snacks</li>
                            <li><span class="fa fa-check check-icon"></span>Custom Badge</li>
                        </ul>
                    </div>
                    <a href="#" class="btn btn-lg btn-outline-clr">Buy now</a>
                </div>
            </div>

            <div class="col-sm-4">
                <div class="package-column special-column">
                    <span class="sale-label uppercase">Hot!</span>
                    <h6 class="package-title">VIP</h6>
                    <div class="package-price">
                        <span class="currency">€</span>55
                    </div>
                    <div class="package-detail">
                        <ul>
                            <li><span class="fa fa-check check-icon"></span>Regular Seating</li>
                            <li><span class="fa fa-check check-icon"></span>Free Snacks</li>
                            <li><span class="fa fa-check check-icon"></span>Custom Badge</li>
                        </ul>
                    </div>
                    <a href="#" class="btn btn-lg">Buy now</a>
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
                            <li><span class="fa fa-check check-icon"></span>Regular Seating</li>
                            <li><span class="fa fa-check check-icon"></span>Free Snacks</li>
                            <li><span class="fa fa-check check-icon"></span>Custom Badge</li>
                        </ul>
                    </div>
                    <a href="#" class="btn btn-lg btn-outline-clr">Buy now</a>
                </div>
            </div>
        </div>
    </div>
</section>

<section class="footer">
    <div class="container">

        <div class="col-md-6">
            <div class="widget about-widget">
                <h6 class="widget-head">Thoughts on <span class="highlight">HHF</span></h6>
                <p class="text-alt">
                    <small>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has
                        been the industry's standard dummy text ever since the 1500s, when an unknown printer took a
                        galley of type and scrambled it to make a type.
                    </small>
                </p>
            </div>
        </div>

        <div class="col-md-6 col-lg-3 col-lg-offset-1">
            <div class="widget twitter-widget">
                <h6 class="widget-head"><span class="fa fa-twitter"></span> Twitter Feed</h6>

                <ul class="tweets-list">
                    <li class="tweet">
                        <p class="text-alt tweet-text">Grabehan <a href="#">#NowPlaying</a> Future People by Alabama
                            Shakes <a href="http://spoti.fi/1CTPWcW">http://spoti.fi/1CTPWcW</a></p>
                        <small class="tweet-date">7 sep 2015</small>
                    </li>

                    <li class="tweet">
                        <p class="text-alt tweet-text">Loving <a href="#">@TryGhost</a> so far. Ghost theming here I
                            come!</p>
                        <small class="tweet-date">8 sep 2015</small>
                    </li>

                    <li class="tweet">
                        <p class="text-alt tweet-text">We didn't set out to be superheroes. But sometimes, life doesn't
                            go the way you planned. <a href="#">#TI5</a> <a href="#">#BleedBlue</a></p>
                        <small class="tweet-date">9 sep 2015</small>
                    </li>
                </ul>
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
