<%@ Page Title="" Language="C#" MasterPageFile="~/DStreetUS.master" AutoEventWireup="true"
    CodeFile="VirtualPortfolio.aspx.cs" Inherits="VirtualPortfolios" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/MarketToday.ascx" TagName="MarketToday" TagPrefix="MarketToday_uc" %>
<%@ Register Src="Controls/MarketCommentary.ascx" TagName="MarketCommentary" TagPrefix="MarketCommentary_uc" %>
<%@ Register Src="Controls/MarketWatchOut.ascx" TagName="MarketWatchOut" TagPrefix="MarketWatchOut_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <Header_uc:Header ID="header" runat="server" />
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    </head>
    <body>
        <form id="Form1" runat="server">
        <%--    <asp:ScriptManager ID="smDefault" runat="Server">
            </asp:ScriptManager>--%>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <div class="main-block">
            <div class="content-block">
                <!--............inner-middle..........-->
                <div class="inner-page-mid-block-1">
                    <h1 class="blue-color" id="heading-margin">
                        Virtual Portfolio</h1>
                    <br />
                    <div>
                        <!--GridView Goes   Here-->
                        <asp:UpdatePanel UpdateMode="Always" runat="server">
                            <ContentTemplate>
                                <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0">
                                    <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="Open Porfolio">
                                        <ContentTemplate>
                                            <asp:GridView ID="GridView_VirtualPortfolioOpen" runat="server" CellPadding="4" ForeColor="#333333"
                                                GridLines="None" EnableModelValidation="True" AllowPaging="True" AutoGenerateColumns="False"
                                                OnPageIndexChanging="GridView_VirtualPortfolioOpen_PageIndexChanging" DataKeyNames="StockTransactionId">
                                                <Columns>
                                                    <asp:BoundField DataField="StockTicker" HeaderText="Ticker" SortExpression="Ticker">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="BuyOrSell" HeaderText="BuyOrSell" SortExpression="BuyOrSell">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="EntryPrice" HeaderText="EntryPrice" SortExpression="EntryPrice">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="ExitPrice" HeaderText="ExitPrice" SortExpression="ExitPrice">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="StopLoss" HeaderText="StopLoss" SortExpression="StopLoss">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="PortfolioEntryDate" HeaderText="EntryDate" SortExpression="PortfolioEntryDate"
                                                        DataFormatString="{0:dd-MM-yyyy}">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <%--<asp:HyperLinkField HeaderText="Updates" DataNavigateUrlFormatString="javascript:alert('Yet to Implement');">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:HyperLinkField>--%>
                                                    <asp:BoundField HeaderText="Updates" HeaderStyle-Width="450" ItemStyle-Width="450"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <a rel="#facebox" href='<%#Eval("StockTransactionId","ModalPopUp.aspx?Id={0}&TradeType=2")%>'>
                                                                <img border="0" src="Images/mag_glass_icon.gif" alt="View" /></a>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                                <AlternatingRowStyle BackColor="White" />
                                                <EditRowStyle BackColor="#2461BF" />
                                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NextPreviousFirstLast"
                                                    NextPageText="Next" PreviousPageText="Prev" />
                                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                <RowStyle BackColor="#EFF3FB" />
                                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                            </asp:GridView>
                                            <div>
                                                <asp:Label runat="server">No of Records Per Page</asp:Label>
                                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                                                    Width="50px">
                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                    <asp:ListItem Value="20">20</asp:ListItem>
                                                    <asp:ListItem Value="30">30</asp:ListItem>
                                                    <asp:ListItem Value="40">40</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:TabPanel>
                                    <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Closed Portfilio">
                                        <ContentTemplate>
                                            <asp:GridView ID="GridView_VirtualPortfolioClosed" runat="server" CellPadding="4"
                                                ForeColor="#333333" GridLines="None" EnableModelValidation="True" AllowPaging="True"
                                                AutoGenerateColumns="False" OnPageIndexChanging="GridView_VirtualPortfolioClosed_PageIndexChanging"
                                                DataKeyNames="StockTransactionId">
                                                <Columns>
                                                    <asp:BoundField DataField="StockTicker" HeaderText="Ticker" SortExpression="Ticker">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="BuyOrSell" HeaderText="BuyOrSell" SortExpression="BuyOrSell">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="EntryPrice" HeaderText="EntryPrice" SortExpression="EntryPrice">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="ExitPrice" HeaderText="ExitPrice" SortExpression="ExitPrice">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="StopLoss" HeaderText="StopLoss" SortExpression="StopLoss">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="PortfolioEntryDate" HeaderText="EntryDate" SortExpression="PortfolioEntryDate"
                                                        DataFormatString="{0:dd-MM-yyyy}">
                                                        <HeaderStyle Width="100px" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <%--<asp:HyperLinkField HeaderText="Updates" 
                                           DataNavigateUrlFormatString="javascript:alert('Yet to Implement');" >
                                            <HeaderStyle Width="100px" />
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:HyperLinkField>--%>
                                                    <asp:BoundField HeaderText="Updates" HeaderStyle-Width="450" ItemStyle-Width="450"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <a rel="#facebox" href='<%#Eval("StockTransactionId","ModalPopUp.aspx?Id={0}&TradeType=2")%>'>
                                                                <img border="0" src="Images/mag_glass_icon.gif" alt="View" /></a>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                                <AlternatingRowStyle BackColor="White" />
                                                <EditRowStyle BackColor="#2461BF" />
                                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NextPreviousFirstLast"
                                                    NextPageText="Next" PreviousPageText="Prev" />
                                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                <RowStyle BackColor="#EFF3FB" />
                                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                            </asp:GridView>
                                            <div>
                                                <asp:Label ID="Label1" runat="server">No of Records Per Page</asp:Label>
                                                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"
                                                    Width="50px">
                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                    <asp:ListItem Value="20">20</asp:ListItem>
                                                    <asp:ListItem Value="30">30</asp:ListItem>
                                                    <asp:ListItem Value="40">40</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:TabPanel>
                                </asp:TabContainer>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <div class="clear-div">
            </div>
        </div>
        </form>
    </body>
    </html>
</asp:Content>
