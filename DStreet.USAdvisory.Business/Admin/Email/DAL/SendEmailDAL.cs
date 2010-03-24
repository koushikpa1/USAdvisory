using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;


namespace DStreet.USAdvisory.Business.Admin.Email.DAL
{
    public class SendEmailDAL
    {
        public static List<SendEmailListing> GetAllSendEmails()
        {
            //DB Connection goes here

            List<SendEmailListing> _article = new List<SendEmailListing>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetAllEmailToSend";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);


            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                SendEmailListing _emailListing = new SendEmailListing();
                _emailListing.EmailSubject = dr["EmailSubject"].ToString();
                _emailListing.EmailDateTime =DateTime.Parse(dr["EmailDateTime"].ToString());
                _emailListing.IsEmailSent = bool.Parse(dr["IsEmailSent"].ToString());
                _emailListing.SendEmailId = Int32.Parse(dr["SendEmailId"].ToString());
                _article.Add(_emailListing);
            }

            return _article;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterData"></param>
        /// <returns></returns>
        public static List<SendEmailListing> GetAllSendEmailsFilterData(string filterData)
        {
            //DB Connection goes here

            List<SendEmailListing> _article = new List<SendEmailListing>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetAllEmailToSend";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            //db.AddInParameter(dbCommand, "CategoryID", DbType.Int32, Category);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            DataRow[] dataRow;

            dataRow = commentaryDataSet.Tables[0].Select("EmailSubject LIKE '%" + filterData + "%'");

            // Note: connection was closed by ExecuteDataSet method call 


            foreach (DataRow dr in dataRow)
            {
                SendEmailListing _emailListing = new SendEmailListing();
                _emailListing.EmailSubject = dr["EmailSubject"].ToString();
                _emailListing.EmailDateTime = DateTime.Parse(dr["EmailDateTime"].ToString());
                _emailListing.IsEmailSent = bool.Parse(dr["IsEmailSent"].ToString());
                _article.Add(_emailListing);
            }


            return _article;
        }

        /// 
        /// </summary>
        /// <param name="article"></param>
        public static void AddSendEmail(ISendEmail email)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "InsertEmailToSend";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

            // GlobalFunctions.GetCurrentTimeInEST()

            db.AddInParameter(commentaryCommand, "EmailDescription", DbType.String, email.EmailDescription);
            db.AddInParameter(commentaryCommand, "IsEmailSent", DbType.Boolean, email.IsEmailSent);
            db.AddInParameter(commentaryCommand, "EmailDateTime", DbType.DateTime, GlobalFunctions.GetCurrentTimeInEST());
            db.AddInParameter(commentaryCommand, "EmailSubject", DbType.String, email.EmailSubject);
            db.AddInParameter(commentaryCommand, "IsSubscribers", DbType.Boolean, email.IsSubscribers);


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
        public static void UpdateSendEmail(int sendEmailId, ISendEmail email)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UpdateEmailToSend";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(commentaryCommand, "SendEmailId", DbType.String, sendEmailId);
            db.AddInParameter(commentaryCommand, "EmailDescription", DbType.String, email.EmailDescription);
            db.AddInParameter(commentaryCommand, "IsEmailSent", DbType.Boolean, email.IsEmailSent);
            db.AddInParameter(commentaryCommand, "EmailDateTime", DbType.DateTime, email.EmailDateTime);
            db.AddInParameter(commentaryCommand, "EmailSubject", DbType.String, email.EmailSubject);
            db.AddInParameter(commentaryCommand, "IsSubscribers", DbType.Boolean, email.IsSubscribers);


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
        public static EditSendEmail GetSendEmailSendEmailId(int sendEmailID)
        {
            //DB Connection goes here

            EditSendEmail _PremiumServicesListing = new EditSendEmail();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetEmailBySendEmailId";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            db.AddInParameter(dbCommand, "SendEmailID", DbType.Int32, sendEmailID);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 
            EditSendEmail _editSendEmail = new EditSendEmail();

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                _editSendEmail.EmailDescription = dr["EmailDescription"].ToString();
                _editSendEmail.EmailSubject = dr["EmailSubject"].ToString();
                _editSendEmail.EmailDateTime = DateTime.Parse(dr["EmailDateTime"].ToString());
                _editSendEmail.IsEmailSent = bool.Parse(dr["IsEmailSent"].ToString());
                _editSendEmail.IsSubscribers = bool.Parse(dr["IsSubscribers"].ToString());

            }

            return _editSendEmail;
        }
    }
}
