﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.UI.Markets.WatchOut.DAL;


namespace DStreet.USAdvisory.Business.UI.Markets.WatchOut
{
    public class WatchOutNews 
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

        public List<WatchOutNews> GetWatchOutNews()
        {
            return watchoutDAL.GetAllWatchOutNews();
        }
    }
}
