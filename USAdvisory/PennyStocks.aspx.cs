using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.PremiumServices;

public partial class PennyStocks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PremiumServices ps = new PremiumServices();
        List<PremiumServices> list = ps.GetLatestPremiumServicesUI(4);

        GridView_PennyStocks.DataSource = list;
        GridView_PennyStocks.DataBind();

        PremiumServices ps1 = new PremiumServices();
        List<PremiumServices> list1 = ps1.GetPremiumServicesUI(4);

        GridViewArchive_PennyStocks.DataSource = list1;
        GridViewArchive_PennyStocks.DataBind();
    }

    protected void ArchivePageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        GridViewArchive_PennyStocks.PageIndex = e.NewPageIndex;
        GridViewArchive_PennyStocks.DataBind();
    }
}
