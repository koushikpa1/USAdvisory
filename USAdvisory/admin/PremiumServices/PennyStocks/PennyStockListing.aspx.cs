using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.PremiumServices;

public partial class admin_PremiumServices_PennyStocks_PennyStockListing : System.Web.UI.Page
{
    /// <summary>
    /// Page Load Method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        ObjectDataSource1.SelectMethod = "GetAllPremiumServices";
        ObjectDataSource1.SelectParameters.Clear();
        ObjectDataSource1.SelectParameters.Add("tradeType", TypeCode.String, "4");
        GridView1.DataBind();
    }

    /// <summary>
    /// Filter method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    protected void lbFilter_Click(object sender, EventArgs e)
    {

        ObjectDataSource1.TypeName = "DStreet.USAdvisory.Business.Admin.PremiumServices.premiumserviceslisting";
        ObjectDataSource1.SelectMethod = "GetPremiumServicesFilterData";
        ObjectDataSource1.SelectParameters.Clear();
        ObjectDataSource1.SelectParameters.Add("filterData", TypeCode.String, txtName.Text);
        ObjectDataSource1.SelectParameters.Add("tradeType", TypeCode.String, "4");
        GridView1.DataBind();
    }


    /// <summary>
    /// Filter method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    protected void lbGetAll_Click(object sender, EventArgs e)
    {
        ObjectDataSource1.SelectMethod = "GetAllPremiumServices";
        ObjectDataSource1.SelectParameters.Clear();
        ObjectDataSource1.SelectParameters.Add("tradeType", TypeCode.String, "4");
        GridView1.DataBind();
    }
}
