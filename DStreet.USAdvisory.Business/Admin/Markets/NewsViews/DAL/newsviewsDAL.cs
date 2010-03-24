
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;


namespace DStreet.USAdvisory.Business.Admin.Markets.NewsViews.DAL
{
    public static class newsviewsDAL
    {
            /// <summary>
           /// 
           /// </summary>
           /// <returns></returns>
        public static List<newsviewslisting> GetAllNewsViews()
           {
               //DB Connection goes here

               List<newsviewslisting> _article = new List<newsviewslisting>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetAllNewsAndViews";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {
                    newsviewslisting _newsviewsListing = new newsviewslisting();
                   _newsviewsListing.ArticleId = Int32.Parse(dr["NewsId"].ToString());
                   _newsviewsListing.ArticleTitle = dr["NewsTitle"].ToString();
                   _newsviewsListing.ArticleDesc = dr["NewsDescription"].ToString();
                   _newsviewsListing.ArticleDate = DateTime.Parse(dr["Newsdatetime"].ToString());
                   _newsviewsListing.Ticker = dr["Ticker"].ToString();
                   _article.Add(_newsviewsListing);

               }
               return _article;
           }

           /// <summary>
           /// 
           /// </summary>
           /// <param name="filterData"></param>
           /// <returns></returns>
        public static List<newsviewslisting> GetNewsViewsFilterData(string filterData)
           {
               //DB Connection goes here

               List<newsviewslisting> _article = new List<newsviewslisting>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetAllNewsAndViews";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               DataRow[] dataRow;

               dataRow = commentaryDataSet.Tables[0].Select("NewsTitle LIKE '%" + filterData + "%'");

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in dataRow)
               {
                   newsviewslisting _commListing = new newsviewslisting();
                   _commListing.ArticleId = Int32.Parse(dr["NewsId"].ToString());
                   _commListing.ArticleTitle = dr["NewsTitle"].ToString();
                   _commListing.ArticleDesc = dr["NewsDescription"].ToString();
                   _commListing.ArticleDate = DateTime.Parse(dr["Newsdatetime"].ToString());
                   _commListing.Ticker = dr["Ticker"].ToString();
                   _article.Add(_commListing);

               }

               return _article;
           }

           /// <summary>
           /// 
           /// </summary>
           /// <param name="article"></param>
        public static void AddNewsViews(string _articleTitle, DateTime _articleDateTime, string _articleDesc,bool _isActive, bool _isPaid, string _ticker)
           {
               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "InsertNewsViews";
               DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

               db.AddInParameter(commentaryCommand, "NewsTitle", DbType.String, _articleTitle);
               db.AddInParameter(commentaryCommand, "NewsDescription", DbType.String, _articleDesc);
               db.AddInParameter(commentaryCommand, "Newsdatetime", DbType.DateTime, GlobalFunctions.GetCurrentTimeInEST());
               db.AddInParameter(commentaryCommand, "IsActive", DbType.Boolean, _isActive);
               db.AddInParameter(commentaryCommand, "IsPaid", DbType.Boolean, _isPaid);
               db.AddInParameter(commentaryCommand, "Ticker", DbType.String, _ticker);

               using (DbConnection connection = db.CreateConnection())
               {
                   connection.Open();
                   db.ExecuteNonQuery(commentaryCommand);
                   connection.Close();
               }
           }

           /// <summary>
           /// 
           /// </summary>
           /// <param name="article"></param>
        public static void UpdateNewsViews(int _watchOutId, string _articleTitle, string _articleDesc,bool _isActive, bool _isPaid, string _ticker)
           {
               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UpdateNewsAndViews";
               DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

               db.AddInParameter(commentaryCommand, "NewsId", DbType.Int32, _watchOutId);
               db.AddInParameter(commentaryCommand, "NewsTitle", DbType.String, _articleTitle);
               db.AddInParameter(commentaryCommand, "NewsDescription", DbType.String, _articleDesc);
               db.AddInParameter(commentaryCommand, "Newsdatetime", DbType.DateTime, GlobalFunctions.GetCurrentTimeInEST());
               db.AddInParameter(commentaryCommand, "IsActive", DbType.Boolean, _isActive);
               db.AddInParameter(commentaryCommand, "IsPaid", DbType.Boolean, _isPaid);
               db.AddInParameter(commentaryCommand, "Ticker", DbType.String, _ticker);


               using (DbConnection connection = db.CreateConnection())
               {
                   connection.Open();
                   db.ExecuteNonQuery(commentaryCommand);
                   connection.Close();
               }

           }
           /// <summary>
           /// 
           /// </summary>
           public static newsviewslisting GetNewsViewsByArticle(int _newsId)
           {
               //DB Connection goes here

               newsviewslisting _newsViewsListing = new newsviewslisting();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetNewsAndViewsByArticle";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               db.AddInParameter(dbCommand, "NewsId", DbType.Int32, _newsId);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {

                   _newsViewsListing.ArticleTitle = dr["NewsTitle"].ToString();
                   _newsViewsListing.ArticleDesc = dr["NewsDescription"].ToString();
                   _newsViewsListing.IsActive = Boolean.Parse(dr["IsActive"].ToString());
                   _newsViewsListing.IsPaid = Boolean.Parse(dr["IsPaid"].ToString());
                   _newsViewsListing.Ticker = dr["Ticker"].ToString();
               }

               return _newsViewsListing;
           }

       }
}

