using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace DStreet.USAdvisory.Business.UI.Users.DAL
{
   public static class UsersDAL
    {
        /// 
        /// </summary>
        /// <param name="article"></param>
        public static void AddUser(IUser user,DateTime subscriptionStartDate, DateTime subscriptionEndDate)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "InsertUser";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

            // GlobalFunctions.GetCurrentTimeInEST()

            db.AddInParameter(commentaryCommand, "UserId", DbType.String, user.UserId);
            db.AddInParameter(commentaryCommand, "Password", DbType.String, user.Password);
            db.AddInParameter(commentaryCommand, "FirstName", DbType.String, user.FirstName);
            db.AddInParameter(commentaryCommand, "LastName", DbType.String, user.LastName);
            db.AddInParameter(commentaryCommand, "PhoneNumber", DbType.String, user.PhoneNumber);
            db.AddInParameter(commentaryCommand, "RegistrationDate", DbType.DateTime, user.RegistrationDate);
            db.AddInParameter(commentaryCommand, "IsPaidSubscriber", DbType.Boolean, user.IsPaidSubscriber);
            db.AddInParameter(commentaryCommand, "IsAutoRenewal", DbType.Boolean, user.IsAutoRenewal);
            db.AddInParameter(commentaryCommand, "State", DbType.String, user.State);
            db.AddInParameter(commentaryCommand, "Address", DbType.String, user.Address);
            db.AddInParameter(commentaryCommand, "Country", DbType.String, user.Country);
            db.AddInParameter(commentaryCommand, "ZipCode", DbType.Int32, user.ZipCode);
            db.AddInParameter(commentaryCommand, "SubscriptionStartDate", DbType.DateTime, subscriptionStartDate);
            db.AddInParameter(commentaryCommand, "SubscriptionEndDate", DbType.DateTime, subscriptionEndDate);

            using (DbConnection connection = db.CreateConnection())
            {
                connection.Open();
                db.ExecuteNonQuery(commentaryCommand);
                connection.Close();
            }
        }
    }
}
