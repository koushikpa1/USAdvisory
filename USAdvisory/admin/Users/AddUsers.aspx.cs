using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Users;

public partial class admin_Users_AddUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Session["admin"].ToString()))
            Response.Redirect("~/LogMeIn.aspx");

        txtRegistrationDate.Text = DateTime.Now.ToString();
        txtSubscriptionDate.Text = "1/1/1800";
        txtSubscriptionEndDate.Text = "1/1/1800";


    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isPaidSubscriber = false;

        if (IsPaidSubscriber.Checked)
            _isPaidSubscriber = true;

        bool _isAutoRenewal = false;

        if (IsAutoRenewal.Checked)
            _isAutoRenewal = true;

        AddUsers _addUsers = new AddUsers();
        _addUsers.UserId = txtUserId.Text;
        _addUsers.Password = txtPassword.Text;
        _addUsers.FirstName = txtFirstName.Text;
        _addUsers.LastName = txtLastName.Text;
        _addUsers.PhoneNumber = txtPhoneNumber.Text;
        _addUsers.ZipCode = Int32.Parse(txtZipCode.Text);
        _addUsers.RegistrationDate = DateTime.Parse(txtRegistrationDate.Text);
        _addUsers.SubscriptionStartDate = DateTime.Parse(txtSubscriptionDate.Text);
        _addUsers.SubscriptionEndDate = DateTime.Parse(txtSubscriptionEndDate.Text);
        _addUsers.Address = txtAddress.Text;
        _addUsers.State = txtState.Text;
        _addUsers.Country = txtCountry.Text;
        _addUsers.IsAutoRenewal = _isAutoRenewal;
        _addUsers.IsPaidSubscriber = _isPaidSubscriber;
        _addUsers.AddUser();
        Response.Redirect("userlisting.aspx");



    }
}
