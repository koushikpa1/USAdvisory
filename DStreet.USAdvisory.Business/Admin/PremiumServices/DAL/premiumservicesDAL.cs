using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;
using DStreet.USAdvisory.Business.Admin.PremiumServices;

namespace DStreet.USAdvisory.Business.Admin.PremiumServices.DAL
{
    public static class premiumservicesDAL
    {
            /// <summary>
           /// 
           /// </summary>
           /// <returns></returns>
        public static List<premiumserviceslisting> GetAllPremiumServices(int tradingType)
           {
               //DB Connection goes here

               List<premiumserviceslisting> _article = new List<premiumserviceslisting>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetPremiumServices";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               db.AddInParameter(dbCommand, "TypeOfTradeId", DbType.String, tradingType);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {
                   premiumserviceslisting _premiumserviceslisting = new premiumserviceslisting();
                   _premiumserviceslisting.ArticleId = Int32.Parse(dr["PremiumServiceId"].ToString());
                   _premiumserviceslisting.ArticleTitle = dr["PremiumServiceTitle"].ToString();
                   _premiumserviceslisting.ArticleDesc = dr["PremiumServiceDescription"].ToString();
                   _premiumserviceslisting.ArticleDate = DateTime.Parse(dr["PremiumServiceDate"].ToString());
                   _premiumserviceslisting.Ticker = dr["Ticker"].ToString();
                   _article.Add(_premiumserviceslisting);

               }
               return _article;
           }

           /// <summary>
           /// 
           /// </summary>
           /// <param name="filterData"></param>
           /// <returns></returns>
        public static List<premiumserviceslisting> GetPremiumServicesFilterData(string filterData, int tradingType)
           {
               //DB Connection goes here

               List<premiumserviceslisting> _article = new List<premiumserviceslisting>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetPremiumServices";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               db.AddInParameter(dbCommand, "TypeOfTradeId", DbType.Int32, tradingType);

               // Retrieve products from the specified category.
               //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               DataRow[] dataRow;

               dataRow = commentaryDataSet.Tables[0].Select("PremiumServiceTitle LIKE '%" + filterData + "%'");

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in dataRow)
               {
                   premiumserviceslisting _commListing = new premiumserviceslisting();
                   _commListing.ArticleId = Int32.Parse(dr["PremiumServiceId"].ToString());
                   _commListing.ArticleTitle = dr["PremiumServiceTitle"].ToString();
                   _commListing.ArticleDesc = dr["PremiumServiceDescription"].ToString();
                   _commListing.ArticleDate = DateTime.Parse(dr["PremiumServiceDate"].ToString());
                   _commListing.Ticker = dr["Ticker"].ToString();
                   _article.Add(_commListing);

               }

               return _article;
           }

           /// <summary>
           /// 
           /// </summary>
           /// <param name="article"></param>
        public static void AddPremiumServices(string _articleTitle, DateTime _articleDateTime, string _articleDesc,bool _isActive, bool _isPaid, string _ticker, TradingType tradeType)
           {
               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "InsertPremiumServices";
               DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

               db.AddInParameter(commentaryCommand, "PremiumServiceTitle", DbType.String, _articleTitle);
               db.AddInParameter(commentaryCommand, "PremiumServiceDescription", DbType.String, _articleDesc);
               db.AddInParameter(commentaryCommand, "PremiumServiceDateTime", DbType.DateTime, GlobalFunctions.GetCurrentTimeInEST());
               db.AddInParameter(commentaryCommand, "IsActive", DbType.Boolean, _isActive);
               db.AddInParameter(commentaryCommand, "IsPaid", DbType.Boolean, _isPaid);
               db.AddInParameter(commentaryCommand, "Ticker", DbType.String, _ticker);
               db.AddInParameter(commentaryCommand, "TypeOfTradeId", DbType.String, Convert.ToInt32(tradeType));

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
        public static void UpdatePremiumServices(int _premiumServiceId, string _articleTitle, string _articleDesc, bool _isActive, bool _isPaid, string _ticker, TradingType tradeType)
           {
               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UpdatePremiumServices";
               DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

               db.AddInParameter(commentaryCommand, "PremiumServiceId", DbType.Int32, _premiumServiceId);
               db.AddInParameter(commentaryCommand, "PremiumServiceTitle", DbType.String, _articleTitle);
               db.AddInParameter(commentaryCommand, "PremiumServiceDescription", DbType.String, _articleDesc);
               db.AddInParameter(commentaryCommand, "PremiumServiceDateTime", DbType.DateTime, GlobalFunctions.GetCurrentTimeInEST());
               db.AddInParameter(commentaryCommand, "IsActive", DbType.Boolean, _isActive);
               db.AddInParameter(commentaryCommand, "IsPaid", DbType.Boolean, _isPaid);
               db.AddInParameter(commentaryCommand, "Ticker", DbType.String, _ticker);
               db.AddInParameter(commentaryCommand, "TypeOfTradeId", DbType.String, Convert.ToInt32(tradeType));


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
           public static premiumserviceslisting GetPremiumServicesByArticle(int _premiumServicesId)
           {
               //DB Connection goes here

               premiumserviceslisting _PremiumServicesListing = new premiumserviceslisting();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetPremiumServiceByArticle";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               db.AddInParameter(dbCommand, "PremiumServiceId", DbType.Int32, _premiumServicesId);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {

                   _PremiumServicesListing.ArticleTitle = dr["PremiumServiceTitle"].ToString();
                   _PremiumServicesListing.ArticleDesc = dr["PremiumServiceDescription"].ToString();
                   _PremiumServicesListing.IsActive = Boolean.Parse(dr["IsActive"].ToString());
                   _PremiumServicesListing.IsPaid = Boolean.Parse(dr["IsPaid"].ToString());
                   _PremiumServicesListing.Ticker = dr["Ticker"].ToString();
               }

               return _PremiumServicesListing;
           }

       }
}

