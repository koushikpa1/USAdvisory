using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Email;

public partial class admin_Email_EditSendEmail : System.Web.UI.Page
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
            EditSendEmail _editSendEmail = new EditSendEmail();
            _editSendEmail = _editSendEmail.GetSendEmailSendEmailId(Int32.Parse(Request.QueryString["id"].ToString()));
            txtEmailSubject.Text = _editSendEmail.EmailSubject;
            isEmailSent.Checked = _editSendEmail.IsEmailSent;
            isSubscribers.Checked = _editSendEmail.IsSubscribers;
            fckcontent.Value = _editSendEmail.EmailDescription;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isEmailSent = false;

        bool _isSubscribers = false;

        if (isEmailSent.Checked)
            _isEmailSent = true;

        if (isSubscribers.Checked)
            _isSubscribers = true;

        EditSendEmail _editSendEmail = new EditSendEmail();
        _editSendEmail.EmailSubject = txtEmailSubject.Text;
        _editSendEmail.IsEmailSent = _isEmailSent;
        _editSendEmail.IsSubscribers = _isSubscribers;
        _editSendEmail.EmailDescription = fckcontent.Value;
        _editSendEmail.UpdateSendEmail(Int32.Parse(Request.QueryString["id"].ToString()));
        Response.Redirect("SendEmailListing.aspx");
    }
}
