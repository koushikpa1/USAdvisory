using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.UI.Markets.EmailNewsletter.DAL;

namespace DStreet.USAdvisory.Business.UI.Markets.EmailNewsletter
{
    public class emailnewsletterlisting
    {
        public void AddEmailToNewsletter(string email)
        {
            emailnewsletterdal.AddEmailAddress(email);
        }
    }
}
