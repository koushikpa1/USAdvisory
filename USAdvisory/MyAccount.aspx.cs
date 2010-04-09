using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DStreet.USAdvisory.Business.UI.Users;

public partial class MyAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {

        Users users = new Users();
        string OldNumber = txtOldNo.Text;
        string NewNumber = txtNewNo.Text;
        string NewNumberConfirm = txtNewNo1.Text;
        if (true) //Check if OldMobileNumber is Correct for the Username
        {
            if (NewNumber == NewNumberConfirm)
            {
               bool IsMobileUpdated = users.UpdateMobileNo("", OldNumber, NewNumber);
            }
        }
        else
        {

        }
        
    }

    protected void cancel_Click(object sender, EventArgs e)
    {
        txtOldNo.Text = "";
        txtNewNo.Text = "";
        txtNewNo1.Text = "";

    }

    protected void submitPassword_Click(object sender, EventArgs e)
    {
        string OldPassword = txtOldPassword.Text;
        string NewPassword = txtNewPassword.Text;
        string NewPasswordConfirm = txtNewPassword1.Text;

        Users users = new Users();
        if (true) //Check if OldPassword is Correct for the Username
        {
            if (NewPassword == NewPasswordConfirm)
            {
                bool IsPasswordUpdated = users.UpdatePassword("india", OldPassword, NewPassword);
                if (IsPasswordUpdated)
                {
                    MessageBox.ShowMessageBox("Password Changed Successfully!", this.Page);
                }
            }

        }
        else
        {

        }
    }

    protected void CancelPassword_Click(object sender, EventArgs e)
    {

        txtOldPassword.Text = "";
        txtNewPassword.Text = "";
        txtNewPassword1.Text = "";
    }
}
