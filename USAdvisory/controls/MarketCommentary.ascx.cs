using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DStreet.USAdvisory.Business.UI.Markets.Commentary;

using System.Text.RegularExpressions;
using DStreet.USAdvisory.Business.UI.Markets.EmailNewsletter;


public partial class controls_MarketCommentary : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtEmailAddress.Attributes.Add("onClick", "this.value = ( this.value == this.defaultValue ) ? '' : this.value;return true;");
        txtEmailAddress.Attributes.Add("onfocus", "this.value = ( this.value == this.defaultValue ) ? '' : this.value;return true;");



        MarketCommentary _commentary = new MarketCommentary();
        _commentary = _commentary.GetLatestMarketCommentary();
        if (!string.IsNullOrEmpty(_commentary.MarketCommentaryTitle))
        {
            commentaryDateTime.Text = _commentary.MarketCommentaryDateTime.ToLongDateString();
            commentaryTitle.Text = _commentary.MarketCommentaryTitle;
            //commentaryDesc.Text = _commentary.MarketCommentaryDecription;
            if (_commentary.MarketCommentaryDecription.Length > 370)
                commentaryDesc.Text = _commentary.MarketCommentaryDecription.Substring(0, 370).Trim().Replace("<br />", "").Replace("</p>", "").Replace("<p>", "");
            else
                commentaryDesc.Text = _commentary.MarketCommentaryDecription.Substring(0, _commentary.MarketCommentaryDecription.Length).Trim();


        }
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string _email = string.Empty;

            _email = txtEmailAddress.Text;

            if (!string.IsNullOrEmpty(_email))
            {
                        Regex emailregex = new Regex("(?<user>[^@]+)@(?<host>.+)");
                        //Check for Cross site scripting and add to the database...
                        Match m = emailregex.Match(_email);
                        if (m.Success)
                        {
                            emailnewsletterlisting _emailListing = new emailnewsletterlisting();
                            _emailListing.AddEmailToNewsletter(_email);
                            txtEmailAddress.Text = " You have signed up successfully";
                            return;
                        }
                        else
                            txtEmailAddress.Text = " Invalid Email Address";
                
            }
            else
                txtEmailAddress.Text = " Invalid Email Address";
        }
        
    }
}
