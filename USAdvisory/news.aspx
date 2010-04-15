<%@ Page Title="" Language="C#" MasterPageFile="~/DStreetUS.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="news" %>
<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%-- Add content controls here --%>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <html>    
    <body>
    <form id="form1" runat="server">
    <Header_uc:Header ID="header" runat="server" />
    <asp:ScriptManager ID="smDefault" runat="server" EnablePageMethods="true">
        <Scripts>           
           
        </Scripts>
     </asp:ScriptManager>
    <asp:HiddenField ID="hdnArticleId" runat="server" />
    <div class="inner-page-mid-block-1">
<div class="news-box">
<div class="news-box-upper"><h1>News &amp; Views</h1></div>
<div class="news-box-middle">
<div class="news-box-left">
            <div class="grid">
                <div class="rounded">
                    <div class="top-outer">
                        <div class="top-inner">
                            <div class="top">
                                <h2>
                                    News</h2>
                            </div>
                        </div>
                    </div>
                    <div class="mid-outer">
                        <div class="mid-inner">
                            <div class="mid">
                                <!-- Content Goes Here! -->
                                <asp:UpdatePanel ID="updatePanel" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <asp:GridView ID="gvNewsAndViews" runat="server" AutoGenerateColumns="False"
                                            AllowPaging="True" AllowSorting="True" CssClass="datatable" 
                                            CellPadding="0" BorderWidth="0px" OnRowDataBound="RowDataBound"   
                                            GridLines="None" DataKeyNames="ArticleId" Width="300px" 
                                            OnPageIndexChanging="gvPageIndexChanging"> 
                                            <PagerStyle CssClass="pager-row" />
                                            <RowStyle CssClass="row"/>
                                            <PagerSettings Mode="NumericFirstLast" PageButtonCount="7" FirstPageText="&#171;"
                                                LastPageText="&#187;" />
                                            <Columns>                                                 
                                                <asp:BoundField HeaderText="Name" DataField="ArticleTitle" SortExpression="ProductName" >
                                                <HeaderStyle CssClass="first" />
                                                    <ItemStyle CssClass="first" />
                                                </asp:BoundField>
                                                
                                            </Columns>
                                        </asp:GridView>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </div>
                    </div>
                    <div class="bottom-outer">
                        <div class="bottom-inner">
                            <div class="bottom">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                       
        </div>
 
 
<div class="content-block-right-2" style="margin-left:70px;margin-top:4px;float:left">

<asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
<ContentTemplate>
<asp:Label ID="lblArticleDes"  BorderWidth="1" BorderColor="ActiveBorder" Height="422" Style="overflow-y:scroll;" CssClass="scrollStyle justifyText" runat="server" Width="100%" />
    </ContentTemplate></asp:UpdatePanel></div><div class="news-box-down"></div>
</div>
</div> 

<script type="text/javascript" language="javascript">
    function pageLoad(sender, args) {
        $(document).ready(function() {
        $('#<%=gvNewsAndViews.ClientID%> tr').css({ "Height": "45px" });
            $('#<%=gvNewsAndViews.ClientID%> tr').click(function() {
            $('#<%=gvNewsAndViews.ClientID%> tr').css({ "background-color": "white", "color": "black","Height": "45px"});
            $(this).css({ "background-color": "#B0E0E6", "color": "black" });
            });
            $('#<%=gvNewsAndViews.ClientID%> tr').hover(function() {
            $('#<%=gvNewsAndViews.ClientID%> tr').css({ "background-color": "white", "color": "black" });
            $(this).css({ "background-color": "#B0E0E7", "color": "black" });
            });
        });
    }
    function userSelected(userId) {
        PageMethods.GetArticleDescription(userId,CallSuccess);
                 
             
    }

    function CallSuccess(res) {
        var obj = document.getElementById("<%= lblArticleDes.ClientID %>");
        obj.innerHTML = res;
    }

</script>
        </form>
</body>

    </html>
</asp:Content>

