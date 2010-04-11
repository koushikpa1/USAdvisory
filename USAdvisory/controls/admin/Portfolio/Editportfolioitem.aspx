
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Editportfolioitem.aspx.cs" Inherits="admin_Portfolio_Editportfolioitem" %>
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
     <tr><td align="center" class="header" colspan=2>Portfolio Details </td></tr>
    <tr>
    
   
	<!--[if !IE]> main content <![endif]-->
	<div id="maincontent1" >
<div class="contentheader clearfix" >
<TABLE align="center" style="BORDER-RIGHT: #b6c0d6 1px solid; BORDER-TOP: #b6c0d6 1px solid; BORDER-LEFT: 
#b6c0d6 1px solid; BORDER-BOTTOM: #b6c0d6 1px solid; width: 918px;"><TBODY>
<tr><td align="center" colspan="2" class="header" style="height: 13px">
<h4>Edit stock to portfolio </h4></td></tr>
<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Id :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="PortfolioId" value = "1" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="PortfolioId"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Company Name:</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="CompanyName" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="CompanyName"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
            
             <TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Ticker :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtTicker" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTicker"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Ticker :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtBuyOrSellId" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtBuyOrSellId"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
            
            			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Quantity:</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtQty" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator40" runat="server" ControlToValidate="txtQty"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Entry Price :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtEntryPrice" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEntryPrice"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Exit Price :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtExitPrice" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtExitPrice"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Exit Price :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtStopLoss" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtStopLoss"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Entry Date :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtEntryDate" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="txtEntryDate"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
	<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Portfolio Exit Date :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtExitDate" runat="Server" Width="358px"></asp:TextBox>
	
     <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtExitDate"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
	<TR><TD align=right  class="content" style="height: 13px;" >
	
    &nbsp;Portfolio Call Status :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtCallStatus" value ="O" runat="Server" Width="358px"></asp:TextBox>
	
     <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtCallStatus"
            ErrorMessage="Required."></asp:RequiredFieldValidator>O for Open and C for Closed</TD></TR>
			
			  	<TR><TD align=right  class="content" style="height: 13px;" >
	
    &nbsp;Portfolio Buy or Short Sell :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtBuyOrSell" value ="1" runat="Server" Width="358px"></asp:TextBox>
	
     <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="txtBuyOrSell"
            ErrorMessage="Required."></asp:RequiredFieldValidator> 1 for Buy and 2 for ShortSell</TD></TR>
            
<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;IsPartiallyExited :</TD><TD align=left  class="content" style="height: 13px">
    
    <asp:CheckBox id="isPartiallyExited"
                    AutoPostBack="false"
                    TextAlign="Right"  runat="server"/></TD></TR>
            
                    
<TR><TD align=right  class="content" style="height: 13px;">
   Stock Portfolio Updates : </TD></TR>
    <tr><td colspan="2" align="center"  class="content">
	
	
    <FCKeditorV2:FCKeditor id="fckcontent" BasePath="~/FCKeditor/" Width="900px" runat="server" value='This is some <strong>sample text</strong>.
	You are using <a href="http://www.fckeditor.net/">FCKeditor</a>.'></FCKeditorV2:FCKeditor></td></tr>
	
<TR><TD align=center colSpan=2  class="content">
    <asp:Button ID="btnsave" runat="server" Text="Add" Width="76px" OnClick="btnsave_Click" /></TD></TR>
</TBODY></TABLE>
	</div>
</form>
</html>
