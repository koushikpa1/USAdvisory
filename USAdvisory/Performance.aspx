<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DStreetUS.master"
    CodeFile="Performance.aspx.cs" Inherits="Performance" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/MarketToday.ascx" TagName="MarketToday" TagPrefix="MarketToday_uc" %>
<%@ Register Src="Controls/MarketCommentary.ascx" TagName="MarketCommentary" TagPrefix="MarketCommentary_uc" %>
<%@ Register Src="Controls/MarketWatchOut.ascx" TagName="MarketWatchOut" TagPrefix="MarketWatchOut_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <Header_uc:Header ID="header" runat="server" />
    <form id="Form1" runat="server">
    <asp:ScriptManager ID="smDefault" runat="Server">
    </asp:ScriptManager>
    <div class="main-block">
        <div class="content-block">
            <!--............inner-middle..........-->
            <div class="inner-page-mid-block-1">
                <h1 class="blue-color" id="heading-margin">
                    Performance</h1>
                <br />
                <div style="border-style: ridge">
                    <!--GridView Goes Here-->
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="GridView_Performance" runat="server" CellPadding="4" ForeColor="#333333"
                                GridLines="None" AutoGenerateColumns="False" OnPageIndexChanging="GridView_Performance_PageIndexChanging"
                                AllowPaging="true" DataKeyNames="ArticleId">
                                <Columns>
                                    <asp:BoundField DataField="Ticker" HeaderText="Ticker" SortExpression="Ticker" HeaderStyle-Width="100"
                                        ItemStyle-HorizontalAlign="Center">
                                        <HeaderStyle Width="100px" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TradeType" HeaderText="TradeType" SortExpression="TradeType"
                                        HeaderStyle-Width="100" ItemStyle-HorizontalAlign="Center">
                                        <HeaderStyle Width="100px" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="ArticleDate" HeaderText="Entry Date" SortExpression="ArticleDate"
                                        DataFormatString="{0:dd-MM-yyyy}" HeaderStyle-Width="100" ItemStyle-HorizontalAlign="Center">
                                        <HeaderStyle Width="100px" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:HyperLinkField HeaderText="Recommendation" DataTextField="ArticleTitle" DataNavigateUrlFields="ArticleID"
                                        HeaderStyle-Width="340" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="340">
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:HyperLinkField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <a rel="#facebox" href='<%#Eval("ArticleId","ModalPopUp.aspx?Id={0}&TradeType=1")%>'>
                                                <img border="0" src="Images/mag_glass_icon.gif" alt="View" /></a>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NextPreviousFirstLast"
                                    NextPageText="Next" PreviousPageText="Prev" />
                                <RowStyle BackColor="#EFF3FB" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <AlternatingRowStyle BackColor="White" />
                            </asp:GridView>
                            <div>
                                <asp:Label ID="Label1" runat="server">No of Records Per Page</asp:Label>
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                                    Width="50px">
                                    <asp:ListItem Value="10">10</asp:ListItem>
                                    <asp:ListItem Value="20">20</asp:ListItem>
                                    <asp:ListItem Value="30">30</asp:ListItem>
                                    <asp:ListItem Value="40">40</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <!--............inner-middle..........-->
            <div class="content-block-right-1">
                <!--Adds goes Here-->
                <div class="add-1">
                    <img src="images/add-1.jpg" alt="Live Chat" /></div>
                <div class="add">
                    <img src="images/add-2.jpg" alt="What If You" /></div>
                <div class="add">
                    <img src="images/add-3.jpg" alt="E Trade" /></div>
            </div>
        </div>
        <div class="clear-div">
        </div>
    </div>
    </form>
</asp:Content>
