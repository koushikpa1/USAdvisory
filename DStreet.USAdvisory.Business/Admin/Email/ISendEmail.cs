using System;
namespace DStreet.USAdvisory.Business.Admin.Email
{
   public interface ISendEmail
    {
        DateTime EmailDateTime { get; set; }
        string EmailDescription { get; set; }
        string EmailSubject { get; set; }
        bool IsEmailSent { get; set; }
        bool IsSubscribers { get; set; }
    }
}
