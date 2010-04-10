using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;

namespace DStreet.USAdvisory.Business.UI.Portfolio.DAL
{
    public class portfolioDAL
    {
    
       public static List<VirtualPortfolio> GetAllPortfolio(string OpenOrClose)
           {
               //DB Connection goes here

               List<VirtualPortfolio> _article = new List<VirtualPortfolio>();

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UI_GetAllPortfolio";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               db.AddInParameter(dbCommand, "OpenOrClose", DbType.String, OpenOrClose);


               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {
                   VirtualPortfolio _portfoliolisting = new VirtualPortfolio();
                   _portfoliolisting.StockTransactionId = Int32.Parse(dr["StockTransactionId"].ToString());
                   _portfoliolisting.StockTicker = dr["StockTicker"].ToString();
                   _portfoliolisting.CallStatus = char.Parse(dr["CallStatus"].ToString());
                   _portfoliolisting.IsPartiallyExited = Boolean.Parse(dr["IsPartiallyExited"].ToString());
                   _portfoliolisting.PortfolioEntryDate = DateTime.Parse(dr["PortfolioEntryDate"].ToString());
                   _portfoliolisting.PortfolioExitDate = DateTime.Parse(dr["PortfolioExitDate"].ToString());
                   _portfoliolisting.PortfolioId = Int32.Parse(dr["PortfolioId"].ToString());
                   _portfoliolisting.Qty = Int32.Parse(dr["Qty"].ToString());
                   _portfoliolisting.EntryPrice = decimal.Parse(dr["EntryPrice"].ToString());
                   _portfoliolisting.ExitPrice = decimal.Parse(dr["ExitPrice"].ToString());
                   _portfoliolisting.StopLoss = decimal.Parse(dr["StopLoss"].ToString());
                   _portfoliolisting.Updates = dr["Updates"].ToString();
                   _portfoliolisting.UpdateDateTime = DateTime.Parse(dr["UpdateDateTime"].ToString());
                   _portfoliolisting.BuyOrSellId = Int32.Parse(dr["BuyOrSellId"].ToString());
                   _portfoliolisting.CompanyName = dr["CompanyName"].ToString();
                   _portfoliolisting.BuyOrSell = dr["BuyOrSell"].ToString();
                   _article.Add(_portfoliolisting);
               }

               return _article;
           }

        public static VirtualPortfolio GetPortfolioByTransactionId(int stockTransactionId)
        {
            var virtualPortfolio = new VirtualPortfolio();


            Database db = DatabaseFactory.CreateDatabase();

            const string sqlCommand = "UI_GetPortfolioByTransactionId";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);


            db.AddInParameter(dbCommand, "StockTransactionId", DbType.Int32, stockTransactionId);


            DataSet portfolio = db.ExecuteDataSet(dbCommand);
            foreach (DataRow dr in portfolio.Tables[0].Rows)
            {
                virtualPortfolio.StockTransactionId = Int32.Parse(dr["StockTransactionId"].ToString());
                virtualPortfolio.StockTicker = dr["StockTicker"].ToString();
                virtualPortfolio.CallStatus = char.Parse(dr["CallStatus"].ToString());
                virtualPortfolio.IsPartiallyExited = Boolean.Parse(dr["IsPartiallyExited"].ToString());
                virtualPortfolio.PortfolioEntryDate = DateTime.Parse(dr["PortfolioEntryDate"].ToString());
                virtualPortfolio.PortfolioExitDate = DateTime.Parse(dr["PortfolioExitDate"].ToString());
                virtualPortfolio.PortfolioId = Int32.Parse(dr["PortfolioId"].ToString());
                virtualPortfolio.Qty = Int32.Parse(dr["Qty"].ToString());
                virtualPortfolio.EntryPrice = decimal.Parse(dr["EntryPrice"].ToString());
                virtualPortfolio.ExitPrice = decimal.Parse(dr["ExitPrice"].ToString());
                virtualPortfolio.StopLoss = decimal.Parse(dr["StopLoss"].ToString());
                virtualPortfolio.Updates = dr["Updates"].ToString();
                virtualPortfolio.UpdateDateTime = DateTime.Parse(dr["UpdateDateTime"].ToString());
                virtualPortfolio.BuyOrSellId = Int32.Parse(dr["BuyOrSellId"].ToString());
                virtualPortfolio.CompanyName = dr["CompanyName"].ToString();
                virtualPortfolio.BuyOrSell = dr["BuyOrSell"].ToString();
            }

            return virtualPortfolio;
        }

      
    }
}
