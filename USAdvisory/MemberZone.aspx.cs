using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.UI.PremiumServices;

public partial class MemberZone : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PremiumServices ps = new PremiumServices();
        int DayTradeCount = ps.GetPremiumServicesArticleCount(1);
        int PennyStocksCount = ps.GetPremiumServicesArticleCount(4);
        int ValueInvestingCount = ps.GetPremiumServicesArticleCount(3);

        lblDayTrade.Text = DayTradeCount + " Articles Updated Today";
        lblValueInvesting.Text = ValueInvestingCount + " Articles Updated Today";
        lblPennyStocks.Text = PennyStocksCount + " Articles Updated Today";
    }
}
