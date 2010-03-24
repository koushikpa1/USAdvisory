using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;

namespace DStreet.USAdvisory.Business.Admin.Markets.EmailNewsletter.DAL
{
   public static class emailnewsletterdal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
       public static string GetAllEmailAddress()
        {
          
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetAllEmailAddress";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            StringBuilder sb = new StringBuilder();
            // Retrieve products from the specified category.
            //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                sb.Append(dr["EmailAddress"].ToString());
                sb.Append(",");    
            }
            return sb.ToString();
        }

    }
}
