<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" ValidateRequest ="false"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
 <meta charset="utf-8">
     <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="Udema a modern educational site template">
    <meta name="author" content="Ansonika">
    <title>CourseWare Learning for Cognitive Learning</title>

    <!-- Favicons-->
    <link rel="shortcut icon" href="img/favicon.ico" type="image/x-icon">
    <link rel="apple-touch-icon" type="image/x-icon" href="img/apple-touch-icon-57x57-precomposed.png">
    <link rel="apple-touch-icon" type="image/x-icon" sizes="72x72" href="img/apple-touch-icon-72x72-precomposed.png">
    <link rel="apple-touch-icon" type="image/x-icon" sizes="114x114" href="img/apple-touch-icon-114x114-precomposed.png">
    <link rel="apple-touch-icon" type="image/x-icon" sizes="144x144" href="img/apple-touch-icon-144x144-precomposed.png">

    <!-- BASE CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
	<link href="css/vendors.css" rel="stylesheet">
	<link href="css/icon_fonts/css/all_icons.min.css" rel="stylesheet">

    <!-- YOUR CUSTOM CSS -->
    <link href="css/custom.css" rel="stylesheet">
	
	<!-- Modernizr -->
	<script src="js/modernizr.js"></script>
</head>
<body>
      <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<div id="preloader">
		<div data-loader="circle-side"></div>
	</div>
	<!-- End Preload -->
	
	<header class="header fadeInDown">
		<div id="logo">
			<a href="index"><img src="" width="149" height="42" data-retina="true" alt=""></a>
		</div>
		<ul id="top_menu">
			<li class="hidden_tablet"><a href="Signin" class=" rounded btn-success btn ">Sign in</a></li>
			<li class="hidden_tablet"><a href="Register" class="btn_1 rounded">Register</a></li>
			<li>
				<div class="hamburger hamburger--spin">
					<div class="hamburger-box">
						<div class="hamburger-inner"></div>
					</div>
				</div>
			</li>
		</ul>
		<!-- /top_menu -->
	</header>
	<!-- /header -->
	
	<%--<div id="main_menu">
		<div class="container">
		<nav class="version_2">
				<div class="row">
					<div class="col-md-3">
						<h3>Home</h3>
						<ul>
							<li><a href="index.html">Home version 1</a></li>
							<li><a href="index-2.html">Home version 2</a></li>
							<li><a href="index-3.html">Home version 3</a></li>
							<li><a href="index-4.html">Home version 4</a></li>
							<li><a href="index-5.html">With Cookie bar (EU law)</a></li>
						</ul>
					</div>
					<div class="col-md-3">
						<h3>Courses</h3>
						<ul>
							<li><a href="courses-grid.html">Courses grid</a></li>
							<li><a href="courses-grid-sidebar.html">Courses grid sidebar</a></li>
							<li><a href="courses-list.html">Courses list</a></li>
							<li><a href="courses-list-sidebar.html">Courses list sidebar</a></li>
							<li><a href="course-detail.html">Course detail</a></li>
							<li><a href="course-detail-2.html">Course detail (working form)</a></li>
							<li><a href="admission.html">Admission wizard</a></li>
							<li><a href="teacher-detail.html">Teacher detail</a></li>
						</ul>
					</div>
					<div class="col-md-3">
						<h3>Pages</h3>
						<ul>
							<li><a href="#0">Menu 1</a><span class="badge_info">New</span></li>
							<li><a href="about.html">About</a></li>
							<li><a href="blog.html">Blog</a></li>
							<li><a href="login.html">Login</a></li>
							<li><a href="register.html">Register</a></li>
							<li><a href="contacts.html">Contacts</a></li>
							<li><a href="404.html">404 page</a></li>
							<li><a href="agenda-calendar.html">Agenda Calendar</a></li>
							<li><a href="faq.html">Faq</a></li>
							<li><a href="help.html">Help</a></li>
						</ul>
					</div>
					<div class="col-md-3">
						<h3>Extra pages</h3>
						<ul>
							<li><a href="media-gallery.html">Media gallery</a></li>
							<li><a href="cart-1.html">Cart page 1</a></li>
							<li><a href="cart-2.html">Cart page 2</a></li>
							<li><a href="cart-3.html">Cart page 3</a></li>
							<li><a href="pricing-tables.html">Responsive pricing tables</a></li>
							<li><a href="coming_soon/index.html">Coming soon</a></li>
							<li><a href="icon-pack-1.html">Icon pack 1</a></li>
							<li><a href="icon-pack-2.html">Icon pack 2</a></li>
							<li><a href="icon-pack-3.html">Icon pack 3</a></li>
							<li><a href="icon-pack-4.html">Icon pack 4</a></li>
						</ul>
					</div>
				</div>
				<!-- /row -->
			</nav>
			<div class="follow_us">
				<ul>
					<li>Follow us</li>
					<li><a href="#0"><i class="ti-facebook"></i></a></li>
					<li><a href="#0"><i class="ti-twitter-alt"></i></a></li>
					<li><a href="#0"><i class="ti-google"></i></a></li>
					<li><a href="#0"><i class="ti-pinterest"></i></a></li>
					<li><a href="#0"><i class="ti-instagram"></i></a></li>
				</ul>
			</div>
		</div>
	</div>--%>
	<!-- /main_menu -->
	
	<main>
		<section class="header-video">
			<div id="hero_video">
				<div>
					<h3><strong>English</strong><br>Courseware</h3>
					<p>This is English Courseware specially <strong>made for  &nbsp</strong>cognitive students.</p>
				</div>
				<a href="#first_section" class="btn_explore hidden_tablet"><i class="ti-arrow-down"></i></a>
			</div>
			<img src="img/video_fix.png" alt="" class="header-video--media" data-video-src="video" data-teaser-source="video" data-provider="" data-video-width="1920" data-video-height="960">
		</section>
		<!-- /header-video -->

		<!--/grid_home -->

	
		<!--/call_section-->
	</main>
	<!-- /main -->
	
	<footer>
		<div class="container margin_120_95">
			
			
			<div class="row">
				<div class="col-md-8">
					<ul id="additional_links">
						<li><a href="#0">Terms and conditions</a></li>
						<li><a href="#0">Privacy</a></li>
					</ul>
				</div>
				<div class="col-md-4">
					<div id="copy">© <%=DateTime .UtcNow .Year  %> English Courseware</div>
				</div>
			</div>
		</div>
	</footer>
	<!--/footer-->
	
	<!-- Search Menu -->
	
	<!-- COMMON SCRIPTS -->
    <script src="js/jquery-2.2.4.min.js"></script>
    <script src="js/common_scripts.js"></script>
    <script src="js/main.js"></script>
	<script src="assets/validate.js"></script>
	
	<!-- SPECIFIC SCRIPTS -->
	<script src="js/video_header.js"></script>
	<script>
		HeaderVideo.init({
			container: $('.header-video'),
			header: $('.header-video--media'),
			videoTrigger: $("#video-trigger"),
			autoPlayVideo: true
		});
	</script>
        





    </form>
</body>
</html>
