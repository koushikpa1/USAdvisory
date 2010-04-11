using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using DStreet US Advisory Namespaces
using DStreet.USAdvisory.Business.Security;


public partial class admin_LogMeIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bt1_Click(object sender, EventArgs e)
    {

        AdminSecurity _adminSecurity = new AdminSecurity();

        if (_adminSecurity.IsValidAdminUser(txtlogin.Text.Trim(),txtpwd.Text.Trim()))
        {
            Session["admin"] = txtlogin.Text.Trim().ToString();
            Response.Redirect(@"Markets/Commentary/CommListing.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid UserName Or Password";
        }

    }
}
