using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Portfolio;

public partial class admin_Portfolio_Editportfolioitem : System.Web.UI.Page
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            portfolioedit _portfolioEdit = new portfolioedit();
            portfoliolisting _listing = new portfoliolisting();
            _portfolioEdit = _portfolioEdit.GetPortfolioByTicker(Int32.Parse(Request.QueryString["id"].ToString()));
            PortfolioId.Text = _portfolioEdit.PortfolioId.ToString();
            CompanyName.Text = _portfolioEdit.CompanyName.ToString();
            txtQty.Text = _portfolioEdit.Qty.ToString();
            txtCallStatus.Text = _portfolioEdit.CallStatus.ToString();
            txtBuyOrSellId.Text = _portfolioEdit.BuyOrSellId.ToString();
            txtEntryDate.Text = _portfolioEdit.PortfolioEntryDate.ToString();
            txtExitDate.Text = _portfolioEdit.PortfolioExitDate.ToString();
            txtStopLoss.Text = _portfolioEdit.StopLoss.ToString();
            txtTicker.Text = _portfolioEdit.StockTicker.ToString();
            txtEntryPrice.Text = _portfolioEdit.EntryPrice.ToString();
            txtExitPrice.Text = _portfolioEdit.ExitPrice.ToString();
            isPartiallyExited.Checked = _portfolioEdit.IsPartiallyExited;
            txtBuyOrSell.Text = _portfolioEdit.BuyOrSellId.ToString();
            fckcontent.Value = _portfolioEdit.Updates.ToString();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isPartiallyExited = false;

        if (isPartiallyExited.Checked)
            _isPartiallyExited = true;

        portfolioedit _portfolioAdd = new portfolioedit();
        _portfolioAdd.PortfolioId = int.Parse(PortfolioId.Text);
        _portfolioAdd.BuyOrSellId = int.Parse(txtBuyOrSellId.Text);
        _portfolioAdd.CompanyName = CompanyName.Text;
        _portfolioAdd.StockTicker = txtTicker.Text;
        _portfolioAdd.CallStatus = char.Parse(txtCallStatus.Text);
        _portfolioAdd.Qty = Int32.Parse(txtQty.Text.Trim());
        _portfolioAdd.EntryPrice = decimal.Parse(txtEntryPrice.Text);
        _portfolioAdd.ExitPrice = decimal.Parse(txtExitPrice.Text);
        _portfolioAdd.StopLoss = decimal.Parse(txtStopLoss.Text);
        _portfolioAdd.PortfolioEntryDate = DateTime.Parse(txtEntryDate.Text);
        _portfolioAdd.PortfolioExitDate = DateTime.Parse(txtExitDate.Text);
        _portfolioAdd.IsPartiallyExited = _isPartiallyExited;
        _portfolioAdd.Updates = fckcontent.Value;
        _portfolioAdd.UpdatePortfolio(Int32.Parse(Request.QueryString["id"].ToString()));
        Response.Redirect("portfoliolisting.aspx");
    }
}
