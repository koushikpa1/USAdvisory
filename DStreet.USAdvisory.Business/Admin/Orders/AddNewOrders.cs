using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.Admin.Orders.DAL;

namespace DStreet.USAdvisory.Business.Admin.Orders
{
    public class AddNewOrders : IOrder
    {

        //Private variables
        int _orderId;
        string _orderReferenceId = string.Empty; //Unique OrderId Id
        string _vendorReferenceId = string.Empty; //Vendor OrderId Id
        string _userId = string.Empty;
        string _monthsOfSubscription ;
        DateTime _paymentDate = DateTime.MinValue;
        DateTime _subscriptionStartDate = DateTime.MinValue;
        DateTime _subscriptionEndDate = DateTime.MinValue;

        #region IOrder Members

        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        public string OrderReferenceId
        {
            get { return _orderReferenceId; }
            set { _orderReferenceId = value; }
        }

        public string VendorReferenceId
        {
            get { return _vendorReferenceId; }
            set { _vendorReferenceId = value; }
        }

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string MonthsOfSubscription
        {
            get { return _monthsOfSubscription; }
            set { _monthsOfSubscription = value; }
        }

        public DateTime PaymentDate
        {
            get { return _paymentDate; }
            set { _paymentDate = value; }
        }

        public DateTime SubscriptionStartDate
        {
            get { return _subscriptionStartDate; }
            set { _subscriptionStartDate = value; }
        }

        public DateTime SubscriptionEndDate
        {
            get { return _subscriptionEndDate; }
            set { _subscriptionEndDate = value; }
        }

        public void AddOrder()
        {
            OrdersDAL.AddOrder(this);
        }


        #endregion
    }
}
