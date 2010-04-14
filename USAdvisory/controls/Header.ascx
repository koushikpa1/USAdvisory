<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="controls_Header" %>
<%@ Register Src="LoginControl.ascx" TagName="Login" TagPrefix="Login_uc" %>
<!--..................top-block....................-->
<script type="text/javascript">

</script>

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
		   <li><a href="Index.aspx" id="current">Home</a></li>
		   <li class="blueline"></li>
		    <li><a href="MemberZone.aspx" id="MemberZone" onclick="showSubMenu('MemberZone');">Member Zone</a></li>
			<li class="blueline"></li>
			 <li><a href="MyAccount.aspx" id="MyAccount">My Account</a></li>
			 <li class="blueline"></li>
			  <li><a href="Subscriptions.aspx" id="Services">Services &amp; Subscription</a></li>
			  <li class="blueline"></li>
			   <li><a href="Performance.aspx" id="Performance">Performance</a></li>
			   <li class="blueline"></li>
				 <li><a href="ContactUs.aspx" id="ContactUs">Contact Us</a></li>
				 <li class="blueline"></li>
		   </ul>
		  </div>
		  
		</div>
	  </div>
	  <div style="display:none;" id="subMenuDiv">
	      <div class="menubar" >
		  <div class="menu-content">
		   <ul>
		    <li><a href="DayTradingSwingTrading.aspx">Day &amp; Swing Trading</a></li>
			 <li><a href="ValueInvesting.aspx">Value Investing</a></li>
			  <li><a href="VirtualPortfolio.aspx"> Virtual Portfolio</a></li>
			   <li><a href="PennyStocks.aspx">Penny Stocks</a></li>
				 <li><a href="QueryCorner.aspx">Query Corner</a></li>
		   </ul>
	    </div>
	    </div>
	    </div>
	  
	  <div class="icons-div">
	   <div class="icons-1"><a href="http://www.facebook.com/group.php?gid=2344172758" target="_blank"><img src="images/icon-facebook.jpg" alt="Face Book" border="0" /></a></div>
	   <div class="icons-2"><a href="http://twitter.com/" target="_blank"><img src="images/icon-twitter.jpg" alt="Twitter" border="0" /></a></div>
	  </div>

</div>
  
  
<!--..................top-block....................-->