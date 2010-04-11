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


        public static bool UpdatePassword( string userID, string oldPasswd, string NewPassword)
        {
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UpdateUserPassword";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

            // GlobalFunctions.GetCurrentTimeInEST()

            db.AddInParameter(commentaryCommand, "UserId", DbType.String, userID);
            db.AddInParameter(commentaryCommand, "OldPassword", DbType.String, oldPasswd);
            db.AddInParameter(commentaryCommand, "NewPassword", DbType.String, NewPassword);
            

            using (DbConnection connection = db.CreateConnection())
            {
                connection.Open();
              
                int IsUpdated = db.ExecuteNonQuery(commentaryCommand);
                connection.Close();
                if (IsUpdated == 1)
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }

        }

        public static bool UpdateMobileNumber(string userID, string oldNumber, string NewNumber)
        {
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UpdateUserMobileNo";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

            // GlobalFunctions.GetCurrentTimeInEST()

            db.AddInParameter(commentaryCommand, "UserId", DbType.String, userID);
            db.AddInParameter(commentaryCommand, "OldNumber", DbType.String, oldNumber);
            db.AddInParameter(commentaryCommand, "NewNumber", DbType.String, NewNumber);


            using (DbConnection connection = db.CreateConnection())
            {
                connection.Open();
                
                int IsUpdated = db.ExecuteNonQuery(commentaryCommand);
                
                connection.Close();
                if (IsUpdated == 1)
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }

        }

        public static Users getUserByUserID(string userID)
        {
             Users user = new Users();
         

            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UI_GetUserByUserID";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "userID", DbType.String, userID);

            // DataSet that will hold the returned results		
            DataSet userDataset = null;

            userDataset = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            if(userDataset.Tables[0].Rows.Count==1)
            {
               
                DataRow dr = userDataset.Tables[0].Rows[0];
                user.UserId = dr["UserId"].ToString();
                user.FirstName = dr["FirstName"].ToString();
                user.LastName = dr["LastName"].ToString();
                user.SubscriptionEndDate =DateTime.Parse(dr["SubscriptionEndDate"].ToString());
                user.SubscriptionStartDate = DateTime.Parse(dr["SubscriptionStartDate"].ToString());
                user.IsPaidSubscriber = (bool)dr["IsPaidSubscriber"];
               
             }
            return user ;

           
        }

        public static bool IsAuthorizedUser(string userID, string password)
        {

             Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UI_GetLoginInfo";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "userID", DbType.String, userID);

            // DataSet that will hold the returned results		
            DataSet userDataset = null;

            userDataset = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            if (userDataset.Tables[0].Rows.Count == 1)
            {

                DataRow dr = userDataset.Tables[0].Rows[0];
                string uname = dr["UserId"].ToString();
                string passwd = dr["Password"].ToString();

                if (string.Compare(uname, userID, true)==0 && passwd == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

    }
}
