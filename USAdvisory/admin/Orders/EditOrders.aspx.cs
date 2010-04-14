using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Orders;

public partial class admin_Orders_EditOrders : System.Web.UI.Page
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            EditOrders _editOrder = new EditOrders();
            _editOrder = _editOrder.GetOrderByOrderId(Int32.Parse(Request.QueryString["OrderId"].ToString()),Request.QueryString["id"].ToString());

            txtUserId.Text = Request.QueryString["id"].ToString();
            txtUniqueOrderId.Text = _editOrder.OrderReferenceId.ToString();
            txtPaymentDate.Text = _editOrder.PaymentDate.ToString();
            txtSubscriptionEndDate.Text = _editOrder.SubscriptionEndDate.ToString();
            txtSubscriptionStartDate.Text = _editOrder.SubscriptionStartDate.ToString();
            txtVendorReferenceId.Text = _editOrder.VendorReferenceId.ToString();
            txtMonthsOfSubscription.Text = _editOrder.MonthsOfSubscription.ToString();
        }
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnsave_Click(object sender, EventArgs e)
    {
        EditOrders _editOrders = new EditOrders();
        _editOrders.UserId = txtUserId.Text;
        _editOrders.VendorReferenceId = txtVendorReferenceId.Text;
        _editOrders.SubscriptionEndDate = DateTime.Parse(txtSubscriptionEndDate.Text);
        _editOrders.PaymentDate = DateTime.Parse(txtPaymentDate.Text);
        _editOrders.SubscriptionStartDate = DateTime.Parse(txtSubscriptionStartDate.Text);
        _editOrders.MonthsOfSubscription = txtMonthsOfSubscription.Text;
        _editOrders.OrderReferenceId = txtUniqueOrderId.Text;
        _editOrders.UpdateOrders(Int32.Parse(Request.QueryString["OrderId"].ToString()));
        Response.Redirect("OrdersListing.aspx");
    }
}
