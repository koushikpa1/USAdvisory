<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HeaderInnerPage.ascx.cs" Inherits="controls_HeaderInnerPage" %>
<%@ Register Src="LoginControl.ascx" TagName="Login" TagPrefix="Login_uc" %>

<!--..................top-block....................-->
<div class="top-block">
    <div class="upper-header">
	   <div class="upper-header-left">
	      <div class="logo"><a href="#"><img src="images/logo.jpg" alt="Company Name" border="0" /></a></div>
      </div>
	         <div class="upper-header-middle">
			    <div class="upper-header-add"><img src="images/upper-header-add.jpg" alt="add" /></div>
			    </div>
	              <div class="upper-header-right">
				    <Login_uc:Login ID="login" runat="server" /> 
				   </div>
	</div>
	
	  <div class="navigation-block">
	    <div id="menubar">
		  <div id="menu-content">
		   <ul>
		   <li class="blueline"></li>
		   <li><a href="index.html">Home</a></li>
		   <li class="blueline"></li>
		    <li><a href="member-zone.html">Member Zone</a></li>
			<li class="blueline"></li>
			 <li><a href="my-acount.html">My Account</a></li>
			 <li class="blueline"></li>
			  <li><a href="services-subscription.html">Services &amp; Subscription</a></li>
			  <li class="blueline"></li>
			   <li><a href="performance.html">Performance</a></li>
			   <li class="blueline"></li>
				 <li><a href="contact-us.html">Contact Us</a></li>
				 <li class="blueline"></li>
		   </ul>
		  </div>
		</div>
 
	  </div>
	  <div class="headline-news-box"><div class="news-headlines"></div></div>
	  <div class="icons-div">
	   <div class="icons-1"><a href="http://www.facebook.com/" target="_blank"><img src="images/icon-facebook.jpg" alt="Face Book" border="0" /></a></div>
	   <div class="icons-2"><a href="http://twitter.com/" target="_blank"><img src="images/icon-twitter.jpg" alt="Twitter" border="0" /></a></div>
	  </div>
  </div>
<!--..................top-block....................-->

