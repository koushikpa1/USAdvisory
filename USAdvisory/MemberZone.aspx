<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DStreetUS.master" CodeFile="MemberZone.aspx.cs" Inherits="MemberZone" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/MarketToday.ascx" TagName="MarketToday" TagPrefix="MarketToday_uc" %>
<%@ Register Src="Controls/MarketCommentary.ascx" TagName="MarketCommentary" TagPrefix="MarketCommentary_uc" %>
<%@ Register Src="Controls/MarketWatchOut.ascx" TagName="MarketWatchOut" TagPrefix="MarketWatchOut_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <Header_uc:Header ID="header" runat="server" />
 <div class="content-block">

  
<!--............inner-middle..........-->
<div class="inner-page-mid-block">
 <h1>Member Zone</h1>
</div>
<!--............inner-middle..........-->

<div class="content-block-right">

<div class="add-1"><img src="images/add-1.jpg" alt="Live Chat" /></div>
<div class="add"><img src="images/add-2.jpg" alt="What If You"  /></div>
<div class="add"><img src="images/add-3.jpg" alt="E Trade"  /></div>
</div>
</div>
</asp:Content>
