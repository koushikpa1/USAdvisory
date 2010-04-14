<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DStreetUS.master" CodeFile="Subscriptions.aspx.cs" Inherits="Subscriptions" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/MarketToday.ascx" TagName="MarketToday" TagPrefix="MarketToday_uc" %>
<%@ Register Src="Controls/MarketCommentary.ascx" TagName="MarketCommentary" TagPrefix="MarketCommentary_uc" %>
<%@ Register Src="Controls/MarketWatchOut.ascx" TagName="MarketWatchOut" TagPrefix="MarketWatchOut_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>
<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script type="text/javascript" src="js/UI_MyAccount.js"></script>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>Services and Subscriptions</title>
       
        <script type="text/javascript">
       
        </script>
    </head>
    <body onload="changeMenuColor('Services')">
    <form id="form1" runat="server">
     <Header_uc:Header ID="header" runat="server" />
    <div class="main-block">


<!--..................content-block................-->
<div class="content-block">

  
<!--............inner-middle..........-->
<div class="inner-page-mid-block">
 <div class="service-page-left">
  <div class="service-box1">
  <div class="service-box1-upper"><h1>Day &amp; Swing Trading</h1></div>
  <div class="service-box1-mid">
  <ul>
		<li><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		</ul>
  </div>
  <div class="service-box1-down"></div>
  </div>
  
  <div class="service-box-1">
  <div class="service-box1-upper"><h1>Penny Stocks</h1>
  </div>
  <div class="service-box1-mid">
  <ul>
		<li><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		</ul>
  </div>
  <div class="service-box1-down"></div>
  </div>
 </div>
 <div class="service-page-mid">
  <div class="service-box2">
   <div class="service-box2-upper"><h1>Value Investing</h1>
   </div>
   <div class="service-box2-mid">
   <ul>
		<li><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		</ul>
   </div>
   <div class="service-box2-down"></div>
  </div>
  
  <div class="service-box-2">
   <div class="service-box2-upper"><h1>Subscription</h1>
   </div>
   <div class="service-box2-mid">
   <ul>
		<li><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, Duis eget turpis eu purus.</a></li>
		</ul>
   </div>
   <div class="service-box2-down"></div>
  </div>
 </div>
 <div class="service-page-right">
 <div class="service-box1">
  <div class="service-box1-upper"><h1>Virtual Portfolio</h1>
  </div>
  <div class="service-box1-mid">
  <ul>
		<li><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		</ul>
  </div>
  <div class="service-box1-down"></div>
  </div>
  
 <div class="service-box-1">
  <div class="service-box1-upper"><h1>Miscellaenous</h1>
  </div>
  <div class="service-box1-mid">
  <ul>
		<li><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		<li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
		</ul>
  </div>
  <div class="service-box1-down">
  </div>
  </div>
 </div>
</div>
<!--............inner-middle..........-->

<div class="content-block-right">

<div class="add-1"><img src="images/add-1.jpg" alt="Live Chat" /></div>
<div class="add"><img src="images/add-2.jpg" alt="What If You"  /></div>
<div class="add"><img src="images/add-3.jpg" alt="E Trade"  /></div>
</div>
</div>



<div class="clear-div"></div>
</div>
  </form>
</body>
    </html>
</asp:Content>

