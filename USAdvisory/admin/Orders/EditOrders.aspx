<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditOrders.aspx.cs" Inherits="admin_Orders_EditOrders" %>

<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>

<head>

    <script type="text/javascript" src="../../js/DMenus.js">
    </script>
    
       <link rel="stylesheet" type="text/css" href="../../css/DMenus.css" />
</head>
 <form id="Form1" runat="server">
    
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
<a href="../../PremiumServices/DayTrading/DayTradingListing.aspx">Day Trade</a>
<a href="../../PremiumServices/SwingTrading/SwingTradingListing.aspx">Swing Trade</a>
<a href="../../PremiumServices/ValueInvesting/ValueInvestingListing.aspx">Value Investing</a>
<a href="../../PremiumServices/PennyStocks/PennyStockListing.aspx">Penny Stocks</a>
</div>

<!--3rd drop down menu -->                                                
<div id="dropmenu3_d" class="dropmenudiv_d" style="width: 150px;">
<a href="../../Portfolio/PortfolioListing.aspx">View Portfolio</a>
<a href="../../Portfolio/PortfolioAdd.aspx">Add Portfolio</a>
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

     <table  width="99%">
     <tr><td align="center" class="header" colspan=2>User Management</td></tr>
    <tr>
    
   
	<!--[if !IE]> main content <![endif]-->
	<div id="maincontent1" >
<div class="contentheader clearfix" >
<TABLE align="center" style="BORDER-RIGHT: #b6c0d6 1px solid; BORDER-TOP: #b6c0d6 1px solid; BORDER-LEFT: 
#b6c0d6 1px solid; BORDER-BOTTOM: #b6c0d6 1px solid; width: 918px;"><TBODY>
<tr><td align="center" colspan="2" class="header" style="height: 13px">
<h4>Edit/Update Order </h4></td></tr>
<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;UserId :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtUserId" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserId"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
             <TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;UniqueOrderId :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtUniqueOrderId" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUniqueOrderId"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
		
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;MonthsOfSubscription (1 or 3 or 6 or 12):</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtMonthsOfSubscription" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator40" runat="server" ControlToValidate="txtMonthsOfSubscription"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;PaymentDate :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtPaymentDate" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPaymentDate"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;VendorReferenceId :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtVendorReferenceId" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtVendorReferenceId"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;SubscriptionStartDate :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtSubscriptionStartDate" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtSubscriptionStartDate"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;SubscriptionEndDate :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtSubscriptionEndDate" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtSubscriptionEndDate"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
	
<TR><TD align=center colSpan=2  class="content">
    <asp:Button ID="btnsave" runat="server" Text="Add" Width="76px" OnClick="btnsave_Click" /></TD></TR>
</TBODY></TABLE>
	</div>
</form>
</html>
