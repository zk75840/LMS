<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <title></title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width">
       
        <link rel="stylesheet" href="css/bootstrap.css">
        <link rel="stylesheet" href="css/bootstrap-responsive.css">
        <link rel="stylesheet" href="css/custom-styles.css">
        <link rel="stylesheet" href="css/font-awesome.css">
        <link rel="stylesheet" href="css/component.css">
        <link rel="stylesheet" href="css/font-awesome-ie7.css">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

        <style>
        ul.topnav {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    background-color: #333;
}

/* Float the list items side by side */
ul.topnav li {float: left;}

/* Style the links inside the list items */
ul.topnav li a {
    display: inline-block;
    color: #f2f2f2;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
    transition: 0.3s;
    font-size: 17px;
}

/* Change background color of links on hover */
ul.topnav li a:hover {background-color: #555;}

/* Hide the list item that contains the link that should open and close the topnav on small screens */
ul.topnav li.icon {display: none;}



@media screen and (max-width:680px) {
  ul.topnav li:not(:first-child) {display: none;}
  ul.topnav li.icon {
    float: right;
    display: inline-block;
  }
}

/* The "responsive" class is added to the topnav with JavaScript when the user clicks on the icon. This class makes the topnav look good on small screens */
@media screen and (max-width:680px) {
  ul.topnav.responsive {position: relative;}
  ul.topnav.responsive li.icon {
    position: absolute;
    right: 0;
    top: 0;
  }
  ul.topnav.responsive li {
    float: none;
    display: inline;
  }
  ul.topnav.responsive li a {
    display: block;
    text-align: left;
  }
}


    </style>
        <script>

                function myFunction() {
                    var x = document.getElementById("myTopnav");
                    if (x.className === "topnav") {
                        x.className += " responsive";
                    } else {
                        x.className = "topnav";
                    }
                }

        </script>


       
        <script src="js/modernizr.custom.js"</script>
        <script src="js/modernizr-2.6.2-respond-1.1.0.min.js"></script>
    </head>
     <body style="background-image: url('img/images.png'); " >
          <form id="form1" runat="server">
        <!--[if lt IE 7]>
            <p class="chromeframe">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> or <a href="http://www.google.com/chromeframe/?redirect=true">activate Google Chrome Frame</a> to improve your experience.</p>
        <![endif]-->

        <!-- This code is taken from http://twitter.github.com/bootstrap/examples/hero.html -->
         <div style="background-image: url('img/images.png'); " class="header-wrapper">
                <div class="container">
                    <div class="row-fluid">

                        <div class="site-name">

                            <img src="img/OpenLibraryLogo.png" /> <h1 style="color:#1492c2;">LIBRARY MANAGEMENT SYSTEM</h1>
                        </div>


                        <div class="menu-icons">
                            <ul>
                              <li><a href="https://www.facebook.com/ANUM-Diagnostic-Elevators-204960246306060/"> <i class="fa fa-facebook-official" style="font-size:38px;color:#3f7ac2"></i></a></li>
                              <br /> <li><a href="http://mail.anumelevators.com"><i class="fa fa-envelope-open" style="font-size:36px"></i></a></li>
</li>


</ul>
                        </div>


                    </div>
                </div>
            </div>
        <div   class="container">
            <div style="background-image: url('img/amazing-blue-art-background-hd.jpg');"  class="menu">

                        <div class="navbar">
                            <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
                                <i class="fw-icon-th-list"></i>
                            </a>
                            <div class="nav-collapse collapse">
                                <ul class="nav">
                                    <li class="active"><a href="index.html">Home</a></li>
                                    <li><a href="#">Add Books</a></li>
                                    <li><a href="#">Issue Book Records</a></li>
                                    <li><a href="#">Return Book Records</a></li>
                                    <li><a href="#">About</a></li>
                                    <li><a href="#">Contact Us</a></li>
                                    <li><a href="Login.aspx">Login</a></li>
                                </ul>
                            </div><!--/.nav-collapse -->
                        </div>
						<div class="mini-menu">

                            <div class="inner">
                                <ul class="topnav" id="myTopnav">
                                    <li><a href="index.html">Home</a></li>
                                    <li><a href="#">Add Books</a></li>
                                    <li><a href="#">Issue Book Records</a></li>
                                    <li><a href="#">Return Book Records</a></li>
                                    <li><a href="#">About Us</a></li>
                                    <li><a href="#">Contact Us</a></li>
                                    <li><a href="Login.aspx">Login</a></li>
                                 

                                    <li class="icon">
                                        <a href="javascript:void(0);" onclick="myFunction()">&#9776;</a>
                                    </li>
                                </ul>
                            </div>

            </div>
            </div>

              <div style="background-image: url('img/shrt.jpg');" class="container bg-white">
                <div class="row-fluid">

                           <div class="featured-images">
                            <ul class="grid effect-8" id="grid">
                              <li>
                                <div class="block">

                                        <h4>REGISTRATION FORM</h4>
                                    <br /><br />
                                    <asp:Label ID="Label1" runat="server" Text="First Name" ForeColor="Black"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="Textfname" runat="server"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="Label2" runat="server" Text="Last Name" ForeColor="Black"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="Textlname" runat="server"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="Label3" runat="server" Text="Username" ForeColor="Black"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="Textuname" runat="server"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="Label4" runat="server" Text="Password" ForeColor="Black"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="Textpass" runat="server" type="password"></asp:TextBox>
                                    <br />
                                 
                                    <asp:Label ID="Label5" runat="server" Text="Email" ForeColor="Black"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="Textemail" runat="server" type="email"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="Label6" runat="server" Text="Address" ForeColor="Black"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="Textadres" runat="server"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="Label7" runat="server" Text="City" ForeColor="Black"></asp:Label>
                                    <br />
                                     <asp:TextBox ID="Textcity" runat="server"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="Label8" runat="server" Text="Country" ForeColor="Black"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="Textcountry" runat="server"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="Label9" runat="server" Text="Contact" ForeColor="Black"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="Textcontact" runat="server"></asp:TextBox>
                                   <br /><br />
                                        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Reg" />
                                </div>
                              </li>
                            </ul>

     <div style="background-image: url('img/amazing-blue-art-background-hd.jpg');" class="wrap bg-black">
                      <div class="container ">
                        <div class="row-fluid">
                          <div class="span12">
                            <div class="copy-rights">
                            Copyright(c) Asad Technology. <span>Designed by: <a href="http://www.asadtechworld.com">www.asadtechworld.com</a></span></a>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>

       <script src="js/jquery-1.9.1.js"></script>
<script src="js/bootstrap.js"></script>
<script src="js/masonry.pkgd.min.js"></script>
    <script src="js/imagesloaded.js"></script>
    <script src="js/classie.js"></script>
    <script src="js/AnimOnScroll.js"></script>

    <script>
        new AnimOnScroll(document.getElementById('grid'), {
            minDuration: 0.4,
            maxDuration: 0.7,
            viewportFactor: 0.2
        });
    </script>
<script>
      $('#myCarousel').carousel({
          interval: 1800
      });
</script>
    
                               </form>
         </body>

</html>
