<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MarketWatchOut.ascx.cs" Inherits="controls_MarketWatchOut" %>
<!--............left..........-->
<div class="content-block-left">
<!--....box-1....-->
     <div class="blue-box-home-page-1">
	    <div class="blue-box-upper-home-page"><h1 class="color-white">Watch Out !!! <asp:Label ID="Label1" runat="server"></asp:Label></h1>
	    </div>
		<div class="blue-box-middle-home-page1">
		<ul>
	    <asp:Repeater ID="watchOutRepeater" runat="server" EnableViewState="false">
        <ItemTemplate>
       <li><%# DataBinder.Eval(Container.DataItem, "ArticleDate", "{0:HH:mm}")%> - 
        <%# DataBinder.Eval(Container.DataItem, "ArticleTitle")%></li>
        </ItemTemplate>
    </asp:Repeater>
    </ul>
		<span class="more-news"><a href="AllWatchOutNews.aspx" rel="facebox">More News</a></span>		</div>
		<div class="blue-box-bottom-home-page"></div>
	  </div>
<!--....box-1....-->	
<!--....box-2....-->  
	  <div class="blue-box-home-page-2">
	    <div class="blue-box-upper-home-page">
		<span class="star-icon"><img src="images/home-page-star-icon.jpg" alt="#" /></span>
		<h1 class="color-white">Premium Services</h1>
	    </div>
		<div class="blue-box-middle-home-page">
		<ul>
		<li><a href="#">Day & Swing Trading</a></li>
		<li><a href="#">Value Investing</a></li>
		<li><a href="#">Penny Stocks</a></li>
		<li><a href="#">Virtual Portfolio</a></li>
		<li><a href="#">Query Corner</a></li>
		<li><a href="#">Options Mania (Coming Soon)</a></li>
		</ul>
		</div>
		<div class="blue-box-bottom-home-page"></div>
	  </div>
<!--....box-2....-->

<div class="add"><img src="images/home-left-image.jpg" alt="Add" /></div>
<div class="add"><img src="images/7-day-trial.jpg" alt="7 Day Trial" /></div>
  </div>
<!--............left..........-->
