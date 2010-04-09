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
using System.Collections.Generic;
using DStreet.USAdvisory.Business.UI.Performances;
public partial class Performance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
