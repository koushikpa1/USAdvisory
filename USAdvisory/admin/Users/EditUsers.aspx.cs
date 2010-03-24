using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Users;

public partial class admin_Users_EditUsers : System.Web.UI.Page
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
            EditUsers _editUser = new EditUsers();
            _editUser = _editUser.GetUserByUserId(Request.QueryString["id"].ToString());
            txtUserId.Text = Request.QueryString["id"].ToString();
            txtPassword.Text = _editUser.Password.ToString();
            txtFirstName.Text = _editUser.FirstName.ToString();
            txtLastName.Text = _editUser.LastName.ToString();
            txtPhoneNumber.Text = _editUser.PhoneNumber.ToString();
            txtZipCode.Text = _editUser.ZipCode.ToString();
            txtState.Text = _editUser.State.ToString();
            txtCountry.Text = _editUser.Country.ToString();
            txtRegistrationDate.Text = _editUser.RegistrationDate.ToString();
            txtSubscriptionDate.Text = _editUser.SubscriptionStartDate.ToString();
            txtSubscriptionEndDate.Text = _editUser.SubscriptionEndDate.ToString();
            txtAddress.Text = _editUser.Address.ToString();
            IsPaidSubscriber.Checked = _editUser.IsPaidSubscriber;
            IsAutoRenewal.Checked = _editUser.IsAutoRenewal;
            
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isPaidSubscriber = false;

        bool _isAutoRenewal = false;

        if (IsPaidSubscriber.Checked)
            _isPaidSubscriber = true;

        if (IsAutoRenewal.Checked)
            _isAutoRenewal = true;

        EditUsers _addUsers = new EditUsers();
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
        _addUsers.UpdateUser(_addUsers);
        Response.Redirect("userlisting.aspx");
    }
}
