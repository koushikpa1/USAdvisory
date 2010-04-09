using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DStreet.USAdvisory.Business.UI.PremiumServices;

public partial class DayTradingSwingTrading : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PremiumServices ps = new PremiumServices();
        List<PremiumServices> list = ps.GetLatestPremiumServicesUI(1);

        GridView_DaySwingTrading.DataSource = list;
        GridView_DaySwingTrading.DataBind();

        PremiumServices ps1 = new PremiumServices();
        List<PremiumServices> list1 = ps1.GetPremiumServicesUI(1);

        GridViewArchive_DaySwingTrading.DataSource = list1;
        GridViewArchive_DaySwingTrading.DataBind();

    }

    

    protected void CustomersGridView_RowDataBound(Object sender, GridViewRowEventArgs e)
    {

          // Display the company name in italics.
        //int j = 10;
        //for (int i = 9; i >=3; i--)
        //{
        //    e.Row.Cells.Remove(e.Row.Cells[i]);
            
        //}

        

    }


    protected void ArchivePageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        GridViewArchive_DaySwingTrading.PageIndex = e.NewPageIndex;
        GridViewArchive_DaySwingTrading.DataBind();
    }
}
