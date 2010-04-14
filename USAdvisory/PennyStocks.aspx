<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DStreetUS.master"
    CodeFile="PennyStocks.aspx.cs" Inherits="PennyStocks" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/MarketToday.ascx" TagName="MarketToday" TagPrefix="MarketToday_uc" %>
<%@ Register Src="Controls/MarketCommentary.ascx" TagName="MarketCommentary" TagPrefix="MarketCommentary_uc" %>
<%@ Register Src="Controls/MarketWatchOut.ascx" TagName="MarketWatchOut" TagPrefix="MarketWatchOut_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <script type="text/javascript" src="js/UI_MyAccount.js"></script>
<html><head></head>
<body onload="changeMenuColor('MemberZone')">
  
  
  <form id="Form1" runat="server">
 
  <Header_uc:Header ID="header" runat="server" />
    <asp:ScriptManager ID="smDefault" runat="Server">
    </asp:ScriptManager>
    <div class="main-block">
        <div class="content-block">
            <!--............inner-middle..........-->
            <div class="inner-page-mid-block-1">
                <h1 class="blue-color" id="heading-margin">
                    Penny Stocks</h1>
                <br />
                <div style="border-style: ridge">
                    <!--GridView Goes Here-->
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="GridView_PennyStocks" runat="server" CellPadding="4" ForeColor="#333333"
                                GridLines="None" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="ArticleDate" HeaderText="ArticleDate" SortExpression="ArticleDate"
                                        DataFormatString="{0:dd-MM-yyyy}" HeaderStyle-Width="100" ItemStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Ticker" HeaderText="Ticker" SortExpression="Ticker" HeaderStyle-Width="100"
                                        ItemStyle-HorizontalAlign="Center" />
                                    <asp:BoundField HeaderText="ArticleTitle" HeaderStyle-Width="450" ItemStyle-Width="450"
                                        ItemStyle-HorizontalAlign="Center" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <a rel="#facebox" href='<%#Eval("ArticleId","ModalPopUp.aspx?Id={0}&TradeType=1")%>'>
                                                <img border="0" src="Images/mag_glass_icon.gif" alt="View" /></a>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <RowStyle BackColor="#EFF3FB" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <AlternatingRowStyle BackColor="White" />
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <!--............inner-middle..........-->
            <div class="content-block-right-1" style="border-style: ridge">
                <!--Archive goes Here-->
                <h1 class="blue-color" id="h1">
                    Archives</h1>
                <br />
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:GridView ID="GridViewArchive_PennyStocks" runat="server" CellPadding="4" ForeColor="#333333"
                            GridLines="None" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="ArchivePageIndexChanging">
                            <Columns>
                                <asp:BoundField DataField="ArticleDate" HeaderText="ArticleDate" SortExpression="ArticleDate"
                                    DataFormatString="{0:dd-MM-yyyy}" HeaderStyle-Width="100" ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle Width="100px" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Ticker" HeaderText="Ticker" SortExpression="Ticker" HeaderStyle-Width="100"
                                    ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle Width="100px" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="ArticleTitle" HeaderStyle-Width="450" ItemStyle-Width="450"
                                    ItemStyle-HorizontalAlign="Center" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <a rel="#facebox" href='<%#Eval("ArticleId","ModalPopUp.aspx?Id={0}&TradeType=1")%>'>
                                            <img border="0" src="Images/mag_glass_icon.gif" alt="View" /></a>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle BackColor="#EFF3FB" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <AlternatingRowStyle BackColor="White" />
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <div class="clear-div">
        </div>
    </div>
    </div>
    </form>
</asp:Content>
