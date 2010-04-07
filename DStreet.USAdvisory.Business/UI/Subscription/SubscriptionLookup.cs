using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.UI.SubscriptionLookup.DAL;

namespace DStreet.USAdvisory.Business.UI.SubscriptionLookup
{
    public class SubscriptionLookup
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int numberOfMonthsSubs;

        public int NumberOfMonthsSubs
        {
            get { return numberOfMonthsSubs; }
            set { numberOfMonthsSubs = value; }
        }
        private double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string subscriptionTitle;
        public string SubscriptionTitle
        {
            get {return subscriptionTitle ;}
            set { subscriptionTitle = value; }
        }

        public List<SubscriptionLookup> GetSubscriptionLookup()
        {
            return SubscriptionLookupDAL.GetSubscriptionLookup();
        }
        
    }
}
