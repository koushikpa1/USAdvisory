using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace DStreet.USAdvisory.Business.Admin.Users.DAL
{
   public class UsersDAL
    {
        public static List<UserListing> GetAllUsers()
        {
            //DB Connection goes here

            List<UserListing> _article = new List<UserListing>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetAllUsers";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);


            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                 UserListing _portfoliolisting = new UserListing();
                _portfoliolisting.UserId = dr["UserId"].ToString();
                _portfoliolisting.IsPaidSubscriber = bool.Parse(dr["IsPaidSubscriber"].ToString());
                _portfoliolisting.RegistrationDate = DateTime.Parse(dr["RegistrationDate"].ToString());
                _portfoliolisting.FirstName = dr["FirstName"].ToString();
                _portfoliolisting.LastName = dr["FirstName"].ToString();
                _article.Add(_portfoliolisting);
            }

            return _article;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterData"></param>
        /// <returns></returns>
        public static List<UserListing> GetUserFilterData(string filterData)
        {
            //DB Connection goes here

            List<UserListing> _article = new List<UserListing>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetAllUsers";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            DataRow[] dataRow;

            dataRow = commentaryDataSet.Tables[0].Select("UserId LIKE '%" + filterData + "%'");

            // Note: connection was closed by ExecuteDataSet method call 


            foreach (DataRow dr in dataRow)
            {
                UserListing _userlisting = new UserListing();
                 _userlisting.UserId = dr["UserId"].ToString();
                _userlisting.IsPaidSubscriber = bool.Parse(dr["IsPaidSubscriber"].ToString());
                _userlisting.RegistrationDate = DateTime.Parse(dr["RegistrationDate"].ToString());
                _userlisting.FirstName = dr["FirstName"].ToString();
                _userlisting.LastName = dr["LastName"].ToString();
                 _article.Add(_userlisting);
            }


            return _article;
        }

        /// 
        /// </summary>
        /// <param name="article"></param>
        public static void AddPortfolio(IUser user,DateTime subscriptionStartDate, DateTime subscriptionEndDate)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="article"></param>
        public static void UpdateUser(IUser user, DateTime subscriptionStartDate, DateTime subscriptionEndDate)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UpdateUser";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

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
        /// <summary>
        /// 
        /// </summary>
        public static EditUsers GetUserByUserId(string userId)
        {
            //DB Connection goes here

            EditUsers _PremiumServicesListing = new EditUsers();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetUserByUserId";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            db.AddInParameter(dbCommand, "UserId", DbType.String, userId);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 
            EditUsers _editUser = new EditUsers();

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                		   _editUser.UserId=dr["UserId"].ToString();
                           _editUser.Password=dr["Password"].ToString();
                           _editUser.FirstName=dr["FirstName"].ToString();
                           _editUser.LastName=dr["LastName"].ToString();
                           _editUser.PhoneNumber=dr["PhoneNumber"].ToString();
                           _editUser.RegistrationDate= DateTime.Parse(dr["RegistrationDate"].ToString());
                           _editUser.IsPaidSubscriber= bool.Parse(dr["IsPaidSubscriber"].ToString());
                           _editUser.IsAutoRenewal= bool.Parse(dr["IsAutoRenewal"].ToString());
                           _editUser.State=dr["State"].ToString();
                           _editUser.Address=dr["Address"].ToString();
                           _editUser.Country=dr["Country"].ToString();
                           _editUser.ZipCode= Int32.Parse(dr["ZipCode"].ToString());
                           _editUser.SubscriptionStartDate= DateTime.Parse(dr["subscriptionStartDate"].ToString());
                           _editUser.SubscriptionEndDate= DateTime.Parse(dr["subscriptionEndDate"].ToString());
            }

            return _editUser;
        }
    }
}
