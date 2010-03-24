using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Portfolio;

public partial class admin_Portfolio_Addnewportfolioitem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Session["admin"].ToString()))
            Response.Redirect("~/LogMeIn.aspx");

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isPartiallyExited = false;

        if (isPartiallyExited.Checked)
            _isPartiallyExited = true;

        portfolioadd _portfolioAdd = new portfolioadd();
        _portfolioAdd.PortfolioId = int.Parse(PortfolioId.Text.Trim());
        _portfolioAdd.CompanyName = CompanyName.Text.Trim();
        _portfolioAdd.StockTicker = txtTicker.Text.Trim();
        _portfolioAdd.CallStatus = char.Parse(txtCallStatus.Text.Trim());
        _portfolioAdd.Qty = Int32.Parse(txtQty.Text.Trim());
        _portfolioAdd.EntryPrice = decimal.Parse(txtEntryPrice.Text.Trim());
        _portfolioAdd.ExitPrice = decimal.Parse(txtExitPrice.Text.Trim());
        _portfolioAdd.StopLoss = decimal.Parse(txtStopLoss.Text.Trim());
        _portfolioAdd.PortfolioEntryDate = DateTime.Parse(txtEntryDate.Text.Trim());
        _portfolioAdd.PortfolioExitDate = DateTime.Parse(txtExitDate.Text.Trim());
        _portfolioAdd.IsPartiallyExited = _isPartiallyExited;
        _portfolioAdd.Updates = fckcontent.Value.Trim();
        _portfolioAdd.BuyOrSellId = Int32.Parse(txtBuyOrSell.Text.Trim());
        _portfolioAdd.AddPortfolio();
        Response.Redirect("portfoliolisting.aspx");

    }
}
