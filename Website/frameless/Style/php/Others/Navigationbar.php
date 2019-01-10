<?php if (isset($login)): ?>
    <header class="header header-black fixed" style="min-height: 100px;">
    <div class="header-wrapper fixed">
        <div class="container">
            <div class="col-sm-2 col-xs-12 navigation-header"><a href="#" class="logo"><img src="../Images/logo-.png"
                                                                                            href="/" width="110"
                                                                                            height="90"
                                                                                            class="retina-show"
                                                                                            style="margin-top: -30px;"></a>
                <button class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navigation"
                        aria-expanded="false" aria-controls="navigation"><span class="icon-bar"></span><span
                            class="icon-bar"></span><span class="icon-bar"></span></button>
            </div><?php if (isset($login) && $login == 1): ?>
                <div class="col-sm-10 col-xs-12 navigation-container">
                    <div id="navigation" class="navbar-collapse collapse">
                        <ul class="navigation-list pull-left light-text">
                            <li class="navigation-item"><a href="?page=home" class="navigation-link">Home</a></li>
                            <li class="navigation-item"><a href="?page=home#about" class="navigation-link">About Us</a>
                            </li>
                            <li class="navigation-item"><a href="?page=home#activities" class="navigation-link">Activities</a>
                            </li>
                            <li class="navigation-item"><a href="?page=home#tickets" class="navigation-link">Tickets</a>
                            </li>
                            <li class="navigation-item"><a href="?page=schedule" class="navigation-link">Schedule</a>
                            </li>
                            <li class="navigation-item"><a href="#" class="navigation-link" data-toggle="modal"
                                                           data-target="#email-ticket">Contact Us</a></li>
                            <li class="navigation-item"><a href="?page=dashboard">Profile</a></li>
                            <li class="navigation-item"><a href="?page=logout">Log out</a></li>
                        </ul>
                    </div>
                </div><?php endif; ?><?php if (isset($login) && $login == 0): ?>
                <div class="col-sm-10 col-xs-12 navigation-container">
                    <div id="navigation" class="navbar-collapse collapse">
                        <ul class="navigation-list pull-left light-text">
                            <li class="navigation-item"><a href="?page=home" class="navigation-link">Home</a></li>
                            <li class="navigation-item"><a href="?page=home#about" class="navigation-link">About Us</a>
                            </li>
                            <li class="navigation-item"><a href="?page=home#activities" class="navigation-link">Activities</a>
                            </li>
                            <li class="navigation-item"><a href="?page=home#tickets" class="navigation-link">Tickets</a>
                            </li>
                            <li class="navigation-item"><a href="?page=schedule" class="navigation-link">Schedule</a>
                            </li>
                            <li class="navigation-item"><a href="#" class="navigation-link" data-toggle="modal"
                                                           data-target="#email-ticket">Contact Us</a></li>
                            <li class="navigation-item"><a href="?page=login" class="navigation-link">Login </a></li>
                        </ul>
                    </div>
                </div><?php endif; ?></div>
    </div></header><?php endif; ?>