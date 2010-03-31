
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;


namespace DStreet.USAdvisory.Business.UI.Markets.NewsViews.DAL
{
    public static class newsviewsDAL
    {
            /// <summary>
           /// 
           /// </summary>
           /// <returns></returns>
        public static List<NewsAndViews> GetAllNewsViews()
           {
               //DB Connection goes here

               List<NewsAndViews> _article = new List<NewsAndViews>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UI_GetAllNewsViews";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {
                   NewsAndViews _newsviewsListing = new NewsAndViews();
                   _newsviewsListing.ArticleId = Int32.Parse(dr["NewsId"].ToString());
                   _newsviewsListing.ArticleTitle = dr["NewsTitle"].ToString();
                   _newsviewsListing.ArticleDesc = dr["NewsDescription"].ToString();
                   _newsviewsListing.ArticleDate = DateTime.Parse(dr["Newsdatetime"].ToString());
                   _newsviewsListing.Ticker = dr["Ticker"].ToString();
                   _newsviewsListing.IsPaid = bool.Parse(dr["IsPaid"].ToString());
                   _article.Add(_newsviewsListing);

               }
               return _article;
           }

       
           /// <summary>
           /// 
           /// </summary>
           public static NewsAndViews GetNewsViewsByArticle(int _newsId)
           {
               //DB Connection goes here

               NewsAndViews _newsviewsListing = new NewsAndViews();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UI_GetNewsViewsByNewsId";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               db.AddInParameter(dbCommand, "NewsId", DbType.Int32, _newsId);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               DataRow dr = commentaryDataSet.Tables[0].Rows[0];              
                   
               _newsviewsListing.ArticleId = Int32.Parse(dr["NewsId"].ToString());
               _newsviewsListing.ArticleTitle = dr["NewsTitle"].ToString();
               _newsviewsListing.ArticleDesc = dr["NewsDescription"].ToString();
               _newsviewsListing.ArticleDate = DateTime.Parse(dr["Newsdatetime"].ToString());
               _newsviewsListing.Ticker = dr["Ticker"].ToString();
               _newsviewsListing.IsPaid = bool.Parse(dr["IsPaid"].ToString());

               return _newsviewsListing;
           }

       }
}

