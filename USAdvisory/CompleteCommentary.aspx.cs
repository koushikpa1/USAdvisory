using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.Markets.WatchOut;
using DStreet.USAdvisory.Business.UI.Markets.Commentary;

public partial class AllWatchOutNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        MarketCommentary _commentary = new MarketCommentary();
        _commentary = _commentary.GetLatestMarketCommentary();
        if (!string.IsNullOrEmpty(_commentary.MarketCommentaryTitle))
        {
            CommentaryHeader.Text = _commentary.MarketCommentaryTitle + "&nbsp;&nbsp;" + _commentary.MarketCommentaryDateTime.ToShortDateString();
            CommentaryDesc.Text = _commentary.MarketCommentaryDecription;

        }

    }
}
