using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;

namespace DStreet.USAdvisory.Business.UI.Markets.EmailNewsletter.DAL
{
   public static class emailnewsletterdal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        /// </summary>
        /// <param name="article"></param>
        public static void AddEmailAddress(string email)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UI_EmailSubscription";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

            // GlobalFunctions.GetCurrentTimeInEST()

            db.AddInParameter(commentaryCommand, "EmailAddress", DbType.String, email);

            using (DbConnection connection = db.CreateConnection())
            {
                connection.Open();
                db.ExecuteScalar(commentaryCommand);
                connection.Close();
            }
        }
    }
}
