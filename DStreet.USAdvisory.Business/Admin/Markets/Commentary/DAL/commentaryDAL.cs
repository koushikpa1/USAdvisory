using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;

namespace DStreet.USAdvisory.Business.Admin.Markets.Commentary.DAL
{
    public static class commentaryDAL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<commentarylisting> GetAllMarketCommentaries()
        {
            //DB Connection goes here

            List<commentarylisting> _article = new List<commentarylisting>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetAllMarketCommentaries";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                commentarylisting _commListing = new commentarylisting();
                _commListing.ArticleId = Int32.Parse(dr["MarketCommentaryId"].ToString());
                _commListing.ArticleTitle = dr["MarketCommentaryTitle"].ToString();
                _commListing.ArticleDesc = dr["MarketCommentaryDesc"].ToString();
                _commListing.ArticleDate = DateTime.Parse(dr["MarketCommentaryDateTime"].ToString());
                _article.Add(_commListing);
                
            }
            return _article;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterData"></param>
        /// <returns></returns>
        public static List<commentarylisting> FilterMarketCommentaryData(string filterData)
        {
            //DB Connection goes here

            List<commentarylisting> _article = new List<commentarylisting>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetAllMarketCommentaries";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            DataRow[] dataRow;


            dataRow = commentaryDataSet.Tables[0].Select("MarketCommentaryTitle LIKE '%" + filterData + "%'");

            // Note: connection was closed by ExecuteDataSet method call 

            foreach (DataRow dr in dataRow)
            {
                commentarylisting _commListing = new commentarylisting();
                _commListing.ArticleId = Int32.Parse(dr["MarketCommentaryId"].ToString());
                _commListing.ArticleTitle = dr["MarketCommentaryTitle"].ToString();
                _commListing.ArticleDesc = dr["MarketCommentaryDesc"].ToString();
                _commListing.ArticleDate = DateTime.Parse(dr["MarketCommentaryDateTime"].ToString());
                _article.Add(_commListing);

            }

            return _article;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="article"></param>
        public static void AddNewMarketCommentary(IArticle article)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "InsertMarketCommentary";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(commentaryCommand, "MarketCommentaryTitle", DbType.String, article.ArticleTitle);
            db.AddInParameter(commentaryCommand, "MarketCommentaryDesc", DbType.String, article.ArticleDesc);
            db.AddInParameter(commentaryCommand, "MarketCommentaryDateTime", DbType.DateTime, GlobalFunctions.GetCurrentTimeInEST());
            db.AddInParameter(commentaryCommand, "IsCommentaryActive", DbType.Boolean, article.IsActive);

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
        public static void UpdateMarketCommentary(IArticle article)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UpdateMarketCommentary";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);
            
            db.AddInParameter(commentaryCommand, "MarketCommentaryID", DbType.Int32, article.ArticleId);
            db.AddInParameter(commentaryCommand, "MarketCommentaryTitle", DbType.String, article.ArticleTitle);
            db.AddInParameter(commentaryCommand, "MarketCommentaryDesc", DbType.String, article.ArticleDesc);
            db.AddInParameter(commentaryCommand, "MarketCommentaryDateTime", DbType.DateTime, GlobalFunctions.GetCurrentTimeInEST());
            db.AddInParameter(commentaryCommand, "IsCommentaryActive", DbType.Boolean, article.IsActive);


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
        public static commentarylisting GetMarketCommentaryByArticle(int articleId)
        {
            //DB Connection goes here

            commentarylisting _commListing = new commentarylisting();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetMarketCommentaryByArticle";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            db.AddInParameter(dbCommand, "ArticleId", DbType.Int32, articleId);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                
                _commListing.ArticleTitle = dr["MarketCommentaryTitle"].ToString();
                _commListing.ArticleDesc = dr["MarketCommentaryDesc"].ToString();
                _commListing.IsActive = Boolean.Parse(dr["IsCommentaryActive"].ToString());
            }

            return _commListing;
        }

    }
}
