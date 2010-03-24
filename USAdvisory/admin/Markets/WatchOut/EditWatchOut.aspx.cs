using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Markets.WatchOut;

public partial class admin_Markets_WatchOut_EditWatchOut : System.Web.UI.Page
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            watchoutedit _watchEdit = new watchoutedit();
            watchoutlisting _listing = new watchoutlisting();
            _listing = _watchEdit.GetWatchOutByArticle(Int32.Parse(Request.QueryString["id"].ToString()));
            txtheader.Text = _listing.ArticleTitle;
            isPaid.Checked = _listing.IsPaid;
            fckcontent.Value = _listing.ArticleDesc;
            txtTicker.Text = _listing.Ticker;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isPaid = false;

        if (isPaid.Checked)
            _isPaid = true;

        watchoutedit _commEdit = new watchoutedit(txtheader.Text, fckcontent.Value, DateTime.Now,_isPaid,txtTicker.Text);
        _commEdit.UpdateWatchOutNews(Int32.Parse(Request.QueryString["id"].ToString()));
        Response.Redirect("watchoutlisting.aspx");
    }
}
