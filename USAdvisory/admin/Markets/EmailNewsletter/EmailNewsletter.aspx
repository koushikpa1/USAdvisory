<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmailNewsletter.aspx.cs" Inherits="admin_Markets_EmailNewsletter_EmailNewsletter" %>

<head>

    <script type="text/javascript" src="../../../js/DMenus.js">
    </script>
    
       <link rel="stylesheet" type="text/css" href="../../../css/DMenus.css" />
</head>
 <form id="Form2" runat="server">
    
    <div id="glowmenu" class="glowingtabs">
<!--<ul>
<li><a href="home.aspx" title="Home"><span>Home</span></a></li>-->
<li><a href="" title="CSS Library" rel="dropmenu1_d"><span>Markets</span></a></li>
<li><a href="" title="CSS Library" rel="dropmenu2_d"><span>Recommendations</span></a></li>
<li><a href="" title="CSS Library" rel="dropmenu3_d"><span>Portfolio</span></a></li>
<li><a href="" title="Partners" rel="dropmenu4_d"><span>User Management</span></a></li>
<!--<li><a href="" title="Webmaster Tools"><span>Tools</span></a></li>-->
</ul>
</div>
<br style="clear: left;" />
<br class="IEonlybr" />

<!--1st drop down menu -->                                                   
<div id="dropmenu1_d" class="dropmenudiv_d">
<a href="../Commentary/CommListing.aspx">Commentary</a>
<a href="../NewsViews/NewsViewsListing.aspx">News & Views</a>
<a href="../EmailNewsletter/EmailNewsletter.aspx">Email Newsletter</a>
<a href="../WatchOut/WatchOutListing.aspx">Watch Out !!!</a>
</div>


<!--2nd drop down menu -->                                                
<div id="dropmenu2_d" class="dropmenudiv_d" style="width: 150px;">
<a href="../Recommendations/DayTradeListing.aspx">Day Trade</a>
<a href="../Recommendations/SwingTradeListing.aspx">Swing Trade</a>
<a href="../Recommendations/ValueInvestingListing.aspx">Value Investing</a>
</div>

<!--3rd drop down menu -->                                                
<div id="dropmenu3_d" class="dropmenudiv_d" style="width: 150px;">
<a href="../Portfolio/PortfolioListing.aspx">View Portfolio</a>
<a href="../Portfolio/PortfolioAdd.aspx">Add Portfolio</a>
</div>

<!--4th drop down menu -->                                                
<div id="dropmenu4_d" class="dropmenudiv_d" style="width: 150px;">
<a href="../Users/UserListing.aspx">View Users</a>
<a href="../Orders/UserListing.aspx">View Orders</a>
</div>



<script type="text/javascript">
    //SYNTAX: tabdropdown.init("menu_id", [integer OR "auto"])
    tabdropdown.init("glowmenu", "auto")
</script>


	<!--[if !IE]> main content <![endif]-->
	<div id="maincontent1" >
<div class="contentheader clearfix" >
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <H1 align="center">Get All Email Address</H1>
      <asp:Label ID="idEmail" runat="server">
    </asp:Label>
    
	</div>
</form>
    