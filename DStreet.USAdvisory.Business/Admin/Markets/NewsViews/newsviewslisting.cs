﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.Admin.Markets.NewsViews.DAL;

namespace DStreet.USAdvisory.Business.Admin.Markets.NewsViews
{
        public class newsviewslisting : IArticle
        {
            //Private member variables
            private int _articleId = 0;
            private string _articleDesc = string.Empty;
            private string _articleTitle = string.Empty;
            private DateTime _articleDateTime = DateTime.MinValue;
            private bool _isPaid;
            private bool _isActive;
            private string _ticker;

            //Commentary Listing
            public List<newsviewslisting> GetAllNewsViews()
            {
                return newsviewsDAL.GetAllNewsViews();
            }

            public List<newsviewslisting> GetNewsViewsFilterData(string filterData)
            {
                return newsviewsDAL.GetNewsViewsFilterData(filterData);
            }

            //Article Properties

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

            #endregion


            #region IArticle Members

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



