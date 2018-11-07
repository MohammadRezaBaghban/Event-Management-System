<?php echo $__env->make('layouts.welcome-page-header', \Illuminate\Support\Arr::except(get_defined_vars(), array('__data', '__path')))->render(); ?>
<link rel="stylesheet" type="text/css" href="assets/css/timeline.css" />

<div class="container">
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
                        <li class="navigation-item"><a href="/login" class="navigation-link">Login</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
  </header>
  
  <ul class="timeline">
    <li><div class="tldate">Apr 2014</div></li>
    
    <li>
      <div class="tl-circ"></div>
      <div class="timeline-panel">
        <div class="tl-heading">
          <h4>Lorem Ipsum</h4>
          <p><small class="text-muted"><i class="glyphicon glyphicon-time"></i> 3 hours ago</small></p>
        </div>
        <div class="tl-body">
          <p>Lorem Ipsum and such.</p>
        </div>
      </div>
    </li>
    
    <li class="timeline-inverted">
      <div class="tl-circ"></div>
      <div class="timeline-panel">
        <div class="tl-heading">
          <h4>Lorem Ipsum</h4>
          <p><small class="text-muted"><i class="glyphicon glyphicon-time"></i> 4/07/2014</small></p>
        </div>
        <div class="tl-body">
          <p>Lorem Ipsum</p>
            
          <p>Lorem Ipsum nonirnw inouwed.  inwendiuqnwenfr iuwrdf</p>
        </div>
      </div>
    </li>
    
    <li><div class="tldate">Mar 2014</div></li>
    
    <li>
      <div class="tl-circ"></div>
      <div class="timeline-panel">
        <div class="tl-heading">
          <h4>Lorem Ipsum</h4>
          <p><small class="text-muted"><i class="glyphicon glyphicon-time"></i> 3/22/2014</small></p>
        </div>
        <div class="tl-body">
          <p>Lorem Ipsum.</p>
        </div>
      </div>
    </li>
    <li class="timeline-inverted">
      <div class="timeline-panel">
        <div class="tl-heading">
          <h4>Lorem Ipsum</h4>
          <p><small class="text-muted"><i class="glyphicon glyphicon-time"></i> 3/16/2014</small></p>
        </div>
        <div class="tl-body">
          <p>iqbenr clakjnsr cqbeorcpaisb`dnfpq iurc2bvepjsda picwu prqfvFQWQERFQRFQWRFQWRFWQFWQRF<</p>
        
        </div>
      </div>
    </li>
  </ul>


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