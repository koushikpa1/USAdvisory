<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MarketCommentary.ascx.cs" Inherits="controls_MarketCommentary" %>
<%@ Register Src="RecentPerformance.ascx" TagName="RecentPerformance" TagPrefix="RecentPerformance_uc" %>
<%@ Register Src="NewsAndViews.ascx" TagName="NewsAndViews" TagPrefix="NewsAndViews_uc" %>

<!--............middle..........-->
<div class="content-block-middle">
  <div class="greybox-home-page-1">
       <div class="greybox-home-page-upper"><h1>Market Commentary - <asp:Label ID="commentaryDateTime" runat="server"></asp:Label></h1>
      </div>
      <div class="greybox-home-page-middle">
	<strong><asp:Label ID="commentaryTitle" runat="server"></asp:Label></strong><br /> <br />
	  <asp:Label ID="commentaryDesc" runat="server"></asp:Label>
	   
	   <a href="CompleteCommentary.aspx" rel="#facebox" style="color:Red"> ....Click here to view the complete article</a></div>
      <div class="greybox-home-page-down"></div>
   </div>
     <div class="daily-inbox">
	 <form class="form-daily-inbox" action="#" runat="server">
			   <table width="260" border="0" cellpadding="0" cellspacing="4">
                 
				 
                 <tr>
                   
                   <td><asp:TextBox id="txtEmailAddress" runat="Server" CssClass="input-2" runat="server"></asp:TextBox>
	
                    </td>
				   <td><label>
				   
				 <asp:Button ID="btnsave" runat="server" CssClass="button-2" Text="Free Sign Up" OnClick="btnsave_Click" />
				   
                   <!--  <input name="Submit" type="submit" class="button-2" value="Free Sign Up" onclick="javascript:return validForm();"/> -->
                   </label></td>
                 </tr>
                 
                 
				 
				 
        </table>
	  </form>
	 </div>
	 
	<!-- News & Views control here-->
   <NewsAndViews_uc:NewsAndViews ID="NewsAndViews" runat="server" />
   
   <div class="greybox-home-page-2">
      <div class="greybox-home-page-upper"><h1>Recent Performance</h1>
      </div>
      <div class="greybox-home-page-middle-2">
	  Lorem ipsum dolor sit amet, consectetur adipiscing elitduis eget turpis eu purus. Lorem ipsum dolor sit amet, consectetur adipiscing elitduis 
	  
	  <form class="form-recent-performance" action="#">
			   <table width="397" border="0" cellpadding="0" cellspacing="4">
                 
				 
                 <tr>
                   <td>Email</td>
                   <td><input type="text" name="fname" id="fname"  value="" class="input-3"/></td>
				   <td>Name</td>
				   <td><input type="text" name="name" id="name"  value="" class="input-3"/></td>
				   <td><label>
                     <input name="Submit" type="submit" class="button-3" value="Submit" onclick="javascript:return validForm();"/>
                   </label></td>
                 </tr>
                 
                 
				 
				 
        </table>
	  </form>
	  </div>
      <div class="greybox-home-page-down"></div>
   </div>
   
   <div class="add"><img src="images/free-trial-image.jpg" alt="Free Trial" /></div>
</div>
<!--............middle..........-->