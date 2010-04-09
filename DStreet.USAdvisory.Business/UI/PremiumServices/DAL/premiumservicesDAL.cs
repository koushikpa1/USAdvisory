using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;
using DStreet.USAdvisory.Business.UI.PremiumServices;

namespace DStreet.USAdvisory.Business.UI.PremiumServices.DAL
{
    public static class premiumservicesDAL
    {
            /// <summary>
           /// 
           /// </summary>
           /// <returns></returns>
        public static List<PremiumServices> GetPremiumServicesByTradingType(int tradingType)
           {
               //DB Connection goes here

               List<PremiumServices> _article = new List<PremiumServices>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UI_GetPremiumServices";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               db.AddInParameter(dbCommand, "TypeOfTradeId", DbType.String, tradingType);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {
                    PremiumServices _premiumserviceslisting = new PremiumServices();
                   _premiumserviceslisting.ArticleId = Int32.Parse(dr["PremiumServiceId"].ToString());
                   _premiumserviceslisting.ArticleTitle = dr["PremiumServiceTitle"].ToString();
                   _premiumserviceslisting.ArticleDesc = dr["PremiumServiceDescription"].ToString();
                   _premiumserviceslisting.ArticleDate = DateTime.Parse(dr["PremiumServiceDate"].ToString());
                   _premiumserviceslisting.Ticker = dr["Ticker"].ToString();
                   _article.Add(_premiumserviceslisting);

               }
               return _article;
           }

        public static List<PremiumServices> GetLatestPremiumServicesByTradingType(int tradingType)
        {
            //DB Connection goes here

            List<PremiumServices> _article = new List<PremiumServices>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UI_GetLatestPremiumServices";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "TypeOfTradeId", DbType.String, tradingType);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                PremiumServices _premiumserviceslisting = new PremiumServices();
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
           public static PremiumServices GetPremiumServicesByArticle(int _premiumServicesId)
           {
               //DB Connection goes here

               PremiumServices _PremiumServicesListing = new PremiumServices();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UI_GetPremiumServicesByPremiumServiceId";
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
                   _PremiumServicesListing.ArticleDate = DateTime.Parse(dr["PremiumServiceDate"].ToString());
               }

               return _PremiumServicesListing;
           }

           public static int GetPremiumServicesArticleCount(int _premiumServicesId)
           {
               //DB Connection goes here
                       

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UI_GetArticleCountForToday";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               db.AddInParameter(dbCommand, "TypeOfTradeId", DbType.Int32, _premiumServicesId);

               // DataSet that will hold the returned results		
               DataSet DS = null;

               DS = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               string count = DS.Tables[0].Rows[0]["Count"].ToString();


               return Convert.ToInt32(count);
           }

       }
}

