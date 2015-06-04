using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPractice.Models
{
    public class QuoteRepository
    {
        public IList<Quote> QuoteList { get; set; }
    }
}