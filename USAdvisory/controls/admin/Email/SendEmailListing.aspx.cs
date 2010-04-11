using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Email_SendEmailListing : System.Web.UI.Page
{
    /// <summary>
    /// Page Load Method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {

        ObjectDataSource1.SelectMethod = "GetAllSendEmails";
        ObjectDataSource1.SelectParameters.Clear();
        GridView1.DataBind();
    }

    /// <summary>
    /// Filter method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    protected void lbFilter_Click(object sender, EventArgs e)
    {

        ObjectDataSource1.TypeName = "DStreet.USAdvisory.Business.Admin.Email.SendEmailListing";
        ObjectDataSource1.SelectMethod = "GetAllSendEmailsByFilterData";
        ObjectDataSource1.SelectParameters.Clear();
        ObjectDataSource1.SelectParameters.Add("filterData", TypeCode.String, txtName.Text);
        GridView1.DataBind();
    }


    /// <summary>
    /// Filter method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    protected void lbGetAll_Click(object sender, EventArgs e)
    {
        ObjectDataSource1.SelectMethod = "GetAllSendEmails";
        ObjectDataSource1.SelectParameters.Clear();
        GridView1.DataBind();
    }
}
