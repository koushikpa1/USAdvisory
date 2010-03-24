using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Email;

public partial class admin_Email_AddSendEmail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Session["admin"].ToString()))
            Response.Redirect ("~/LogMeIn.aspx");
            
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isEmailSent = false;

        bool _isSubscribers = false;

        if (isEmailSent.Checked)
            _isEmailSent = true;

        if (isSubscribers.Checked)
            _isSubscribers = true;

        AddSendEmail _addSendEmail = new AddSendEmail();
        _addSendEmail.EmailSubject = txtEmailSubject.Text;
        _addSendEmail.EmailDescription = fckcontent.Value;
        _addSendEmail.IsEmailSent = _isEmailSent;
        _addSendEmail.IsSubscribers = _isSubscribers;
        _addSendEmail.AddSendEmails();
        Response.Redirect("SendEmailListing.aspx");
    }
}
