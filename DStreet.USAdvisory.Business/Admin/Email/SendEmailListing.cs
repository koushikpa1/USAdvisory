using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.Admin.Email.DAL;

namespace DStreet.USAdvisory.Business.Admin.Email
{
   public class SendEmailListing : ISendEmail
    {

       public List<SendEmailListing> GetAllSendEmails()
        {
            return SendEmailDAL.GetAllSendEmails();
        }

       public List<SendEmailListing> GetAllSendEmailsByFilterData(string filterData)
        {
            return SendEmailDAL.GetAllSendEmailsFilterData(filterData);
        }

       private int _sendEmailId;


       public int SendEmailId
       {
           get { return _sendEmailId; }
           set { _sendEmailId = value; }
       }


        private string _emailDescription = string.Empty;

        public string EmailDescription
        {
            get { return _emailDescription; }
            set { _emailDescription = value; }
        }
        private bool _isSubscribers;

        public bool IsSubscribers
        {
            get { return _isSubscribers; }
            set { _isSubscribers = value; }
        }
        private bool _isEmailSent;

        public bool IsEmailSent
        {
            get { return _isEmailSent; }
            set { _isEmailSent = value; }
        }
        private DateTime _emailDateTime = DateTime.Now;

        public DateTime EmailDateTime
        {
            get { return _emailDateTime; }
            set { _emailDateTime = value; }
        }
        private string _emailSubject = string.Empty;

        public string EmailSubject
        {
            get { return _emailSubject; }
            set { _emailSubject = value; }
        }
        
    }
}
