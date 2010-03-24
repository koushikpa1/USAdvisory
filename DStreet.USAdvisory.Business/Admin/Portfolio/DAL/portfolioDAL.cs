using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;

namespace DStreet.USAdvisory.Business.Admin.Portfolio.DAL
{
    public class portfolioDAL
    {
    
       public static List<portfoliolisting> GetAllPortfolio()
           {
               //DB Connection goes here

               List<portfoliolisting> _article = new List<portfoliolisting>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetAllPortfolio";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);


               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {
                    portfoliolisting _portfoliolisting = new portfoliolisting();
                   _portfoliolisting.StockTransactionId = Int32.Parse(dr["StockTransactionId"].ToString());
                   _portfoliolisting.Ticker = dr["StockTicker"].ToString();
                   _portfoliolisting.CallStatus = char.Parse(dr["CallStatus"].ToString());
                   _portfoliolisting.IsPartiallyExited = Boolean.Parse(dr["IsPartiallyExited"].ToString());
                   _portfoliolisting.PortfolioEntryDate = DateTime.Parse(dr["PortfolioEntryDate"].ToString());
                   _portfoliolisting.PortfolioExitDate = DateTime.Parse(dr["PortfolioExitDate"].ToString());
                   _portfoliolisting.PortfolioId = Int32.Parse(dr["PortfolioId"].ToString());
                   _article.Add(_portfoliolisting);
               }

               return _article;
           }

           /// <summary>
           /// 
           /// </summary>
           /// <param name="filterData"></param>
           /// <returns></returns>
       public static List<portfoliolisting> GetPortfolioFilterData(string filterData)
           {
               //DB Connection goes here

               List<portfoliolisting> _article = new List<portfoliolisting>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "GetAllPortfolio";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               DataRow[] dataRow;

               dataRow = commentaryDataSet.Tables[0].Select("StockTicker LIKE '%" + filterData + "%'");

               // Note: connection was closed by ExecuteDataSet method call 


               foreach (DataRow dr in dataRow)
               {
                   portfoliolisting _portfoliolisting = new portfoliolisting();
                   _portfoliolisting.StockTransactionId = Int32.Parse(dr["StockTransactionId"].ToString());
                   _portfoliolisting.Ticker = dr["StockTicker"].ToString();
                   _portfoliolisting.CallStatus = char.Parse(dr["CallStatus"].ToString());
                   _portfoliolisting.IsPartiallyExited = Boolean.Parse(dr["IsPartiallyExited"].ToString());
                   _portfoliolisting.PortfolioEntryDate = DateTime.Parse(dr["PortfolioEntryDate"].ToString());
                   _portfoliolisting.PortfolioExitDate = DateTime.Parse(dr["PortfolioExitDate"].ToString());
                   _portfoliolisting.PortfolioId = Int32.Parse(dr["PortfolioId"].ToString());
                   _article.Add(_portfoliolisting);
               }


               return _article;
           }

       /// 
       /// </summary>
       /// <param name="article"></param>
       public static void AddPortfolio(DStreet.USAdvisory.Business.Admin.Portfolio.IPortfolio portfolio)
       {
           // Create the Database object, using the default database service. The
           // default database service is determined through configuration.
           Database db = DatabaseFactory.CreateDatabase();

           string sqlCommand = "InsertPortfolio";
           DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

           // GlobalFunctions.GetCurrentTimeInEST()

           db.AddInParameter(commentaryCommand, "PortfolioId", DbType.Int32, portfolio.PortfolioId);
           db.AddInParameter(commentaryCommand, "CompanyName", DbType.String, portfolio.CompanyName.Trim());
           db.AddInParameter(commentaryCommand, "StockTicker", DbType.String, portfolio.StockTicker.Trim());
           db.AddInParameter(commentaryCommand, "BuyOrSellId", DbType.Int32, portfolio.BuyOrSellId);
           db.AddInParameter(commentaryCommand, "Qty", DbType.Int32, portfolio.Qty);
           db.AddInParameter(commentaryCommand, "EntryPrice", DbType.Decimal, portfolio.EntryPrice);
           db.AddInParameter(commentaryCommand, "ExitPrice", DbType.Decimal, portfolio.ExitPrice);
           db.AddInParameter(commentaryCommand, "StopLoss", DbType.Decimal, portfolio.StopLoss);
           db.AddInParameter(commentaryCommand, "Updates", DbType.String, portfolio.Updates.Trim());
           db.AddInParameter(commentaryCommand, "UpdateDateTime", DbType.String, GlobalFunctions.GetCurrentTimeInEST());
           db.AddInParameter(commentaryCommand, "PortfolioEntryDate", DbType.DateTime,  GlobalFunctions.GetCurrentTimeInEST());
           db.AddInParameter(commentaryCommand, "PortfolioExitDate", DbType.DateTime,  portfolio.PortfolioExitDate);
           db.AddInParameter(commentaryCommand, "CallStatus", DbType.String, portfolio.CallStatus);
           db.AddInParameter(commentaryCommand, "IsPartiallyExited", DbType.Boolean, portfolio.IsPartiallyExited);

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
       public static void UpdatePortfolio(IPortfolio portfolio)
       {
           // Create the Database object, using the default database service. The
           // default database service is determined through configuration.
           Database db = DatabaseFactory.CreateDatabase();

           string sqlCommand = "UpdatePortfolio";
           DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

           db.AddInParameter(commentaryCommand, "StockTransactionId", DbType.Int32, portfolio.StockTransactionId);
           db.AddInParameter(commentaryCommand, "PortfolioId", DbType.Int32, portfolio.PortfolioId);
           db.AddInParameter(commentaryCommand, "CompanyName", DbType.String, portfolio.CompanyName);
           db.AddInParameter(commentaryCommand, "StockTicker", DbType.String, portfolio.StockTicker);
           db.AddInParameter(commentaryCommand, "BuyOrSellId", DbType.Int32, portfolio.BuyOrSellId);
           db.AddInParameter(commentaryCommand, "Qty", DbType.Int32, portfolio.Qty);
           db.AddInParameter(commentaryCommand, "EntryPrice", DbType.Decimal, portfolio.EntryPrice);
           db.AddInParameter(commentaryCommand, "ExitPrice", DbType.Decimal, portfolio.ExitPrice);
           db.AddInParameter(commentaryCommand, "StopLoss", DbType.Decimal, portfolio.StopLoss);
           db.AddInParameter(commentaryCommand, "Updates", DbType.String, portfolio.Updates);
           db.AddInParameter(commentaryCommand, "UpdateDateTime", DbType.String, GlobalFunctions.GetCurrentTimeInEST());
           db.AddInParameter(commentaryCommand, "PortfolioEntryDate", DbType.DateTime, portfolio.PortfolioExitDate);
           db.AddInParameter(commentaryCommand, "PortfolioExitDate", DbType.DateTime, portfolio.PortfolioExitDate);
           db.AddInParameter(commentaryCommand, "CallStatus", DbType.String, portfolio.CallStatus);
           db.AddInParameter(commentaryCommand, "IsPartiallyExited", DbType.Boolean, portfolio.IsPartiallyExited);


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
       public static portfolioedit GetPortfolioByTicker(int stockTransactionId)
       {
           //DB Connection goes here

           portfolioedit _PremiumServicesListing = new portfolioedit();

           // Create the Database object, using the default database service. The
           // default database service is determined through configuration.
           Database db = DatabaseFactory.CreateDatabase();

           string sqlCommand = "GetPortfolioByTransactionId";
           DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

           // Retrieve products from the specified category.
           db.AddInParameter(dbCommand, "StockTransactionId", DbType.Int32, stockTransactionId);

           // DataSet that will hold the returned results		
           DataSet commentaryDataSet = null;

           commentaryDataSet = db.ExecuteDataSet(dbCommand);

           // Note: connection was closed by ExecuteDataSet method call 
           portfolioedit _portfoliolisting = new portfolioedit();

           foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
           {
                    _portfoliolisting.StockTransactionId = Int32.Parse(dr["StockTransactionId"].ToString());
                    _portfoliolisting.CompanyName = dr["CompanyName"].ToString();
                    _portfoliolisting.StockTicker = dr["StockTicker"].ToString();
                    _portfoliolisting.BuyOrSellId = Int32.Parse(dr["BuyOrSellId"].ToString());
                    _portfoliolisting.Qty = Int32.Parse(dr["Qty"].ToString());
                    _portfoliolisting.EntryPrice = decimal.Parse(dr["EntryPrice"].ToString());
                    _portfoliolisting.ExitPrice = decimal.Parse(dr["ExitPrice"].ToString());
                    _portfoliolisting.StopLoss = decimal.Parse(dr["StopLoss"].ToString());
                    _portfoliolisting.Updates = dr["Updates"].ToString();
                    _portfoliolisting.CallStatus = char.Parse(dr["CallStatus"].ToString());
                    _portfoliolisting.IsPartiallyExited = Boolean.Parse(dr["IsPartiallyExited"].ToString());
                    _portfoliolisting.PortfolioEntryDate = DateTime.Parse(dr["PortfolioEntryDate"].ToString());
                    _portfoliolisting.PortfolioExitDate = DateTime.Parse(dr["PortfolioExitDate"].ToString());
                    _portfoliolisting.PortfolioId = Int32.Parse(dr["PortfolioId"].ToString());
                   
           }

           return _portfoliolisting;
       }
    }
}
