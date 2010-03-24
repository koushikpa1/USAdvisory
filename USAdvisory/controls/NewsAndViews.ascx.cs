using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DStreet.USAdvisory.Business.UI.Markets.NewsViews;

public partial class controls_NewsAndViews : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NewsAndViews newsAndViews = new NewsAndViews();
        List<NewsAndViews> listWatchOut = new List<NewsAndViews>();
        listWatchOut = newsAndViews.GetAllNewsAndViews();
        //Remove all other News Wire data above 5 records. 
        //TO DO : Try to configure the number of records to display in web.config
        if (listWatchOut.Count > 7)
            listWatchOut.RemoveRange(6, listWatchOut.Count - 7);
        NewsandViewsRepeater.DataSource = listWatchOut;
        NewsandViewsRepeater.DataBind();

    }
}
