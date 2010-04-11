<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditSendEmail.aspx.cs" Inherits="admin_Email_EditSendEmail" %>
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
<a href="NewsViews/NewsViews.aspx">News & Views</a>
<a href="EmailNewsletter/EmailNewsletterListing.aspx">Email Newsletter</a>
<a href="WatchOut/WatchOutListing.aspx">Watch Out !!!</a>
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
<TABLE align="center" style="BORDER-RIGHT: #b6c0d6 1px solid; BORDER-TOP: #b6c0d6 1px solid; BORDER-LEFT: 
#b6c0d6 1px solid; BORDER-BOTTOM: #b6c0d6 1px solid; width: 918px;"><TBODY>
<tr><td align="center" colspan="2" class="header" style="height: 13px">
<h4>Edit Send Email </h4></td></tr>
<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Send Email Subject :</TD><TD align=left  class="content" style="height: 13px"><asp:TextBox  
	SkinID=heading  id="txtEmailSubject" runat="Server" Width="358px"></asp:TextBox>
	
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmailSubject"
            ErrorMessage="Required."></asp:RequiredFieldValidator></TD></TR>
            
<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Is Email Sent :</TD><TD align=left  class="content" style="height: 13px">
    
    <asp:CheckBox id="isEmailSent"
                    AutoPostBack="false"
                    TextAlign="Right"
                    runat="server"/>
            
            
<TR><TD align=right  class="content" style="height: 13px;" >
    &nbsp;Is Subscribers :</TD><TD align=left  class="content" style="height: 13px">
    
    <asp:CheckBox id="isSubscribers"
                    AutoPostBack="false"
                    TextAlign="Right"
                    runat="server"/>
                    
<TR><TD align=right  class="content" style="height: 13px;">
   Email Description : </TD></TR>
    <tr><td colspan="2" align="center"  class="content">
	
	
    <FCKeditorV2:FCKeditor id="fckcontent" BasePath="~/FCKeditor/" Width="900px" runat="server" value='This is some <strong>sample text</strong>.
	You are using <a href="http://www.fckeditor.net/">FCKeditor</a>.'></FCKeditorV2:FCKeditor></td></tr>
	
<TR><TD align=center colSpan=2  class="content">
    <asp:Button ID="btnsave" runat="server" Text="Add" Width="76px" OnClick="btnsave_Click" /></TD></TR>
</TBODY></TABLE>
	</div>
</form>