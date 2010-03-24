using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.Admin.Markets.NewsViews.DAL;


namespace DStreet.USAdvisory.Business.Admin.Markets.NewsViews
{

    public class newsviewsedit : IArticle
    {
        //Private member variables
        private int _articleId = 0;
        private string _articleDesc = string.Empty;
        private string _articleTitle = string.Empty;
        private DateTime _articleDateTime = DateTime.MinValue;
        private bool _isActive;
        private bool _isPaid;
        private string _ticker;


        /// <summary>
        /// 
        /// </summary>
        public newsviewsedit()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="articleTitle"></param>
        /// <param name="articleDesc"></param>
        /// <param name="articleDateTime"></param>
        /// <param name="isActive"></param>
        public newsviewsedit(string articleTitle, string articleDesc, DateTime articleDateTime,bool isActive, bool isPaid, string ticker)
        {
            this._articleTitle = articleTitle;
            this._articleDesc = articleDesc;
            this._articleDateTime = articleDateTime;
            this._isActive = isActive;
            this._isPaid = isPaid;
            this._ticker = ticker;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_articleId"></param>
        public newsviewslisting GetNewsViewsByArticle(int _articleId)
        {
            return newsviewsDAL.GetNewsViewsByArticle(_articleId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        public void UpdateNewsViews(int newsId)
        {
            this._articleId = newsId;
            newsviewsDAL.UpdateNewsViews(newsId, _articleTitle, _articleDesc, _isActive,_isPaid, _ticker);
        }

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

    }
}
