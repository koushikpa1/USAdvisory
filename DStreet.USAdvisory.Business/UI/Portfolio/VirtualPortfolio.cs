using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.UI.Portfolio.DAL;

namespace DStreet.USAdvisory.Business.UI.Portfolio
{
    public class VirtualPortfolio : IPortfolio
   {
        public List<VirtualPortfolio> GetAllPortfolio(string openOrClose)
       {
           return portfolioDAL.GetAllPortfolio(openOrClose);
       }

       private int _portfolioId = 1;

       public int PortfolioId
       {
           get { return _portfolioId; }
           set { _portfolioId = value; }
       }
       private string _companyName = string.Empty;

       public string CompanyName
       {
           get { return _companyName; }
           set { _companyName = value; }
       }
       private string _stockTicker = string.Empty;

       public string StockTicker
       {
           get { return _stockTicker; }
           set { _stockTicker = value; }
       }
       private int _buyOrSellId = 0;

       public int BuyOrSellId
       {
           get { return _buyOrSellId; }
           set { _buyOrSellId = value; }
       }
       private decimal _entryPrice;

       public decimal EntryPrice
       {
           get { return _entryPrice; }
           set { _entryPrice = value; }
       }
       private decimal _exitPrice;

       public decimal ExitPrice
       {
           get { return _exitPrice; }
           set { _exitPrice = value; }
       }
       private decimal _stopLoss;

       public decimal StopLoss
       {
           get { return _stopLoss; }
           set { _stopLoss = value; }
       }
       private string _updates = string.Empty;

       public string Updates
       {
           get { return _updates; }
           set { _updates = value; }
       }
       private DateTime _updateDateTime = DateTime.MinValue;

       public DateTime UpdateDateTime
       {
           get { return _updateDateTime; }
           set { _updateDateTime = value; }
       }
       private DateTime _portfolioEntryDate = DateTime.MinValue;

       public DateTime PortfolioEntryDate
       {
           get { return _portfolioEntryDate; }
           set { _portfolioEntryDate = value; }
       }
       private DateTime _portfolioExitDate = DateTime.MinValue;

       public DateTime PortfolioExitDate
       {
           get { return _portfolioExitDate; }
           set { _portfolioExitDate = value; }
       }
       private char _callStatus;//-- 0 is open and 1 is close

       public char CallStatus
       {
           get { return _callStatus; }
           set { _callStatus = value; }
       }

       private bool _isPartiallyExited;

       public bool IsPartiallyExited
       {
           get { return _isPartiallyExited; }
           set { _isPartiallyExited = value; }
       }

       #region IPortfolio Members

       private int _stockTransactionId;
       
       public int StockTransactionId
       {

           get { return _stockTransactionId; }
           set { _stockTransactionId = value; }
       
       }

       private int _qty;

       public int Qty
       {

           get { return _qty; }
           set { _qty = value; }

       }

       #endregion
   }
}
