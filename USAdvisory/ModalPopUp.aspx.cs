using System;
using DStreet.USAdvisory.Business.UI.Portfolio;
using DStreet.USAdvisory.Business.UI.PremiumServices;

public partial class ModalPopUp : System.Web.UI.Page
{
    public int DAY_SWING_TRADE = 1;
    public int PERFORMANCE = 2;

    protected void Page_Load(object sender, EventArgs e)
    {
        var articleId = Int32.Parse(Request.QueryString["Id"]);
        var tradeType = Int32.Parse(Request.QueryString["TradeType"]);

        if(tradeType == DAY_SWING_TRADE)
        {
            var premiumServices = new PremiumServices();
            premiumServices = premiumServices.GetPremiumServicesByArticle(articleId);
            TradeTypeDesc.Text = premiumServices.ArticleDesc;
        }

        if(tradeType==PERFORMANCE)
        {
            var portfolio = new VirtualPortfolio();
            portfolio = portfolio.GetPortfolioByTransactionId(articleId);
            TradeTypeDesc.Text = portfolio.Updates;
        }

    }
}
