using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.Admin.Markets.EmailNewsletter.DAL;

namespace DStreet.USAdvisory.Business.Admin.Markets.EmailNewsletter
{
    public class emailnewsletterlisting
    {
        public string GetAllEmailAddress()
        {
            return emailnewsletterdal.GetAllEmailAddress();
        }
    }
}
