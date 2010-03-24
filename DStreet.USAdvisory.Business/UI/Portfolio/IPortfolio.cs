using System;
namespace DStreet.USAdvisory.Business.UI.Portfolio
{
   public interface IPortfolio
    {
        int StockTransactionId { get; set; }
        int BuyOrSellId { get; set; }
        char CallStatus { get; set; }
        string CompanyName { get; set; }
        decimal EntryPrice { get; set; }
        decimal ExitPrice { get; set; }
        bool IsPartiallyExited { get; set; }
        DateTime PortfolioEntryDate { get; set; }
        DateTime PortfolioExitDate { get; set; }
        int PortfolioId { get; set; }
        string StockTicker { get; set; }
        decimal StopLoss { get; set; }
        DateTime UpdateDateTime { get; set; }
        string Updates { get; set; }
        int Qty { get; set; } 
    }
}
