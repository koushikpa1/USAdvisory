using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;

namespace DStreet.USAdvisory.Business.UI.Markets.Commentary.DAL
{
    public static class commentaryUIDAL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static MarketCommentary GetAllMarketCommentaryForToday()
        {
            //DB Connection goes here

            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UI_GetAllMarketCommentaryForToday";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 
            
            MarketCommentary _marketCommentary = new MarketCommentary();

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                _marketCommentary.MarketCommentaryId = Int32.Parse(dr["MarketCommentaryId"].ToString());
                _marketCommentary.MarketCommentaryTitle = dr["MarketCommentaryTitle"].ToString();
                _marketCommentary.MarketCommentaryDecription = dr["MarketCommentaryDesc"].ToString();
                _marketCommentary.MarketCommentaryDateTime = DateTime.Parse(dr["MarketCommentaryDateTime"].ToString());
            }
            return _marketCommentary;
        }
    }
}
