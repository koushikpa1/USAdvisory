using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.UI.PremiumServices.DAL;


namespace DStreet.USAdvisory.Business.UI.PremiumServices
{
    public class PremiumServices 
    {
        //Private member variables
        private int _articleId = 0;
        private string _articleDesc = string.Empty;
        private string _articleTitle = string.Empty;
        private DateTime _articleDateTime = DateTime.MinValue;
        private bool _isActive;
        private bool _isPaid;
        private string _ticker;


        #region IArticle Members

        public int ArticleId
        {
            get
            {
                return _articleId;
            }
            set
            {
                _articleId = value;
            }
        }

        public string ArticleTitle
        {
            get
            {
                return _articleTitle;
            }
            set
            {
                _articleTitle = value;
            }
        }

        public string ArticleDesc
        {
            get
            {
                return _articleDesc;
            }
            set
            {
                _articleDesc = value;
            }
        }

        public DateTime ArticleDate
        {
            get
            {
                return _articleDateTime;
            }
            set
            {
                _articleDateTime = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public bool IsPaid
        {
            get
            {
                return _isPaid;
            }
            set
            {
                _isPaid = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        
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

        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }

        #endregion

        public List<PremiumServices> GetPremiumServices(TradingType tradingType)
        {
            return premiumservicesDAL.GetPremiumServicesByTradingType(Int32.Parse(tradingType.ToString()));
        }

        public List<PremiumServices> GetPremiumServicesUI(int tradingType)
        {
            return premiumservicesDAL.GetPremiumServicesByTradingType(tradingType);
        }


        public List<PremiumServices> GetLatestPremiumServicesUI(int tradingType)
        {
            return premiumservicesDAL.GetLatestPremiumServicesByTradingType(tradingType);
        }

        public PremiumServices GetPremiumServicesByArticle(int _articleId)
        {
            return premiumservicesDAL.GetPremiumServicesByArticle(_articleId);
        }

        public int GetPremiumServicesArticleCount(int _TradeType)
        {
            return premiumservicesDAL.GetPremiumServicesArticleCount(_TradeType);
        }


    }
}
