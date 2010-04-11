using System;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Collections.Generic;
using DStreet.USAdvisory.Business.UI.Performances;

public partial class Performance : System.Web.UI.Page
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


        Performances ps = new Performances();
        List<Performances> list = ps.GetPerformances();

        GridView_Performance.DataSource = list;
        GridView_Performance.DataBind();
        
    }
    protected void GridView_Performance_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView_Performance.PageIndex = e.NewPageIndex;
        GridView_Performance.DataBind();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView_Performance.PageSize = Convert.ToInt32(DropDownList1.SelectedValue);
        GridView_Performance.DataBind();
    }
}
