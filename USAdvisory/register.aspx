<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DStreetUS.master"
    CodeFile="register.aspx.cs" Inherits="register" %>

<%@ Register Src="Controls/Header.ascx" TagName="Header" TagPrefix="Header_uc" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <Header_uc:Header ID="header" runat="server" />
    <html xmlns="http://www.w3.org/1999/xhtml">
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
                        "<%=txtFirstName.UniqueID %>": {
                            required: true,
                            minlength: 3
                        },
                        "<%=txtLastName.UniqueID %>": {
                            required: true,
                            minlength: 3
                        },

                        "<%=txtUserId.UniqueID %>": {
                            required: true,                            
                            email: true
                        },
                        "<%=txtconfirmUserId.UniqueID %>": {
                            required: true,                            
                            equalTo: "input[name='<%=txtUserId.UniqueID %>']"
                        },
                        "<%=txtPhoneNumber.UniqueID %>": {
                            required: true,                            
                            phoneUS: true                           
                        },

                        "<%=txtPassword.UniqueID %>": {
                            required: true

                        },

                        "<%=txtConfirmPassword.UniqueID %>": {
                            required: true,
                            //equalTo: $('#<%= txtPassword.UniqueID %>').valueOf()
                            equalTo: "input[name='<%=txtPassword.UniqueID %>']"
                        }
                    },
                    messages: {
                        "<%=txtFirstName.UniqueID %>": "Enter your First Name",
                        "<%=txtLastName.UniqueID %>": "Enter your Last Name",
                        "<%=txtUserId.UniqueID %>": {
                        email: "Enter a valid email Id"
                        },
                        "<%=txtconfirmUserId.UniqueID %>": {
                            required: "Please re enter your User Id",
                            equalTo: "The User ids do not match"
                        },
                        "<%=txtPassword.UniqueID %>": "Enter a Password",
                        "<%=txtConfirmPassword.UniqueID %>": {
                            required: "Please re enter your Password",
                            equalTo: "The passwords do not match"
                        }


                    }
                });
            })
        </script>

        <style type="text/css">
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
           
        </style>
    </head>
    <body>
        <form id="form1" runat="server" action="" method="get">
        <div class="content-block">
            <!--............inner-middle..........-->
            <div class="inner-page-mid-block">
                <div class="register-box">
                    <div class="register-box-upper">
                        <h2>
                            Register with Market Watch</h2>
                    </div>
                    <div class="register-box-middle">
                        <form action="#" class="form-register">
                        <table width="320">
                            <tr>
                                <td style="width: 40%" style="font-weight: bold">
                                    First Name: *
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFirstName" runat="server" name="firstName" CssClass="textbox"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    Last Name: *
                                </td>
                                <td>
                                    <asp:TextBox ID="txtLastName" runat="server" CssClass="textbox" name="lastName"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    <label>
                                        User Id: *</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtUserId" runat="server" CssClass="textbox" name="userId"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    Confirm User Id *:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtconfirmUserId" runat="server" CssClass="textbox" name="confirmUserId"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    Password: *
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="textbox" name="password"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    Confirm Password: *
                                </td>
                                <td>
                                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="textbox" name="confirmPassword"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    Phone:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="textbox NumbersOnly" name="phoneNumber"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    Address:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAddress" runat="server" CssClass="textbox" name="address"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    State:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtState" runat="server" CssClass="textbox" name="state"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    Country:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCountry" runat="server" CssClass="textbox" name="country"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold">
                                    Zip:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtZip" runat="server" CssClass="textbox" name="zip"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_OnClick" Text="Register" />
                                </td>
                            </tr>
                        </table>
                        </form>
                    </div>
                    <div class="register-box-down">
                    </div>
                </div>
                <div class="register-page-subscription-box">
                    <div class="register-page-subscription-uper">
                        <h2>
                            Subscription</h2>
                    </div>
                    <div class="register-page-subscription-middle">
                        <ul>
                            <asp:RadioButtonList ID="lstRadioButton" runat="server" DataValueField="ID" DataTextField="SubscriptionTitle">
                            </asp:RadioButtonList>
                            <%--<li><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>
                            <li class="bullet-margin-top"><a href="#">Lorem ipsum dolor sit amet, consectetur.</a></li>--%>
                        </ul>
                        
                    </div>
                    <div class="register-page-subscription-down">
                    </div>
                </div>
                <div class="register-captcha-box">
                    <cc1:CaptchaControl ID="ccJoin" runat="server" CaptchaBackgroundNoise="High" CaptchaLength="5"
                        CaptchaHeight="60" CaptchaWidth="200" CaptchaLineNoise="High" CaptchaMinTimeout="5"
                        CaptchaMaxTimeout="240" /> <br />
                    <asp:TextBox ID="txtCaptcha" runat="server" CssClass="textbox"></asp:TextBox>
                    <%--<div class="register-captcha"></div>--%>
                </div>
                <%--<div class="register-button" onclick="btnRegister_OnClick" runat="server"><a href="#">Register</a></div>--%>
                <%--<asp:Button ID="btnRegister" Text="Register" runat="server" 
        CssClass="register-button" BorderStyle="Outset" 
        onclick="btnRegister_OnClick"  />--%>
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
        </form>
    </body>
    </html>
</asp:Content>
