using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;
using DStreet.USAdvisory.Business.Common;
using DStreet.USAdvisory.Business.Security.DAL;


namespace DStreet.USAdvisory.Business.Security
{
    public class UserSecurity
    {
        private string _userId = string.Empty;

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private string _firstName = string.Empty;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName = string.Empty;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _phoneNumber = string.Empty;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        private bool _isPaidSubscriber;

        public bool IsPaidSubscriber
        {
            get { return _isPaidSubscriber; }
            set { _isPaidSubscriber = value; }
        }
        private DateTime _subscriptionStartDate = DateTime.MinValue;

        public DateTime SubscriptionStartDate
        {
            get { return _subscriptionStartDate; }
            set { _subscriptionStartDate = value; }
        }
        private DateTime _subscriptionEndDate = DateTime.MinValue;

        public DateTime SubscriptionEndDate
        {
            get { return _subscriptionEndDate; }
            set { _subscriptionEndDate = value; }
        }

        public UserSecurity GetUserCredentials(string _userId, string _password)
        {
            SecurityDAL _securityDAL = new SecurityDAL();
            return _securityDAL.GetUserCredentials(_userId, _password);
        }

    }
}
