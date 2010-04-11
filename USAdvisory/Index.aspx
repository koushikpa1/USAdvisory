<%@ Page Title="" Language="C#" MasterPageFile="~/DStreetUS.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>
<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/MarketToday.ascx" TagName="MarketToday" TagPrefix="MarketToday_uc" %>
<%@ Register Src="Controls/MarketCommentary.ascx" TagName="MarketCommentary" TagPrefix="MarketCommentary_uc" %>
<%@ Register Src="Controls/MarketWatchOut.ascx" TagName="MarketWatchOut" TagPrefix="MarketWatchOut_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>
<%-- Add content controls here --%>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <Header_uc:Header ID="header" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="marketToday"  runat="server">
<MarketToday_uc:MarketToday ID="MarketToday" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="marketCommentary"  runat="server">
<MarketCommentary_uc:MarketCommentary ID="Commentary" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="marketWatchOut"  runat="server">
<MarketWatchOut_uc:MarketWatchOut ID="MarketWatchOut" runat="server" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="advertisements"  runat="server">
<Advertisements_uc:Advertisements ID="Advertisements" runat="server" />
</asp:Content>

