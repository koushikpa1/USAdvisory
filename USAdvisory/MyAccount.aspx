<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DStreetUS.master"
    CodeFile="MyAccount.aspx.cs" Inherits="MyAccount" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Src="Controls/Advertisements.ascx" TagName="Advertisements" TagPrefix="Advertisements_uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript" src="js/UI_MyAccount.js"></script>

    <html>
    <head>
        <title>Untitled Page</title>

        <script type="text/javascript" src="../js/jquery-1.3.2.min.js"></script>

        <script type="text/javascript" src="../js/jquery.validate.js"></script>

        <script type="text/javascript">
            $(document).ready(function() {
            jQuery.validator.addMethod("phoneUS", function(phone_number, element) {
                phone_number = phone_number.replace(/\s+/g, "");
                return this.optional(element) || phone_number.length > 9 &&
		phone_number.match(/^(1-?)?(\([2-9]\d{2}\)|[2-9]\d{2})-?[2-9]\d{2}-?\d{4}$/);
            }, "Please specify a valid phone number");

                $("#<%=form1.ClientID%>").validate({
                    rules: {
                        "<%=txtNewPassword1.UniqueID %>": {
                            minlength: 2,
                            equalTo: "input[name='<%=txtNewPassword.UniqueID %>']"
                        },
                        "<%=txtOldNo.UniqueID %>": {
                        phoneUS: true
                        },
                        "<%=txtNewNo1.UniqueID %>": {
                        equalTo: "input[name='<%=txtNewNo.UniqueID %>']",
                            phoneUS: true

                        }
                    },
                    messages: {
                        "<%=txtNewPassword1.UniqueID %>": {
                            equalTo: "The passwords do not match"
                        },
                        "<%=txtNewNo1.UniqueID %>": {
                            equalTo: "The phonenumbers do not match"                            
                        }
                    }
                });
            })
        </script>
        
        <style>#field { margin-left: .5em; float: left; }
  	#field, label { float: left; font-family: Arial, Helvetica, sans-serif; font-size: small; }
	br { clear: both; }
	input { border: 1px solid black; margin-bottom: .5em;  }
	input.error { border: 1px solid red; }
	label.error {
		background: url('http://dev.jquery.com/view/trunk/plugins/validate/demo/images/unchecked.gif') no-repeat;
		padding-left: 16px;
		margin-left: .3em;
		color: Red;
	}
	label.valid {
		background: url('http://dev.jquery.com/view/trunk/plugins/validate/demo/images/checked.gif') no-repeat;
		display: block;
		width: 16px;
		height: 16px;		
	}
</style>


        <%--<style type="text/css">
            input.error
            {
                border: 1px dotted red;
            }
            label.error
            {
                float: left;
                color: red;
                padding-left: .5em;
                vertical-align: top;
            }
        </style>--%>
    </head>
    <body>
        <Header_uc:Header ID="header" runat="server" />
        <form id="form1" runat="server">
        <div class="main-block">
            <!--..................content-block................-->
            <div class="content-block">
                <!--............inner-middle..........-->
                <div class="inner-page-mid-block">
                    <div class="myaccount-page-box">
                        <div class="myaccount-box-header">
                            <h2>
                                Change Password</h2>
                        </div>
                        <div class="myaccount-box-middle">
                            <table width="320" border="0" cellpadding="0" cellspacing="4">
                                <tr>
                                    <td width="115">
                                        <label>
                                            Old Password:</label>
                                    </td>
                                    <td width="193">
                                        <asp:TextBox ID="txtOldPassword" runat="server" CssClass="textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        New Password:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNewPassword" runat="server" CssClass="textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Confirm Password:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNewPassword1" runat="server" CssClass="textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="submitPassword_Click" />
                                    </td>
                                    <td>
                                        <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="CancelPassword_Click" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="myaccount-box-dowm">
                        </div>
                    </div>
                    <div class="myaccount-page-box">
                        <div class="myaccount-box-header">
                            <h2>
                                Change Mobile</h2>
                        </div>
                        <div class="myaccount-box-middle">
                            <table width="320" border="0" cellpadding="0" cellspacing="4">
                                <tr>
                                    <td width="136">
                                        <label>
                                            Old Mobile Number: :</label>
                                    </td>
                                    <td width="172">
                                        <asp:TextBox ID="txtOldNo" runat="server" CssClass="textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        New Mobile Number:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNewNo" runat="server" CssClass="textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Confirm Mobile Number:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNewNo1" runat="server" CssClass="textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Button ID="submit" runat="server" Text="Update" OnClick="submit_Click" />
                                    </td>
                                    <td>
                                        <asp:Button ID="cancel" runat="server" Text="Cancel" OnClick="cancel_Click" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="myaccount-box-dowm">
                        </div>
                    </div>
                    <div class="myaccount-page-box-1">
                        <div class="myaccount-box-header">
                            <h2>
                                Subscription</h2>
                        </div>
                        <div class="myaccount-box-middle">
                            <ul>
                                <li>Lorem ipsum dolor sit amet consectetur adipiscing.</li>
                                <li class="bullet-margin-top">Lorem ipsum dolor sit amet consectetur adipiscing.</li>
                                <li class="bullet-margin-top">Lorem ipsum dolor sit amet consectetur adipiscing.</li>
                                <li class="bullet-margin-top">Lorem ipsum dolor sit amet consectetur adipiscing.</li>
                            </ul>
                        </div>
                        <div class="myaccount-box-dowm">
                        </div>
                    </div>
                    <div class="myaccount-page-box-1">
                        <div class="myaccount-box-header">
                            <h2>
                                Subscription</h2>
                        </div>
                        <div class="myaccount-box-middle">
                            <ul>
                                <li>Lorem ipsum dolor sit amet consectetur adipiscing.</li>
                                <li class="bullet-margin-top">Lorem ipsum dolor sit amet consectetur adipiscing.</li>
                                <li class="bullet-margin-top">Lorem ipsum dolor sit amet consectetur adipiscing.</li>
                                <li class="bullet-margin-top">Lorem ipsum dolor sit amet consectetur adipiscing.</li>
                            </ul>
                        </div>
                        <div class="myaccount-box-dowm">
                        </div>
                    </div>
                    <div class="myaccount-buttons">
                        <div class="myaccount-butotn">
                        </div>
                        <div class="myaccount-butotn">
                        </div>
                    </div>
                </div>
                <!--............inner-middle..........-->
                <div class="content-block-right">
                    <div class="add-1">
                        <img src="images/add-1.jpg" alt="Live Chat" /></div>
                    <div class="add">
                        <img src="images/add-2.jpg" alt="What If You" /></div>
                    <div class="add">
                        <img src="images/add-3.jpg" alt="E Trade" /></div>
                </div>
            </div>
            <!--..................content-block................-->
            <div class="clear-div">
            </div>
        </div>
        </form>
    </body>
    </html>
</asp:Content>
