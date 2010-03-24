<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendEmailListing.aspx.cs" Inherits="admin_Email_SendEmailListing" %>
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
<a href="../../Portfolio/PortfoliosListing.aspx">View Portfolio</a>
<a href="../../Portfolio/PortfolioAdd.aspx">Add Portfolio</a>
</div>

<!--4th drop down menu -->                                                
<div id="dropmenu4_d" class="dropmenudiv_d" style="width: 150px;">
<a href="../../Users/UserListing.aspx">View Users</a>
<a href="../../Orders/OrdersListing.aspx">View Orders</a>
</div>



<script type="text/javascript">
    //SYNTAX: tabdropdown.init("menu_id", [integer OR "auto"])
    tabdropdown.init("glowmenu", "auto")
</script>


	<!--[if !IE]> main content <![endif]-->
	<div id="maincontent1" >
<div class="contentheader clearfix" >
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <H1 align="center">Send Email Listing</H1>
        <asp:UpdatePanel runat="server" ID="gvUpdatePanel" UpdateMode="Conditional">
            <ContentTemplate>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp; Filter Commentary (first letters):  <asp:TextBox CssClass="MainFont" 
        ID="txtName" runat="server"></asp:TextBox>
        <asp:LinkButton ID="lbFilter" runat="server" 
        OnClick="lbFilter_Click">Apply filter</asp:LinkButton> &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:LinkButton ID="LinkButton2" runat="server" 
        OnClick="lbGetAll_Click">Get All Send Email Listings</asp:LinkButton> 
        &nbsp;&nbsp;&nbsp;&nbsp;
        <a href="AddSendEmail.aspx">Add New Send Email</a>
        
                <table border="0" align="center">
                <tr><td>&nbsp;</td></tr>
                 <tr><td>&nbsp;</td></tr>
                  <tr><td>&nbsp;</td></tr>
                    <tr>
                        <td>
                        
                                  <asp:GridView ID="GridView1" BorderColor="#ABC7EC" BorderStyle="Solid" BorderWidth="4px" 
				                   DataSourceID="ObjectDataSource1" runat="server" AllowPaging="True" 
                                      AutoGenerateColumns="False" CellPadding="4" EmptyDataText="There are no data records to display." 
					                    ForeColor="#333333" GridLines="Both">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="IsEmailSent" HeaderText="IsEmailSent" 
                                        SortExpression="IsEmailSent"/>
                                    <asp:BoundField DataField="EmailSubject" HeaderText="EmailSubject" 
                                        SortExpression="EmailSubject" />
                                        <asp:TemplateField HeaderText="Edit">
                                        <ItemStyle Width="8%"></ItemStyle>
                                        <ItemTemplate>
                                                             <a href="EditSendEMail.aspx?mode=edit&id=<%#Eval("SendEmailId")%>">Edit</a>
                                        </ItemTemplate>
                                        </asp:TemplateField>

                                    <asp:BoundField DataField="Emaildatetime" HeaderText="Emaildatetime" 
                                        SortExpression="Emaildatetime" dataformatstring ="{0:dd-MM-yyyy}"/>

                                </Columns>
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#D0DEF0" ForeColor="White" HorizontalAlign="Center" CssClass="Border" />
                                <HeaderStyle CssClass="GridviewHeader" />
                                <AlternatingRowStyle BackColor="White" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
                </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="udProgress" runat="server" AssociatedUpdatePanelID="gvUpdatePanel"

                            DisplayAfter="100" Visible="true" DynamicLayout="true">
                            
                            <ProgressTemplate>
                               
                                <div> 

                                   <img src="~/Images/indicator.gif" />

                                   Loading...

                               </div>

                               
                            </ProgressTemplate>
                            </asp:UpdateProgress>
                            
                 <asp:ObjectDataSource ID="ObjectDataSource1" 
                            runat="server" SelectMethod="GetAllSendEmails" 
                            TypeName="DStreet.USAdvisory.Business.Admin.Email.SendEmailListing">
                   </asp:ObjectDataSource>

	</div>
</form>