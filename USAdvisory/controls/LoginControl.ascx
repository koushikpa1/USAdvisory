<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginControl.ascx.cs" Inherits="controls_LoginControl" %>
   <div class="upper-header-login-box">
	<div id="ControlLogin" class="form-home-upper" runat="server">
			   <table width="250" border="0" cellpadding="0" cellspacing="4">
                 <tr>
                   <td width="59"><label>User Name:</label></td>
                   <td width="189"><asp:TextBox ID="txtLogin"  runat="server" Text="" CssClass="input-1"/></td>
                 </tr>
				 
                 <tr>
                   <td>Password:</td> 
                   <td><asp:TextBox TextMode="Password" ID="txtPassword"  runat="server" Text="" CssClass="input-1"/></td>
                 </tr>
                 
                 <tr>
                   <td colspan="2" align="left" valign="middle">
				   <input name="" type="checkbox" value="" class="check-box" />
				   <span style="float:left; margin-top:8px; ">Remember Me</span>
				   <label>
                  <asp:Button ID="Submit" runat="server" CssClass="button-1" Text="Login" 
                           onclick="Submit_Click"/>
                   </label></td>
                 </tr>
				 
				 <tr>
				 <td colspan="2">
				 <a href="#">Forget Your Password</a> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				  <a href="register.html">Register Me</a></td>
				 </tr>
        </table>
      
	  </div>
    <div id="ControlUserInfo" class="form-home-upper" visible="false" runat="server">
           <h3><asp:Label ID="lblWelcome" runat="server" Text="Welcome"></asp:Label></h3>
           <br />
           <label>
            <asp:Button ID="btnSingOut" runat="server" CssClass="button-1" Text="SignOut" 
               onclick="btnSingOut_Click"/>
            </label>
           
       </div>
   </div>