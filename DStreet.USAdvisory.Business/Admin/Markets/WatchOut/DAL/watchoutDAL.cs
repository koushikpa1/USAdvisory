using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;
namespace DStreet.USAdvisory.Business.Admin.Markets.WatchOut.DAL
{
    public static class watchoutDAL
    {
            /// <summary>
           /// 
           /// </summary>
           /// <returns></returns>
        public static List<watchoutlisting> GetAllWatchOutNews()
           {
               //DB Connection goes here

               List<watchoutlisting> _article = new List<watchoutlisting>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetAllWatchOutNews";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {
                   watchoutlisting _commListing = new watchoutlisting();
                   _commListing.ArticleId = Int32.Parse(dr["WatchOutId"].ToString());
                   _commListing.ArticleTitle = dr["WatchOuttitle"].ToString();
                   _commListing.ArticleDesc = dr["WatchOutText"].ToString();
                   _commListing.ArticleDate = DateTime.Parse(dr["WatchOutDateTime"].ToString());
                   _commListing.Ticker = dr["Ticker"].ToString();
                   _article.Add(_commListing);

               }
               return _article;
           }

           /// <summary>
           /// 
           /// </summary>
           /// <param name="filterData"></param>
           /// <returns></returns>
        public static List<watchoutlisting> GetWatchOutFilterData(string filterData)
           {
               //DB Connection goes here

               List<watchoutlisting> _article = new List<watchoutlisting>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetAllWatchOutNews";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               DataRow[] dataRow;

               dataRow = commentaryDataSet.Tables[0].Select("WatchOuttitle LIKE '%" + filterData + "%'");

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in dataRow)
               {
                   watchoutlisting _commListing = new watchoutlisting();
                   _commListing.ArticleId = Int32.Parse(dr["WatchOutId"].ToString());
                   _commListing.ArticleTitle = dr["WatchOuttitle"].ToString();
                   _commListing.ArticleDesc = dr["WatchOutText"].ToString();
                   _commListing.ArticleDate = DateTime.Parse(dr["WatchOutDateTime"].ToString());
                   _commListing.Ticker = dr["Ticker"].ToString();
                   _article.Add(_commListing);

               }

               return _article;
           }

           /// <summary>
           /// 
           /// </summary>
           /// <param name="article"></param>
           public static void AddWatchOutNews( string _articleTitle,DateTime _articleDateTime,string _articleDesc,bool _isPaid,string _ticker)
           {
               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "InsertWatchOutNews";
               DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

               db.AddInParameter(commentaryCommand, "WatchOuttitle", DbType.String, _articleTitle);
               db.AddInParameter(commentaryCommand, "WatchOutText", DbType.String, _articleDesc);
               db.AddInParameter(commentaryCommand, "WatchOutDateTime", DbType.DateTime, GlobalFunctions.GetCurrentTimeInEST());
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
           public static void UpdateWatchOutNews(int _watchOutId, string _articleTitle,string _articleDesc, bool _isPaid, string _ticker)
           {
               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UpdateWatchOutNews";
               DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

               db.AddInParameter(commentaryCommand, "WatchOutId", DbType.Int32, _watchOutId);
               db.AddInParameter(commentaryCommand, "WatchOutTitle", DbType.String, _articleTitle);
               db.AddInParameter(commentaryCommand, "WatchOutText", DbType.String, _articleDesc);
               db.AddInParameter(commentaryCommand, "WatchOutDateTime", DbType.DateTime, GlobalFunctions.GetCurrentTimeInEST());
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
           public static watchoutlisting GetWatchOutByArticle(int _articleId)
           {
               //DB Connection goes here

               watchoutlisting _commListing = new watchoutlisting();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetWatchOutNewsByArticle";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               db.AddInParameter(dbCommand, "WatchOutId", DbType.Int32, _articleId);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {

                   _commListing.ArticleTitle = dr["Watchouttitle"].ToString();
                   _commListing.ArticleDesc = dr["WatchOutText"].ToString();
                   _commListing.IsActive = Boolean.Parse(dr["IsPaid"].ToString());
                   _commListing.Ticker = dr["Ticker"].ToString();
               }

               return _commListing;
           }

       }
}
