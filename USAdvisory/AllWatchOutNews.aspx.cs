using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.Markets.WatchOut;

public partial class AllWatchOutNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //This is a sample checkin to GITHUB
        currentDate.Text = DateTime.Now.ToShortDateString();
        WatchOutNews _watchOut = new WatchOutNews();
        List<WatchOutNews> listWatchOut = new List<WatchOutNews>();
        listWatchOut = _watchOut.GetWatchOutNews();
        watchOutRepeater.DataSource = listWatchOut;
        watchOutRepeater.DataBind();

    }
}
