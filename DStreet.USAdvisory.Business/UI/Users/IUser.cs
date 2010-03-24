using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DStreet.USAdvisory.Business.UI.Users
{
    public interface IUser
    {
        string UserId { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string State { get; set; }
        string Country { get; set; }
        int ZipCode { get; set; }
        bool IsPaidSubscriber { get; set; }
        bool IsAutoRenewal { get; set; }
        DateTime RegistrationDate { get; set; }
    }
}
