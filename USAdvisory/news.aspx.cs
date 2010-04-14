using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.Markets.NewsViews;

public partial class news : System.Web.UI.Page
{
    protected static string selectedArticleId = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(this.Request.QueryString["SelId"] != null)
        selectedArticleId = this.Request.QueryString["SelId"].ToString();
       
        NewsAndViews newsAndViews = new NewsAndViews();
        List<NewsAndViews> listNewsAndViews = newsAndViews.GetAllNewsAndViews();
        gvNewsAndViews.DataSource = listNewsAndViews;
        gvNewsAndViews.DataBind();

        NewsAndViews newsDescription = new NewsAndViews();
        if (!string.IsNullOrEmpty(selectedArticleId))
        {
            newsDescription.ArticleId = Convert.ToInt32(selectedArticleId);
        }
        else
        {
            newsDescription.ArticleId = listNewsAndViews[0].ArticleId;
            gvNewsAndViews.Rows[0].BackColor = System.Drawing.Color.FromName("#B0E0E6");
        }
        NewsAndViews newsDescription1 = new NewsAndViews();
        newsDescription1 = newsDescription.GetAllNewsAndViewsById();
        lblArticleDes.Text = newsDescription1.ArticleDesc;
        
            
    }

    protected void gvPageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        gvNewsAndViews.PageIndex = e.NewPageIndex;
        gvNewsAndViews.DataBind();

        NewsAndViews newsDescription = new NewsAndViews();
        lblArticleDes.Text = newsDescription.GetAllNewsAndViews()[e.NewPageIndex * 10].ArticleDesc;

        UpdatePanel2.Update();
    }

    protected void RowDataBound(object sender, GridViewRowEventArgs args)
    {
        if (args.Row.RowType == DataControlRowType.DataRow)
        {
            
            NewsAndViews selNews = args.Row.DataItem as NewsAndViews;
            args.Row.Attributes.Add("onClick", "userSelected('" + selNews.ArticleId + "')");
            
            if (!string.IsNullOrEmpty(selectedArticleId) && selNews.ArticleId.Equals(Convert.ToInt32(selectedArticleId)))
                args.Row.BackColor = System.Drawing.Color.FromName("#B0E0E6");
            
        }
    }

    [System.Web.Services.WebMethod]
    public static string GetArticleDescription (int articleId)
    {
                
        NewsAndViews newsDescription = new NewsAndViews();
        newsDescription.ArticleId = articleId;
        string desc = null;
        desc = newsDescription.GetAllNewsAndViewsById().ArticleDesc;
        return desc;
    }

}
