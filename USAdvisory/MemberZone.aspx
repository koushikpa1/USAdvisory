<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DStreetUS.master" CodeFile="MemberZone.aspx.cs" Inherits="MemberZone" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/MarketToday.ascx" TagName="MarketToday" TagPrefix="MarketToday_uc" %>
<%@ Register Src="Controls/MarketCommentary.ascx" TagName="MarketCommentary" TagPrefix="MarketCommentary_uc" %>
<%@ Register Src="Controls/MarketWatchOut.ascx" TagName="MarketWatchOut" TagPrefix="MarketWatchOut_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript" src="js/UI_MyAccount.js"></script>
<html>
<head>

</head>
<body onload="changeMenuColor('MemberZone')">
<form id="form1" runat="server">
    <Header_uc:Header ID="header" runat="server" />
 <div class="content-block">

  
<!--............inner-middle..........-->
<div class="inner-page-mid-block">
 <h1>Member Zone</h1>
    <p>&nbsp;</p>

 <table width="100%" border="0" cellspacing="0" cellpadding="0" > 
  <tr> 
    
    <td ><img src="images/border-top.jpg" /></td> 
  </tr> 
  <tr> 
    <td class="line-middle"> 
	 <table width="548"> 
	   <tr> 
	   <td width="15"><img src="images/bullet-black.jpg" align="top" /></td> 
	   <td width="285"><a href="DayTradingSwingTrading.aspx" class="blue-color">Day &amp; Swing Trading </a></td> 
	   <td width="232"><asp:Label ID="lblDayTrade" runat="server"></asp:Label></td> 
	   </tr></table> 
	</td> 
    </tr> 
	
	<tr> 
    <td class="line-middle"> 
	<table width="550"> 
	  <tr> 
	   <td width="14"><img src="images/bullet-black.jpg" align="top" /></td> 
	  <td width="286"><a href="ValueInvesting.aspx" class="blue-color">Value Investing </a></td> 
	<td width="234" ><asp:Label ID="lblValueInvesting" runat="server"></asp:Label></td> 
	</tr></table> 
	</td> 
    </tr> 
	
	<tr> 
    <td class="line-middle"> 
	<table width="549"> 
	  <tr> 
	   <td width="15"><img src="images/bullet-black.jpg" align="top" /></td> 
	  <td width="284"><a href="PennyStocks.aspx" class="blue-color"> Penny Stocks </a></td> 
	<td width="234"><asp:Label ID="lblPennyStocks" runat="server"></asp:Label></td> 
	</tr></table> 
	</td> 
    </tr> 
	
	<tr> 
    <td class="line-middle"> 
	<table width="549"> 
	  <tr> 
	   <td width="15"><img src="images/bullet-black.jpg" align="top" /></td> 
	  <td width="285"><a href="VirtualPortfolio.aspx" class="blue-color">Virtual Portfolio </a></td> 
	<td width="233"><asp:Label ID="lblVirtualPortfolio" runat="server"></asp:Label></td> 
	</tr></table> 
	</td> 
    </tr> 
	
     
	<tr><td class="line-middle-1">&nbsp;</td> 
	</tr> 
	 
  <tr> 
    <td ><img src="images/border-bottom.jpg" /></td> 
  </tr> 
</table> 
 
</div>
<!--............inner-middle..........-->

<div class="content-block-right">

<div class="add-1"><img src="images/add-1.jpg" alt="Live Chat" /></div>
<div class="add"><img src="images/add-2.jpg" alt="What If You"  /></div>
<div class="add"><img src="images/add-3.jpg" alt="E Trade"  /></div>
</div>
 <div class="clear-div">
            </div>
</div>
</form>
</body>
</html>
</asp:Content>
