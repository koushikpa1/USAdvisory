using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Markets_NewsViews_Newsviewslisting : System.Web.UI.Page
{
  
         /// <summary>
    /// Page Load Method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {

        ObjectDataSource1.SelectMethod = "GetAllNewsViews";
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

        ObjectDataSource1.TypeName = "DStreet.USAdvisory.Business.Admin.Markets.NewsViews.premiumserviceslisting";
        ObjectDataSource1.SelectMethod = "newsviewslisting";
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
        ObjectDataSource1.SelectMethod = "GetAllNewsViews";
        ObjectDataSource1.SelectParameters.Clear();
        GridView1.DataBind();
    }
    
}
