<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeFile="LogMeIn.aspx.cs" Inherits="admin_LogMeIn" %>


<div id="container" class="clearfix">

    <form id="form1" runat="server">
    <br /><br /><br /><br /><br />
    
    <div>
    
 <table align="center" style="width: 323px; border-color:#0b87ce;border:solid 1px ;  "   >
        <tr>
        <td colspan="2" class="login" style="height: 20px; background-color: #f1f7fc; ">Login</td>
        </tr>
             
        <tr>
        <td class="login" style="width: 103px">User Name</td>
        <td style="width: 229px"><asp:TextBox runat="server" ID="txtlogin" Width="171px"></asp:TextBox></td>
        </tr>
        <tr>
        <td class="login" style="width: 103px">Password</td>
        <td style="width: 229px"><asp:TextBox runat="server" ID="txtpwd" Width="168px" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
        <td colspan="2" align="center" class="login" style="height: 5px"><asp:Label ID="lblmsg" runat="server" Width="289px"></asp:Label></td>
        </tr>
        <tr>
        <td colspan="2" align="center" style="height: 26px"><asp:Button runat="server" ID="bt1" Text="Login" OnClick="bt1_Click" /></td></tr>
        </table>
        </form>