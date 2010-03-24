using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;
using DStreet.USAdvisory.Business.Admin.Users;

namespace DStreet.USAdvisory.Business.Admin.Orders.DAL
{
    public class OrdersDAL
    {

        public static List<OrdersListing> GetAllOrders()
        {
            //DB Connection goes here

            List<OrdersListing> _article = new List<OrdersListing>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetAllOrders";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);


            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                OrdersListing _portfoliolisting = new OrdersListing();
                _portfoliolisting.OrderId = Int32.Parse(dr["OrderId"].ToString());
                _portfoliolisting.UserId = dr["UserId"].ToString();
                _portfoliolisting.MonthsOfSubscription = dr["NoOfMonthsSubscriptionDesc"].ToString();
                _portfoliolisting.SubscriptionStartDate = DateTime.Parse(dr["SubscriptionStartDate"].ToString());
                _portfoliolisting.SubscriptionEndDate = DateTime.Parse(dr["SubscriptionEndDate"].ToString());
                _article.Add(_portfoliolisting);
            }

            return _article;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterData"></param>
        /// <returns></returns>
        public static List<OrdersListing> GetOrderFilterData(string filterData)
        {
            //DB Connection goes here

            List<OrdersListing> _article = new List<OrdersListing>();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetAllOrders";
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
                OrdersListing _portfoliolisting = new OrdersListing();
                _portfoliolisting.OrderId = Int32.Parse(dr["OrderId"].ToString());
                _portfoliolisting.UserId = dr["UserId"].ToString();
                _portfoliolisting.MonthsOfSubscription = dr["MonthsOfSubscription"].ToString();
                _portfoliolisting.SubscriptionStartDate = DateTime.Parse(dr["SubscriptionStartDate"].ToString());
                _portfoliolisting.SubscriptionEndDate = DateTime.Parse(dr["SubscriptionEndDate"].ToString());
                _article.Add(_portfoliolisting);
            }


            return _article;
        }

        /// 
        /// </summary>
        /// <param name="article"></param>
        public static void AddOrder(IOrder order)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "InsertOrder";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

            // GlobalFunctions.GetCurrentTimeInEST()

            db.AddInParameter(commentaryCommand, "UserId", DbType.String, order.UserId);
            db.AddInParameter(commentaryCommand, "UniqueOrderId", DbType.String, order.OrderReferenceId);
            db.AddInParameter(commentaryCommand, "MonthsOfSubscription", DbType.String, order.MonthsOfSubscription);
            db.AddInParameter(commentaryCommand, "PaymentDate", DbType.DateTime, order.PaymentDate);
            db.AddInParameter(commentaryCommand, "VendorReferenceId", DbType.String, order.VendorReferenceId);
            db.AddInParameter(commentaryCommand, "SubscriptionStartDate", DbType.DateTime, order.SubscriptionStartDate);
            db.AddInParameter(commentaryCommand, "SubscriptionEndDate", DbType.DateTime, order.SubscriptionEndDate);

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
        public static void UpdateOrders(IOrder order)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "UpdateOrders";
            DbCommand commentaryCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            db.AddInParameter(commentaryCommand, "OrderId", DbType.Int32, order.OrderId);


            db.AddInParameter(commentaryCommand, "UserId", DbType.String, order.UserId);
            db.AddInParameter(commentaryCommand, "UniqueOrderId", DbType.String, order.OrderReferenceId);
            db.AddInParameter(commentaryCommand, "MonthsOfSubscription", DbType.String, order.MonthsOfSubscription);
            db.AddInParameter(commentaryCommand, "PaymentDate", DbType.DateTime, order.PaymentDate);
            db.AddInParameter(commentaryCommand, "VendorReferenceId", DbType.String, order.VendorReferenceId);
            db.AddInParameter(commentaryCommand, "SubscriptionStartDate", DbType.DateTime, order.SubscriptionStartDate);
            db.AddInParameter(commentaryCommand, "SubscriptionEndDate", DbType.DateTime, order.SubscriptionEndDate);



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
        public static EditOrders GetOrderByOrderId(int orderId,string userId)
        {
            //DB Connection goes here

            EditOrders _PremiumServicesListing = new EditOrders();

            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();

            string sqlCommand = "GetOrdesrByUserIdOrderId";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            // Retrieve products from the specified category.
            db.AddInParameter(dbCommand, "UserId", DbType.String, userId);

            // Retrieve products from the specified category.
            db.AddInParameter(dbCommand, "OrderId", DbType.Int32, orderId);

            // DataSet that will hold the returned results		
            DataSet commentaryDataSet = null;

            commentaryDataSet = db.ExecuteDataSet(dbCommand);

            // Note: connection was closed by ExecuteDataSet method call 
            EditOrders _editUser = new EditOrders();

            foreach (DataRow dr in commentaryDataSet.Tables[0].Rows)
            {
                _editUser.UserId = dr["UserId"].ToString();
                _editUser.OrderReferenceId = dr["UniqueOrderId"].ToString();
                _editUser.MonthsOfSubscription = dr["NoOfMonthsSubscriptionDesc"].ToString();
                _editUser.PaymentDate = DateTime.Parse(dr["PaymentDate"].ToString());
                _editUser.SubscriptionStartDate = DateTime.Parse(dr["subscriptionStartDate"].ToString());
                _editUser.SubscriptionEndDate = DateTime.Parse(dr["subscriptionEndDate"].ToString());
                _editUser.VendorReferenceId = dr["VendorReferenceId"].ToString();
            }

            return _editUser;
        }
    } 
}
