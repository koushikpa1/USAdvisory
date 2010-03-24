using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.Admin.Portfolio.DAL;

namespace DStreet.USAdvisory.Business.Admin.Portfolio
{
    public class portfoliolisting
    {

        //Private member variables
        private int _stockTransactionId = 0;
        private int _portfolioId;
        private DateTime _portfolioEntryDate = DateTime.MinValue;
        private DateTime _portfolioExitDate = DateTime.MinValue;
        private char _callStatus;
        private string _ticker;
        private bool _isPartiallyExited;

        //Commentary Listing
        public List<portfoliolisting> GetAllPortfolio()
        {
            return portfolioDAL.GetAllPortfolio();
        }

        public List<portfoliolisting> GetPortfolioFilterData(string filterData)
        {
            return portfolioDAL.GetPortfolioFilterData(filterData);
        }

        public int StockTransactionId
        {
            get
            {
                return _stockTransactionId;
            }
            set
            {
                _stockTransactionId = value;
            }
        }

        public DateTime PortfolioEntryDate
        {
            get
            {
                return _portfolioEntryDate;
            }
            set
            {
                _portfolioEntryDate = value;
            }
        }

        public DateTime PortfolioExitDate
        {
            get
            {
                return _portfolioExitDate;
            }
            set
            {
                _portfolioExitDate = value;
            }
        }

        public bool IsPartiallyExited
        {
            get
            {
                return _isPartiallyExited;
            }
            set
            {
                _isPartiallyExited = value;
            }
        }

        public char CallStatus
        {
            get
            {
                return _callStatus;
            }
            set
            {
                _callStatus = value;
            }
        }

        public int PortfolioId
        {
            get
            {
                return _portfolioId;
            }
            set
            {
                _portfolioId = value;
            }
        }

        public string Ticker
        {
            get
            {
                return _ticker;
            }
            set
            {
                _ticker = value;
            }
        }


        private int _qty;

        public int Qty
        {

            get { return _qty; }
            set { _qty = value; }

        }


    }

}
