@include('layouts.welcome-page-header')
<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- CSRF Token -->
    <meta name="csrf-token" content="{{ csrf_token() }}">

    <title>HighLands Halloween Festival</title>

    <!-- Scripts -->
    <script src="{{ asset('js/app.js') }}" defer></script>

    <!-- Fonts -->
    <link rel="dns-prefetch" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css?family=Nunito" rel="stylesheet" type="text/css">

    <!-- Styles -->
    <link href="{{ asset('css/app.css') }}" rel="stylesheet">
</head>
<body>
    <div id="app">
            <div class="container">
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <!-- Right Side Of Navbar -->
                    <ul class="navbar-nav ml-auto">
                        <!-- Authentication Links -->
                        @guest
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
                        @else
                            <li class="nav-item dropdown">
                                <a id="navbarDropdown" class="nav-link dropdown-toggle" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" v-pre>
                                    {{ Auth::user()->name }} <span class="caret"></span>
                                </a>

                                <div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdown">
                                    <a class="dropdown-item" href="{{ route('logout') }}"
                                       onclick="event.preventDefault();
                                                     document.getElementById('logout-form').submit();">
                                        {{ __('Logout') }}
                                    </a>

                                    <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
                                        @csrf
                                    </form>
                                </div>
                            </li>
                        @endguest
                    </ul>
                </div>
            </div>
        <main class="py-4">
            @yield('content')
        </main>
    </div>


    
    @include('layouts.welcome-page-footer')
</body>
</html>
