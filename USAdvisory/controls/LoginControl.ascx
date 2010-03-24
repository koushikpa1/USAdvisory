<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginControl.ascx.cs" Inherits="controls_LoginControl" %>
   <div class="upper-header-login-box">
				   <form class="form-home-upper" action="#">
			   <table width="250" border="0" cellpadding="0" cellspacing="4">
                 <tr>
                   <td width="59"><label>User Name:</label></td>
                   <td width="189"><input type="text" name="fname1" id="fname1" value="" class="input-1"/></td>
                 </tr>
				 
                 <tr>
                   <td>Password:</td> 
                   <td><input type="text" name="email2" id="email2"  value="" class="input-1"/></td>
                 </tr>
                 
                 <tr>
                   <td colspan="2" align="left" valign="middle">
				   <input name="" type="checkbox" value="" class="check-box" />
				   <span style="float:left; margin-top:8px; ">Remember Me</span>
				   <label>
                     <input name="Submit" type="submit" class="button-1" value="Login" onclick="javascript:return validForm();"/>
                   </label></td>
                 </tr>
				 
				 <tr>
				 <td colspan="2">
				 <a href="#">Forget Your Password</a> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				  <a href="register.html">Register Me</a></td>
				 </tr>
        </table>
	  </form>
				   </div>