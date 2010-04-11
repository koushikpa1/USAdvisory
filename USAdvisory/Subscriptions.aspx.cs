using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Subscriptions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            Control control = header.FindControl("login");
            Control logindiv = control.FindControl("ControlLogin");
            Control welcomediv = control.FindControl("ControlUserInfo");
            Label labelName = (Label)welcomediv.FindControl("lblWelcome");
            labelName.Text = "Welcome " + (string)Session["UserName"] + "!";

            logindiv.Visible = false;
            welcomediv.Visible = true;
        }
    }
}
