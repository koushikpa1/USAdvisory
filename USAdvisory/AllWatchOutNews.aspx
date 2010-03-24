<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllWatchOutNews.aspx.cs" Inherits="AllWatchOutNews" %>

    <p align="center"><asp:Label id="currentDate" runat="server"></asp:Label></p>
<div class="blue-box-middle-home-page4">
		<ul>
	    <asp:Repeater ID="watchOutRepeater" runat="server" EnableViewState="false">
        <ItemTemplate>
       <li><%# DataBinder.Eval(Container.DataItem, "ArticleDate", "{0:HH:mm}")%> - 
        <%# DataBinder.Eval(Container.DataItem, "ArticleTitle")%></li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
</div>
