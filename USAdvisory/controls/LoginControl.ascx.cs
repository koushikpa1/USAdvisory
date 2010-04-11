using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.Users;
using DStreet.USAdvisory.Business.UI.Users.DAL;

public partial class controls_LoginControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        string username = txtLogin.Text;
        string password = txtPassword.Text;

        bool IsAuthorized = UsersDAL.IsAuthorizedUser(username, password);
        if (IsAuthorized)
        {
           
            Users user = UsersDAL.getUserByUserID(username);
            Session["UserName"] = user.UserId;
            Session["IsPaid"] = user.IsPaidSubscriber;
            Session["SubScriptionStart"] = user.SubscriptionStartDate;
            Session["SubScriptionEnd"] = user.SubscriptionEndDate;

            ControlLogin.Visible = false;
            lblWelcome.Text = "Welcome  " + (string)Session["UserName"] + "!";
            lblWelcome.EnableViewState = true;
           
            ControlUserInfo.Visible = true;


            
        }

    }
    protected void btnSingOut_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("MemberZone.aspx");
    }

    public void SetWelcomeNote(string name)
    {
        lblWelcome.Text = "Welcome  " + name + "!";
    }
}
