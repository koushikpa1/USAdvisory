using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

// Enterprise library
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


namespace DStreet.USAdvisory.Business.Security.DAL
{
   public class SecurityDAL
    {

       public SecurityDAL()
        {
        }

       #region "IsValid Admin "
       /// <summary>
        /// Retreives a list of customers from the database.
        /// </summary>
        /// <returns>List of customers in a string.</returns>
        /// <remarks>Demonstrates retrieving multiple rows of data using
        /// a DataReader</remarks>
        public bool IsValidAdminUser(string userName, string passWord)
        {
            // DataReader that will hold the returned results		
            int _adminUserCount = 0;

            // DataReader that will hold the returned results		
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "Select count(*) as adminUserCount from AdminCredentials where Username ='" + userName + "'and Password ='" + passWord + "'";
            DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);

            StringBuilder readerData = new StringBuilder();

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    // Get the value of the 'Name' column in the DataReader
                    _adminUserCount = Int32.Parse(dataReader["adminUserCount"].ToString());
                }
            }

            if (_adminUserCount > 0)
                return true;
            return false;
        }
       #endregion

        #region "Get User Credentials
        public UserSecurity GetUserCredentials(string userId, string password)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UI_GetUserCredentials";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);


            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 
            UserSecurity _userSecurity = new UserSecurity();

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                
                _userSecurity.UserId = dr["UserId"].ToString();
                _userSecurity.FirstName = dr["FirstName"].ToString();
                _userSecurity.LastName =  dr["LastName"].ToString();
                _userSecurity.PhoneNumber =  dr["PhoneNumber"].ToString();
                _userSecurity.SubscriptionStartDate = DateTime.Parse(dr["SubscriptionStartDate"].ToString());
                _userSecurity.SubscriptionEndDate = DateTime.Parse(dr["SubscriptionEndDate"].ToString());
                
            }

            return _userSecurity;
        }
        #endregion
    }
}
