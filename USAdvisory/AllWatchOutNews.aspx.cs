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
    protected string IsPaidNews(short isPaidNews,string articleDesc,string articleTicker)
    {
        //TO DO: Need to get the current login user.
        //Dummy data for the user. 
        Users usr = new Users();
        usr.IsPaidSubscriber= true;
        usr = null;
        string returnValue = string.Empty;
        switch (isPaidNews)
        {
            case 0:
                returnValue = articleDesc;
                break;
            case 1:
                if (usr != null)
                {
                    returnValue = articleDesc;
                }
                //For free(unregistered users who have not logged in)
                else
                {
                    returnValue = "<p>" + articleTicker + " - This information is available for Registered Users (Free).<B> <a href='register.aspx' style='color:Red'>Click here</a></B> to Register Link</P>";
                }

                break;
            case 2:
                if (usr != null)
                {
                    if (usr.IsPaidSubscriber)
                    {
                        returnValue = articleDesc;
                    }
                    else
                    {
                        returnValue = "<p>" + articleTicker + " - This information is available for Registered Users (Premium).<B> <a href='Subscriptions.aspx' style='color:Red'>Click here</a></B> to Upgrade membership</P>";
                    }
                }
                else
                {
                    returnValue = "<p>" + articleTicker + " - This information is available for Registered Users (Premium).<B> <a href='register.aspx' style='color:Red'>Click here</a></B> to Register Link</P>";
                }
                break;
        }

        return returnValue;
    }
}
