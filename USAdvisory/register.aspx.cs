using System;
using DStreet.USAdvisory.Business.UI.SubscriptionLookup;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SubscriptionLookup lookup = new SubscriptionLookup();
        lstRadioButton.DataSource = lookup.GetSubscriptionLookup();
        lstRadioButton.DataBind();
        
        
    }
    protected void btnRegister_OnClick(object sender, EventArgs e)
    {
        ccJoin.ValidateCaptcha(txtCaptcha.Text);
        if (!ccJoin.UserValidated)
        {
            //throw a message here if its not valid
            return;
        }

        var user = new DStreet.USAdvisory.Business.UI.Users.Users
                       {
                           FirstName = txtFirstName.Text,
                           LastName = txtLastName.Text,
                           UserId = txtUserId.Text,
                           PhoneNumber = txtPhoneNumber.Text,
                           Password = txtPassword.Text,
                           Address = txtAddress.Text,
                           State = txtState.Text,
                           Country = txtCountry.Text,
                           ZipCode = Convert.ToInt32(txtZip.Text),
                           RegistrationDate = DateTime.Now,
                           SubscriptionStartDate = DateTime.Today.AddYears(-10),
                           SubscriptionEndDate = DateTime.Today.AddYears(-10)
                       };

        user.AddUser();    
        

    }
}
