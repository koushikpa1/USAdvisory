using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.Markets.NewsViews;
using DStreet.USAdvisory.Business.UI.Users;

public partial class news : System.Web.UI.Page
{
    protected static string selectedArticleId = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Request.QueryString["SelId"] != null)
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
    public static string GetArticleDescription(int articleId)
    {

        NewsAndViews newsDescription = new NewsAndViews();
        newsDescription.ArticleId = articleId;
        newsDescription = newsDescription.GetAllNewsAndViewsById();


        //TO DO: Need to get the current login user.
        //Dummy data for the user. 
        Users usr = new Users();
        usr.IsPaidSubscriber = false;
        usr = null;
        string returnValue = string.Empty;
        if (newsDescription != null)
        {
            switch (newsDescription.IsPaid)
            {
                case 0:
                    returnValue = newsDescription.ArticleDesc;
                    break;
                case 1:
                    if (usr != null)
                    {
                        returnValue = "<B>" + newsDescription.ArticleTitle + "</B><br/>" + newsDescription.ArticleDesc;
                    }
                    //For free(unregistered users who have not logged in)
                    else
                    {
                        returnValue = "<B>" + newsDescription.ArticleTitle + "</B><br/>" + "<p><a href='login.html' style='color:Red'>" + newsDescription.Ticker + " - This information is available for Registered Users.<B>Register as a Free/Premium subscriber</a></B></P>";
                    }

                    break;
                case 2:
                    if (usr != null)
                    {
                        if (usr.IsPaidSubscriber)
                        {
                            returnValue = newsDescription.ArticleDesc;
                        }
                        else
                        {
                            returnValue = "<B>" + newsDescription.ArticleTitle + "</B><br/>" + "<p><a href='login.html' style='color:Red'>" + newsDescription.Ticker + " - This information is available for Registered Users. <B>Please upgrade Your Subscription.</a></B></P>";
                        }
                    }
                    else
                    {
                        returnValue = "<B>" + newsDescription.ArticleTitle + "</B><br/>" + "<p><a href='login.html' style='color:Red'>" + newsDescription.Ticker + " - This information is available for Registered Users. <B>Register as a Free/Premium subscriber</a></B></P>";
                    }
                    break;
            }

        }
        return returnValue;
    }


}


