<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DStreetUS.master"
    CodeFile="QueryCorner.aspx.cs" Inherits="QueryCorner" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/MarketToday.ascx" TagName="MarketToday" TagPrefix="MarketToday_uc" %>
<%@ Register Src="Controls/MarketCommentary.ascx" TagName="MarketCommentary" TagPrefix="MarketCommentary_uc" %>
<%@ Register Src="Controls/MarketWatchOut.ascx" TagName="MarketWatchOut" TagPrefix="MarketWatchOut_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <Header_uc:Header ID="header" runat="server" />
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>Untitled Page</title>

        <script type="text/javascript" src="../js/jquery-1.3.2.min.js"></script>

        <script type="text/javascript" src="../js/jquery.validate.js"></script>

        <script type="text/javascript">
            $(document).ready(function() {
                $("#<%=Form1.ClientID%>").validate({
                    rules: {
                        "<%=txtUserID.UniqueID %>": {
                            required: true,
                            minlength: 2
                        },
                        "<%=txtQuery.UniqueID %>": {
                            required: true,
                            minlength: 2
                        }
                    },
                    messages: {
                        "<%=txtUserID.UniqueID %>": "Enter your Unique ID",
                        "<%=txtQuery.UniqueID %>": "Enter a Query"

                    }
                });
            })
        </script>

        <style type="text/css">
            input.error
            {
                border: 1px dotted red;
            }
            label.error
            {
                float: left;
                color: red;
                padding-left: .5em;
                vertical-align: top;
            }
        </style>
    </head>
    <body>
        <div>
            <!--..................top-block....................-->
            <!--..................content-block................-->
            <div class="content-block">
                <!--............inner-middle..........-->
                <div class="inner-page-mid-block">
                    <div class="query-page-box">
                        <div class="query-page-upper">
                            <h2>
                                Query</h2>
                        </div>
                        <div class="query-page-middle">
                            <form id="Form1" runat="server">
                            <div>
                                <table width="100%">
                                    <tr>
                                        <td style="width: 150">
                                            <asp:Label ID="lblUserID" runat="server" Text="UserID"></asp:Label>
                                        </td>
                                        <td style="width: 150">
                                            <asp:TextBox ID="txtUserID" runat="server" CssClass="textbox"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="150">
                                            <asp:Label ID="lblDomain" runat="server" Text="Query Domain"></asp:Label>
                                        </td>
                                        <td style="width: 200px">
                                            <asp:DropDownList ID="ddQueryDomain" runat="server" Height="25px" Width="150px" CssClass="dropdown">
                                                <asp:ListItem Value="1">1</asp:ListItem>
                                                <asp:ListItem Value="2">2</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 150px">
                                            <asp:Label ID="lblQuery" runat="server" Text="Query"></asp:Label>
                                        </td>
                                        <td style="width: 200">
                                            <asp:TextBox ID="txtQuery" runat="server" Height="200" Width="200" CssClass="textbox"
                                                TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 121px">
                                        </td>
                                        <td align="right" style="width: 116px">
                                            <asp:Button ID="btnSubmit" runat="server" Text="Submit Query" OnClick="btnSubmit_Click"
                                                Width="126px" CssClass="register-button" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" align="center">
                                            <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            </form>
                        </div>
                        <div class="query-page-down">
                        </div>
                    </div>
                </div>
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
            <!--..................content-block................-->
            <div class="clear-div">
            </div>
        </div>
    </body>
    </html>
</asp:Content>
