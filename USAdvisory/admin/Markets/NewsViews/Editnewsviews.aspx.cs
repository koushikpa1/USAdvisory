using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Markets.NewsViews;

public partial class admin_Markets_NewsViews_Editnewsviews : System.Web.UI.Page
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
            newsviewsedit _watchEdit = new newsviewsedit();
            newsviewslisting _listing = new newsviewslisting();
            _listing = _watchEdit.GetNewsViewsByArticle(Int32.Parse(Request.QueryString["id"].ToString()));
            txtheader.Text = _listing.ArticleTitle;
            isPaid.Checked = _listing.IsPaid;
            isActive.Checked = _listing.IsActive;
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

        bool _isActive = false;

        if (isActive.Checked)
            _isActive = true;


        newsviewsedit _newsviewsEdit = new newsviewsedit(txtheader.Text, fckcontent.Value, DateTime.Now, _isActive,_isPaid, txtTicker.Text);
        _newsviewsEdit.UpdateNewsViews(Int32.Parse(Request.QueryString["id"].ToString()));
        Response.Redirect("Newsviewslisting.aspx");
    }
}
