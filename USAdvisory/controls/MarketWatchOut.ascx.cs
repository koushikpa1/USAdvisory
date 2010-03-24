using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.Markets.WatchOut;


public partial class controls_MarketWatchOut : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WatchOutNews _watchOut = new WatchOutNews();
        List<WatchOutNews> listWatchOut = new List<WatchOutNews>();
        listWatchOut = _watchOut.GetWatchOutNews();
        //Remove all other News Wire data above 4 records. 
        //TO DO : Try to configure the number of records to display in web.config
        if (listWatchOut.Count > 4)
            listWatchOut.RemoveRange(4, listWatchOut.Count - 4);
        watchOutRepeater.DataSource = listWatchOut;
        watchOutRepeater.DataBind();

    }
}
