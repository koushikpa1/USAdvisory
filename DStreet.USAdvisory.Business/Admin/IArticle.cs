using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DStreet.USAdvisory.Business.Admin
{
    public interface IArticle
    {
       int ArticleId {get;set;}
       string  ArticleTitle {get;set;}
       string ArticleDesc { get; set; }
       DateTime ArticleDate { get; set; }
       bool IsActive { get; set; }
    }
}
