using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Orders;

public partial class admin_Orders_AddOrders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Session["admin"].ToString()))
            Response.Redirect("~/LogMeIn.aspx");

        txtPaymentDate.Text = DateTime.Now.ToString();
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        AddNewOrders _addOrders = new AddNewOrders();
        _addOrders.UserId = txtUserId.Text;
        _addOrders.OrderReferenceId = txtUniqueOrderId.Text;
        _addOrders.PaymentDate = DateTime.Parse(txtPaymentDate.Text);
        _addOrders.SubscriptionStartDate = DateTime.Parse(txtSubscriptionStartDate.Text);
        _addOrders.SubscriptionEndDate = DateTime.Parse(txtSubscriptionEndDate.Text);
        _addOrders.VendorReferenceId = txtVendorReferenceId.Text;
        _addOrders.MonthsOfSubscription = txtMonthsOfSubscription.Text;
        _addOrders.AddOrder();
        Response.Redirect("OrdersListing.aspx");
    }
}
