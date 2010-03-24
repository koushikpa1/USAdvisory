using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Markets.Commentary;

public partial class admin_Markets_Commentary_Addnewcommentary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Session["admin"].ToString()))
            Response.Redirect ("~/LogMeIn.aspx");
            
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isActive = false;

        if (isActive.Checked)
            _isActive = true;

        commentaryadd _commAdd = new commentaryadd(txtheader.Text, fckcontent.Value,DateTime.Now,_isActive);
        _commAdd.AddMarketCommentary();
        Response.Redirect("commlisting.aspx");
    }
}
