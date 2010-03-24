using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using DStreet namespaces.
using DStreet.USAdvisory.Business.Admin;
using DStreet.USAdvisory.Business.Admin.Markets.Commentary;

public partial class admin_Markets_Commentary_EditMarketCommentary : System.Web.UI.Page
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
            commentaryedit _commEdit = new commentaryedit();
            IArticle article = _commEdit.GetMarketCommentaryByArticle(Int32.Parse(Request.QueryString["id"].ToString()));
            txtheader.Text = article.ArticleTitle;
            isActive.Checked = article.IsActive;
            fckcontent.Value = article.ArticleDesc;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isActive = false;

        if (isActive.Checked)
            _isActive = true;

        commentaryedit _commEdit = new commentaryedit(txtheader.Text, fckcontent.Value, DateTime.Now, _isActive);
        _commEdit.UpdateMarketCommentary(Int32.Parse(Request.QueryString["id"].ToString()));
        Response.Redirect("commlisting.aspx");
    }
}
