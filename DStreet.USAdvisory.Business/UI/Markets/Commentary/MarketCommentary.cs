using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.UI.Markets.Commentary.DAL;

namespace DStreet.USAdvisory.Business.UI.Markets.Commentary
{
    public class MarketCommentary
    {
        private int _marketCommentaryId;

        public int MarketCommentaryId
        {
            get { return _marketCommentaryId; }
            set { _marketCommentaryId = value; }
        }
        private string _marketCommentaryTitle = string.Empty;

        public string MarketCommentaryTitle
        {
            get { return _marketCommentaryTitle; }
            set { _marketCommentaryTitle = value; }
        }
        private DateTime _marketCommentaryDateTime = DateTime.MinValue;

        public DateTime MarketCommentaryDateTime
        {
            get { return _marketCommentaryDateTime; }
            set { _marketCommentaryDateTime = value; }
        }
        private string _marketCommentaryDecription = string.Empty;

        public string MarketCommentaryDecription
        {
            get { return _marketCommentaryDecription; }
            set { _marketCommentaryDecription = value; }
        }
        private bool _isCommentaryActive;

        public bool IsCommentaryActive
        {
            get { return _isCommentaryActive; }
            set { _isCommentaryActive = value; }
        }

        public MarketCommentary GetLatestMarketCommentary()
        {
            return commentaryUIDAL.GetAllMarketCommentaryForToday();
        }
    }
}
