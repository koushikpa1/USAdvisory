using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace DStreet.USAdvisory.Business.UI.SubscriptionLookup.DAL
{
    public class SubscriptionLookupDAL
    {
        public static List<SubscriptionLookup> GetSubscriptionLookup()
        {
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetSubscriptionLookup";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            	
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);


            List<SubscriptionLookup> lstSubscriptionLookup = new List<SubscriptionLookup>();

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                SubscriptionLookup lookup = new SubscriptionLookup();
                lookup.ID = Int32.Parse(dr["NoOfMonthsSubscriptionId"].ToString());
                lookup.NumberOfMonthsSubs = Int32.Parse(dr["NoOfMonthsSubscriptionDesc"].ToString());
                lookup.Amount = Convert.ToDouble(dr["Amount"].ToString());
                lookup.SubscriptionTitle = dr["SubscriptionTitle"].ToString();
                lstSubscriptionLookup.Add(lookup);
                
            }
            return lstSubscriptionLookup;
        }
    }
}
