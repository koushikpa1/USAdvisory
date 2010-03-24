<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsAndViews.ascx.cs" Inherits="controls_NewsAndViews" %>

 <div class="greybox-home-page-2">
      <div class="greybox-home-page-upper"><h1>News &amp; Views</h1>
      </div>
      <div class="greybox-home-page-middle-1">
		<ul>
	    <asp:Repeater ID="NewsandViewsRepeater" runat="server" EnableViewState="false">
        <ItemTemplate>
       <li>
        <%# DataBinder.Eval(Container.DataItem, "ArticleTitle")%></li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
				
		<span class="more-news"><a href="news.html">More News</a></span></div>
      <div class="greybox-home-page-down"></div>
   </div>