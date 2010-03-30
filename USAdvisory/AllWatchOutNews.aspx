<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllWatchOutNews.aspx.cs" Inherits="AllWatchOutNews" %>

     <p class="popupHeader"><asp:Label id="currentDate" runat="server"></asp:Label></p>

<table>

	    <asp:Repeater ID="watchOutRepeater" runat="server" EnableViewState="false">
        <ItemTemplate>
        <tr>
        <td>
        <span style="text-align:justify"><img src="images/bullet-black.jpg" />
       <b><%# DataBinder.Eval(Container.DataItem, "ArticleDate", "{0:HH:mm}")%> - <%# DataBinder.Eval(Container.DataItem, "ArticleTitle")%></b>
        <%# DataBinder.Eval(Container.DataItem, "ArticleDesc")%></span>
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
        <%# DataBinder.Eval(Container.DataItem, "ArticleDesc")%></span>
        </td>
        </tr>
        </AlternatingItemTemplate>
    </asp:Repeater>
    </table>
<%--</ul>--%>

