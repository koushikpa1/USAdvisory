<%@ Page Title="" Language="C#" MasterPageFile="~/DStreetUSInner.master" AutoEventWireup="true" CodeFile="MarketCommentary.aspx.cs" Inherits="MarketCommentary" %>
<%@ Register Src="Controls/HeaderInnerPage.ascx" TagName="Header" TagPrefix="Header_uc" %>


<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <Header_uc:Header ID="header" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<div class="content-block">
<!--............inner-middle..........-->
<div class="inner-page-mid-block">
<div class="article-page-box">
<div class="article-page-upper-header"><h1>Articles</h1></div>
<div class="article-page-mid-line">
  <strong style="font-size:16px;">Lorem ipsum dolor sit amet, consectetur adipiscing elit  </strong>
  <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas condimentum aliquet vulputate. Quisque feugiat varius sodales. Nullam nec ante sit amet quam condimentum lobortis. In fringilla dapibus ligula, in scelerisque risus sagittis vitae. Duis fermentum lectus ut nisl rhoncus a eleifend sem cursus.</p>
  <p> Morbi nec dignissim lacus. Aenean blandit turpis in orci imperdiet pellentesque. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nullam in eros sem. Duis laoreet, turpis quis rhoncus pellentesque, dui ipsum posuere massa, non volutpat felis ipsum sed mauris.</p>
  <p> Praesent laoreet fringilla lorem, sed faucibus ante viverra dapibus. In sit amet lorem ut est consectetur condimentum. Maecenas aliquam congue massa interdum cursus. Integer sollicitudin, nisl sed elementum vestibulum, mi sapien aliquam nulla, quis laoreet metus enim sed tortor. </p>
  <p>Phasellus pulvinar, ipsum vulputate pulvinar suscipit, metus erat accumsan augue, ac placerat tellus lectus in mauris. Aliquam eget ullamcorper leo. Vestibulum non mollis nisl. Mauris ligula mi, eleifend a porttitor a, dictum nec neque. Aliquam id arcu erat, vel imperdiet orci. Aliquam erat volutpat.</p>
  <p> Vivamus eros leo, auctor vel varius ac, dictum congue neque. Pellentesque sed justo congue nisl egestas mollis eget nec diam. Fusce porttitor purus vitae odio dictum et congue lorem lobortis. 
    Etiam faucibus nisl ut nisi venenatis euismod rhoncus vitae nisi Pellentesque sed justo congue nisl egestas mollis eget nec diam. Fusce porttitor purus vitae odio dictum et congue lorem lobortis. </p>
</div>
<div class="article-page-down-header"></div>
</div>
 
    <div class="article-page-news-box">
    <div class="article-page-upper-header"><h1>More News &amp; Views</h1>
    </div>
    <div class="article-page-mid-line">
    <ul>
		    <li><a href="#">Lorem ipsum dolor sit amet, consectetur adipiscing elitduis eget turpis eu purus.</a></li>
		    <li><a href="#">Mollis faucibus elementum iaculis orci. Aenean quis pulvinar arcu. Aliquam accumsan.</a> </li>
		    <li><a href="#">Pellentesque imperdiet. Phasellus id lectus elit, vitae eleifend ipsum. Maecenas lobortis ultricies feugiat. Quisque aliquet facilisis sodales. </a></li>
		    <li class="bullet-margin-top"><a href="#">Nullam rhoncus lacinia ante, non varius libero tempor eget. </a></li>
		    <li><a href="#">Uctus blandit fringilla. Maecenas quis est massa, in condimentum arcu. Duis dignissim sagittis leo sed gravida. </a></li>
		    </ul>
		    <span class="more-news"><a href="#">More News</a></span>
    </div>
<div class="article-page-down-header"></div>
</div>
 
</div>
<div class="content-block-right">
 
<div class="add-1"><img src="images/add-1.jpg" alt="Live Chat" /></div>
<div class="add"><img src="images/add-2.jpg" alt="What If You"  /></div>
<div class="add"><img src="images/add-3.jpg" alt="E Trade"  /></div>
</div>

</asp:Content>