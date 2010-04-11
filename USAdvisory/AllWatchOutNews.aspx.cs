using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.Markets.WatchOut;
using DStreet.USAdvisory.Business.UI.Users;

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
    protected string IsPaidNews(bool isPaidNews,string articleDesc,string articleTicker)
    {
        //TO DO: Need to get the current login user.
        //Dummy data for the user. 
        Users usr = new Users();
        usr.IsPaidSubscriber= false;
        if (isPaidNews)
        {
            if (usr.IsPaidSubscriber)
                return articleDesc;
            else
                return "<p>" + articleTicker + "</P>";
        }

        return articleDesc;
    }
}
