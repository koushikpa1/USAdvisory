using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;
using DStreet.USAdvisory.Business.UI.Performances;


namespace DStreet.USAdvisory.Business.UI.Performances
{
    public static class PerformanceDAL
    {
        public static List<Performances> GetPerformances()
        {
            //DB Connection goes here

            List<Performances> _article = new List<Performances>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UI_GetPerformances";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

           

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                Performances _performanceListing = new Performances();
                _performanceListing.ArticleId = Int32.Parse(dr["PremiumServiceId"].ToString());
                _performanceListing.ArticleTitle = dr["PremiumServiceTitle"].ToString();
                _performanceListing.ArticleDesc = dr["PremiumServiceDescription"].ToString();
                _performanceListing.ArticleDate = DateTime.Parse(dr["PremiumServiceDate"].ToString());
                _performanceListing.Ticker = dr["Ticker"].ToString();
                _performanceListing.TradeType = dr["TradeTypes"].ToString();
                _article.Add(_performanceListing);

            }
            return _article;
        }

        


    }
}
