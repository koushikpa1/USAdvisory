using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DStreet.USAdvisory.Business.Admin.Markets.Commentary.DAL;

namespace DStreet.USAdvisory.Business.Admin.Markets.Commentary
{
    public class commentaryadd : IArticle
    {
        //Private member variables
        private int _articleId = 0;
        private string _articleDesc = string.Empty;
        private string _articleTitle = string.Empty;
        private DateTime _articleDateTime = DateTime.MinValue;
        private bool _isActive;

        public commentaryadd(string articleTitle,string articleDesc, DateTime articleDateTime,bool isActive)
        {
            this._articleTitle = articleTitle;
            this._articleDesc = articleDesc;
            this._articleDateTime = articleDateTime;
            this._isActive = isActive;
        }
        
        public void AddMarketCommentary()
        {
            commentaryDAL.AddNewMarketCommentary(this);
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
