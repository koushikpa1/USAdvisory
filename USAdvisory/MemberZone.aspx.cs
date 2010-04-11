using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.PremiumServices;

public partial class MemberZone : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        UserAuthenticate();
        
        PremiumServices ps = new PremiumServices();
        int DayTradeCount = ps.GetPremiumServicesArticleCount(1);
        int PennyStocksCount = ps.GetPremiumServicesArticleCount(4);
        int ValueInvestingCount = ps.GetPremiumServicesArticleCount(3);

        lblDayTrade.Text = DayTradeCount + " Articles Updated Today";
        lblValueInvesting.Text = ValueInvestingCount + " Articles Updated Today";
        lblPennyStocks.Text = PennyStocksCount + " Articles Updated Today";
    }

    protected void UserAuthenticate()
    {

        if (Session["UserName"] != null)
        {
            if (Session["IsPaid"] != null)
            {
                bool Ispaid = (bool)Session["IsPaid"];
                if (!Ispaid)
                {
                    Response.Redirect("Subscriptions.aspx");
                }
            }
            Control control = header.FindControl("login");
            Control logindiv = control.FindControl("ControlLogin");
            Control welcomediv = control.FindControl("ControlUserInfo");
            Label labelName = (Label)welcomediv.FindControl("lblWelcome");
            labelName.Text = "Welcome " + (string)Session["UserName"] + "!";

            logindiv.Visible = false;
            welcomediv.Visible = true;
        }
        else
        {
            Response.Redirect("ContactUs.aspx");
        }

        
    }
}
