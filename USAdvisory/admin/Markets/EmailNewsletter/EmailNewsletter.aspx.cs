using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Markets.EmailNewsletter;

public partial class admin_Markets_EmailNewsletter_EmailNewsletter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        emailnewsletterlisting _emailListing = new emailnewsletterlisting();
        idEmail.Text =  _emailListing.GetAllEmailAddress();

    }
}
