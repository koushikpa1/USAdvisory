using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DStreet.USAdvisory.Business.Admin.Orders
{
    public interface IOrder
    {
        int OrderId { get; set; }
        string OrderReferenceId { get; set; } //Unique OrderId Id
        string VendorReferenceId { get; set; } //Vendor OrderId Id
        string UserId { get; set; }
        string MonthsOfSubscription { get; set; }
        DateTime PaymentDate { get; set; }
        DateTime SubscriptionStartDate { get; set; }
        DateTime SubscriptionEndDate { get; set; }
    }
}
