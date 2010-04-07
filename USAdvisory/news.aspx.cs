using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.Markets.NewsViews;

public partial class news : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NewsAndViews newsAndViews = new NewsAndViews();
        List<NewsAndViews> listNewsAndViews = newsAndViews.GetAllNewsAndViews();
        gvNewsAndViews.DataSource = listNewsAndViews;
        gvNewsAndViews.DataBind();

        NewsAndViews newsDescription = new NewsAndViews();
        newsDescription.ArticleId = 1;
        NewsAndViews newsDescription1 = new NewsAndViews();
        newsDescription1 = newsDescription.GetAllNewsAndViewsById();
        lblArticleDes.Text = newsDescription1.ArticleDesc;
            
    }

    protected void gvPageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        gvNewsAndViews.PageIndex = e.NewPageIndex;
                      
        gvNewsAndViews.DataBind();
    }

    

    protected void RowDataBound(object sender, GridViewRowEventArgs args)
    {
        if (args.Row.RowType == DataControlRowType.DataRow)
        {
            NewsAndViews selNews = args.Row.DataItem as NewsAndViews;
            args.Row.Attributes.Add("onClick", "userSelected('" + selNews.ArticleId + "')");
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
