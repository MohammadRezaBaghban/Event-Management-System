<?php echo $__env->make('layouts.welcome-page-header', \Illuminate\Support\Arr::except(get_defined_vars(), array('__data', '__path')))->render(); ?>
<!DOCTYPE html>
<html lang="<?php echo e(str_replace('_', '-', app()->getLocale())); ?>">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- CSRF Token -->
    <meta name="csrf-token" content="<?php echo e(csrf_token()); ?>">

    <title>HighLands Halloween Festival</title>

    <!-- Scripts -->
    <script src="<?php echo e(asset('js/app.js')); ?>" defer></script>

    <!-- Fonts -->
    <link rel="dns-prefetch" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css?family=Nunito" rel="stylesheet" type="text/css">

    <!-- Styles -->
    <link href="<?php echo e(asset('css/app.css')); ?>" rel="stylesheet">
</head>
<body>
    <div id="app">
            <div class="container">
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <!-- Right Side Of Navbar -->
                    <ul class="navbar-nav ml-auto">
                        <!-- Authentication Links -->
                        <?php if(auth()->guard()->guest()): ?>
                            <header class="header header-black fixed" style="min-height: 100px;">
                                <div class="header-wrapper fixed">
                                    <div class="container">
                                        <div class="col-sm-2 col-xs-12 navigation-header">
                                            <a href="#" class="logo">
                                                <img src="assets/img/logo-.png" href="/" width="110" height="90" class="retina-show"
                                                   style="margin-top: -30px;">
                                            </a>
                                            <button class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navigation" aria-expanded="false" aria-controls="navigation">
                                                <span class="icon-bar"></span>
                                                <span class="icon-bar"></span>
                                                <span class="icon-bar"></span>
                                            </button>
                                        </div>

                                        <div class="col-sm-10 col-xs-12 navigation-container">
                                            <div id="navigation" class="navbar-collapse collapse">
                                                <ul class="navigation-list pull-left light-text">
                                                    <li class="navigation-item"><a href="/" class="navigation-link">Home</a></li>
                                                    <li class="navigation-item"><a href="/#about" class="navigation-link">About Us</a></li>
                                                    <li class="navigation-item"><a href="/#activities" class="navigation-link">Activities</a></li>
                                                    <li class="navigation-item"><a href="/#tickets" class="navigation-link">Tickets</a></li>
                                                    <li class="navigation-item"><a href="/schedule" class="navigation-link">Schedule</a></li>
                                                    <li class="navigation-item"><a href="#" class="navigation-link" data-toggle="modal" data-target="#email-ticket"
                                                        >Contact Us</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </header>
                        <?php else: ?>
                            <li class="nav-item dropdown">
                                <a id="navbarDropdown" class="nav-link dropdown-toggle" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" v-pre>
                                    <?php echo e(Auth::user()->name); ?> <span class="caret"></span>
                                </a>

                                <div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdown">
                                    <a class="dropdown-item" href="<?php echo e(route('logout')); ?>"
                                       onclick="event.preventDefault();
                                                     document.getElementById('logout-form').submit();">
                                        <?php echo e(__('Logout')); ?>

                                    </a>

                                    <form id="logout-form" action="<?php echo e(route('logout')); ?>" method="POST" style="display: none;">
                                        <?php echo csrf_field(); ?>
                                    </form>
                                </div>
                            </li>
                        <?php endif; ?>
                    </ul>
                </div>
            </div>
        <main class="py-4">
            <?php echo $__env->yieldContent('content'); ?>
        </main>
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
    <?php echo $__env->make('layouts.welcome-page-footer', \Illuminate\Support\Arr::except(get_defined_vars(), array('__data', '__path')))->render(); ?>
</body>
</html>
