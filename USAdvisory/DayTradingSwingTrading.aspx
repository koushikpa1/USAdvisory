<%@ Page Title="" Language="C#" MasterPageFile="~/DStreetUS.master" AutoEventWireup="true" CodeFile="DayTradingSwingTrading.aspx.cs" Inherits="DayTradingSwingTrading" %>
<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/MarketToday.ascx" TagName="MarketToday" TagPrefix="MarketToday_uc" %>
<%@ Register Src="Controls/MarketCommentary.ascx" TagName="MarketCommentary" TagPrefix="MarketCommentary_uc" %>
<%@ Register Src="Controls/MarketWatchOut.ascx" TagName="MarketWatchOut" TagPrefix="MarketWatchOut_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>
<%-- Add content controls here --%>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <Header_uc:Header ID="header" runat="server" />
    <html>
    <body>
    
    <div class="content-block">

  
<!--............inner-middle..........-->
<div class="inner-page-mid-block-1">
 <h1 class="blue-color" id="heading-margin">Day &amp; Swing Trading</h1>
 <br />
<table border="0" cellspacing="0" cellpadding="0">
   
   <tr>
   <td colspan="2"><img src="images/blue-strip-up.jpg" /></td>
   </tr>
   
   <tr>
   <td class="blue-strip" width="124" style="color:#FFFFFF">Nov 10-1-2010</td>
   <td class="grey-strip" width="558">
   <table><tr><td width="282">Ticker: Description: Update:</td>
   <td width="160">Entry:</td>
   <td width="71">Exit</td>
   </tr></table>
   </td>
   </tr>
   
   <tr>
   <td class="blue-strip" width="124" style="color:#FFFFFF">Nov 10-1-2010</td>
   <td class="grey-strip" width="558">
   <table><tr><td width="282">Ticker: Description: Update:</td>
   <td width="160">Entry:</td>
   <td width="71">Exit</td>
   </tr></table>
   </td>
   </tr>
   
   <tr>
   <td class="blue-strip" width="124" style="color:#FFFFFF">Nov 10-1-2010</td>
   <td class="grey-strip" width="558">
   <table><tr><td width="282">Ticker: Description: Update:</td>
   <td width="160">Entry:</td>
   <td width="71">Exit</td>
   </tr></table>
   </td>
   </tr>
   
   <tr>
   <td class="blue-strip-1" width="124" style="color:#FFFFFF">Nov 10-1-2010</td>
   <td class="grey-strip-1" width="558">
   <table><tr><td width="282">Ticker: Description: Update:</td>
   <td width="160">Entry:</td>
   <td width="71">Exit</td>
   </tr></table>
   </td>
   </tr>

    <td colspan="2"><img src="images/day-trading-down.jpg" /></td>
  </tr>
  
</table>

</div>
<!--............inner-middle..........-->

<div class="content-block-right-1">
<table border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td class="grey-top"><h1 style="margin-top:4px; margin-left:10px;">Archives</h1></td>
  </tr>
  
  <tr>
    <td class="grey-gradiant">
	<table><tr><td width="135">Tiker Description</td>
	<td width="81">Entry</td>
	<td width="35">Exit</td>
	</tr></table>
	</td>
  </tr>
  
  <tr>
    <td class="grey-gradiant">
	<table><tr><td width="135">Tiker Description</td>
	<td width="81">Entry</td>
	<td width="35">Exit</td>
	</tr></table>
	</td>
  </tr>
  
  <tr>
    <td class="grey-gradiant">
	<table><tr><td width="135">Tiker Description</td>
	<td width="81">Entry</td>
	<td width="35">Exit</td>
	</tr></table>
	</td>
  </tr>
  
  <tr>
    <td class="grey-gradiant-1">
	<table><tr><td width="135">Tiker Description</td>
	<td width="81">Entry</td>
	<td width="35">Exit</td>
	</tr></table>
	</td>
  </tr>
  
  <tr><td><img src="images/grey-bottom.jpg" /></td></tr>
  
</table>

</div>
</div>
</body>
    </html>
</asp:Content>
