<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DStreetUS.master"
    CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <Header_uc:Header ID="header" runat="server" />
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
        <div>
            <div class="content-block">
                <!--............inner-middle..........-->
                <div class="inner-page-mid-block">
                    <div class="contactus-page-box">
                        <div class="contactus-page-upper-header">
                            <h2>
                                Contact Us</h2>
                        </div>
                        <div class="contactus-page-middle">
                            <form action="#" class="form-contact-us">
                            <table width="344" border="0" cellpadding="0" cellspacing="4">
                                <tr>
                                    <td width="44">
                                        <label>
                                            Name:</label>
                                    </td>
                                    <td width="344">
                                        <asp:TextBox ID="txtName" runat="server" CssClass="textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Email:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Query:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtQuery" TextMode="MultiLine"  runat="server" CssClass="textbox" Width="300px" Height="300px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" valign="middle" style="width: 121px">
                                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" align="left" valign="middle">
                                        <asp:Label ID="Label1" runat="server" />
                                    </td>
                                </tr>
                            </table>
                            </form>
                        </div>
                        <div class="contactus-page-upper-down">
                        </div>
                    </div>
                    <span style="margin-left: 170px; float: left; margin-top: 10px !important; margin-left: 170px !important;
                        margin-left: 170px; width: 500px;">Support Email:<a href="mailto: abinjk@sdsdfd.com">abinjk@sdsdfd.com</a>
                        | Subscription: <a href="mailto:sdsfd@sdsdfs.com">sdsfd@sdsdfs.com</a></span></div>
                <!--............inner-middle..........-->
                <div class="content-block-right">
                    <div class="add-1">
                        <img src="images/add-1.jpg" alt="Live Chat" /></div>
                    <div class="add">
                        <img src="images/add-2.jpg" alt="What If You" /></div>
                    <div class="add">
                        <img src="images/add-3.jpg" alt="E Trade" /></div>
                </div>
            </div>
        </div>
        </form>
    </body>
    </html>
</asp:Content>
