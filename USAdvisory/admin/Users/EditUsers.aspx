<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditUsers.aspx.cs" Inherits="admin_Users_EditUsers" %>
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
<h4>Edit/Update User </h4></td></tr>
<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;UserId :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtUserId" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserId"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Password:</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtPassword" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtPassword"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
            
             <TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;First Name :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtFirstName" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFirstName"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
		
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Last Name:</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtLastName" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator40" runat="server" ControlToValidate="txtLastName"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Phone Number :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtPhoneNumber" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPhoneNumber"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Address :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtAddress" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAddress"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;State :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtState" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtState"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
			<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Country :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtCountry" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCountry"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
			
	<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Zip Code :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtZipCode" runat="Server" Width="358px"></asp:TextBox>
	</TD></TR>
	<TR><TD align=right  class="content" style="height: 13px;" >
	
    &nbsp;Registration Date:</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtRegistrationDate" runat="Server" Width="358px"></asp:TextBox>
	
     <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtRegistrationDate"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
            
     <TR><TD align=right  class="content" style="height: 13px;" >
	
    &nbsp;Subscription Start Date:</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtSubscriptionDate" value ="O" runat="Server" Width="358px"></asp:TextBox>
	
     <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="txtSubscriptionDate"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
            
            
     <TR><TD align=right  class="content" style="height: 13px;" >
	
    &nbsp;Subscription End Date:</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtSubscriptionEndDate" value ="O" runat="Server" Width="358px"></asp:TextBox>
	
     <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="txtSubscriptionEndDate"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
            
            	
			
            
<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;IsPaidSubscriber :</TD><TD align=left  class="content" style="height: 13px">
    
    <asp:CheckBox id="IsPaidSubscriber"
                    AutoPostBack="false"
                    TextAlign="Right"  runat="server"/> [1 for Paid and 0 for unpaid]</TD></TR>
                    
                    <TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;IsAutoRenewal :</TD><TD align=left  class="content" style="height: 13px">
   
    <asp:CheckBox id="IsAutoRenewal"
                    AutoPostBack="false"
                    TextAlign="Right"  runat="server"/> [1 for AutoRenewal and 0 for non Auto Renewal]</TD></TR>
            
            

	
<TR><TD align=center colSpan=2  class="content">
    <asp:Button ID="btnsave" runat="server" Text="Add" Width="76px" OnClick="btnsave_Click" /></TD></TR>
</TBODY></TABLE>
	</div>
</form>
</html>
