using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.PremiumServices;

public partial class ValueInvesting : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PremiumServices ps = new PremiumServices();
        List<PremiumServices> list = ps.GetLatestPremiumServicesUI(3);

        GridView_ValueInvesting.DataSource = list;
        GridView_ValueInvesting.DataBind();

        PremiumServices ps1 = new PremiumServices();
        List<PremiumServices> list1 = ps1.GetPremiumServicesUI(4);

        GridViewArchive_ValueInvesting.DataSource = list1;
        GridViewArchive_ValueInvesting.DataBind();
    }
    protected void ArchivePageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        GridViewArchive_ValueInvesting.PageIndex = e.NewPageIndex;
        GridViewArchive_ValueInvesting.DataBind();
    }
}
