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
                $("#<%=form1.ClientID%>").validate({
                    rules: {
                        "<%=txtFirstName.UniqueID %>": {
                            required: true,
                            minlength: 2
                        },
                        "<%=txtLastName.UniqueID %>": {
                            required: true,
                            minlength: 2
                        },

                        "<%=txtUserId.UniqueID %>": {
                            required: true,
                            minlength: 2
                        },
                        "<%=txtconfirmUserId.UniqueID %>": {
                            required: true,
                            minlength: 2,
                            equalTo: "#txtUserId"
                        },
                        "<%=txtPhoneNumber.UniqueID %>": {
                            required: true,
                            minlength: 2
                        },

                        "<%=txtPassword.UniqueID %>": {
                            required: true
                            
                        },

                        "<%=txtConfirmPassword.UniqueID %>": {
                        required: true,
                        //equalTo: $('#<%= txtPassword.UniqueID %>').valueOf()
                        equalTo: "#txtPassword"
                        }
                    },
                    messages: {
                        "<%=txtFirstName.UniqueID %>": "Enter your First Name",
                        "<%=txtLastName.UniqueID %>": "Enter your Last Name",
                        "<%=txtUserId.UniqueID %>": "Enter you User Id",
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
                float:  left;
                color: red;
                padding-left: .5em;
                vertical-align: top;                 
            }
        </style>

    </head>
    <body>
        <form id ="form1" runat="server" action="" method="get">
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
                        <table width="320" >
                            <tr>
                                <td style="width:40%">
                                    First Name: *
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFirstName" runat="server" name="firstName" CssClass="textbox"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Last Name: *
                                </td>
                                <td>
                                    <asp:TextBox ID="txtLastName" runat="server" CssClass="textbox" name="lastName"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>
                                        User Id: *</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtUserId" runat="server" CssClass="textbox" name="userId"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Confirm User Id *:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtconfirmUserId" runat="server" CssClass="textbox" name="confirmUserId"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Password: *
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="textbox" name="password"></asp:TextBox>
                                </td>
                            </tr>                            
                            <tr>
                                <td>
                                    Confirm Password: *
                                </td>
                                <td>
                                    <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="textbox" name="confirmPassword"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Phone:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="textbox NumbersOnly" name="phoneNumber"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Address:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAddress" runat="server" CssClass="textbox" name="address"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    State:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtState" runat="server" CssClass="textbox"  name="state"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Country:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCountry" runat="server" CssClass="textbox" name="country"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Zip:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtZip" runat="server" CssClass="textbox" name="zip"></asp:TextBox>
                                </td>
                            </tr> 
                            <tr>
                            <td><asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_OnClick" Text="Register" /></td>
                            
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
                        CaptchaMaxTimeout="240" />
                    
                    <asp:TextBox ID="txtCaptcha" runat="server"></asp:TextBox>
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