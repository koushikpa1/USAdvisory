using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;
namespace DStreet.USAdvisory.Business.UI.Markets.WatchOut.DAL
{
    public static class watchoutDAL
    {
            /// <summary>
           /// 
           /// </summary>
           /// <returns></returns>
        public static List<WatchOutNews> GetAllWatchOutNews()
           {
               //DB Connection goes here

               // Create the Database object, using the default database service. The
               // default database service is determined through configuration.
               Database db = DatabaseFactory.CreateDatabase();

               string sqlCommand = "UI_GetAllWatchOutNewsForToday";
               DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

               // Retrieve products from the specified category.
               //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

               // DataSet that will hold the returned results		
               DataSet commentaryDataSet = null;

               commentaryDataSet = db.ExecuteDataSet(dbCommand);

               // Note: connection was closed by ExecuteDataSet method call 

               List<WatchOutNews> _watchoutNews = new List<WatchOutNews>();

               foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
               {
                   WatchOutNews _watchOut = new WatchOutNews();
                   _watchOut.ArticleId = Int32.Parse(dr["WatchOutId"].ToString());
                   _watchOut.ArticleTitle = dr["WatchOuttitle"].ToString();
                   _watchOut.ArticleDesc = dr["WatchOutText"].ToString();
                   _watchOut.ArticleDate = DateTime.Parse(dr["WatchOutDateTime"].ToString());
                   _watchOut.Ticker = dr["Ticker"].ToString();
                   _watchOut.IsPaid = short.Parse(dr["IsPaid"].ToString());
                   _watchoutNews.Add(_watchOut);

               }
               return _watchoutNews;
           }
       }
}
