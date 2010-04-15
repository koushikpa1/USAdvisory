<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllWatchOutNews.aspx.cs"
    Inherits="AllWatchOutNews" %>

<p class="popupHeader">
    <asp:label id="currentDate" runat="server"></asp:label>
</p>
<table height="50px">
    <asp:repeater id="watchOutRepeater" runat="server" enableviewstate="false">
        <ItemTemplate>
        <tr>
        <td>
        <span class="justifyText"><img src="images/bullet-black.jpg" />
       <b><%# DataBinder.Eval(Container.DataItem, "ArticleDate", "{0:HH:mm}")%> - <%# DataBinder.Eval(Container.DataItem, "ArticleTitle")%></b>
        <%#IsPaidNews((short)DataBinder.Eval(Container.DataItem, "IsPaid"), (string)DataBinder.Eval(Container.DataItem, "ArticleDesc"), (string)DataBinder.Eval(Container.DataItem, "Ticker"))%></span>
        </td>
        </tr>
        </ItemTemplate>
                <SeparatorTemplate>
                <tr>
                <td class="separator">&nbsp;</td>
       
       </tr>
        </SeparatorTemplate>
                <AlternatingItemTemplate>
                <tr><td>
        <span class="justifyText"><img src="images/bullet-black.jpg" />
        <b><%# DataBinder.Eval(Container.DataItem, "ArticleDate", "{0:HH:mm}")%> - <%# DataBinder.Eval(Container.DataItem, "ArticleTitle")%></b>
        <%#IsPaidNews((short)DataBinder.Eval(Container.DataItem, "IsPaid"), (string)DataBinder.Eval(Container.DataItem, "ArticleDesc"), (string)DataBinder.Eval(Container.DataItem, "Ticker"))%></span>
        </td>
        </tr>
        </AlternatingItemTemplate>
    </asp:repeater>
</table>
<%--</ul>--%>
