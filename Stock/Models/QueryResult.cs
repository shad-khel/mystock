using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock.Models
{
    public class QueryResult
    {
        public string Value { get; set; }
        public string Datetime { get; set; }
        public string StockHandle { get; set; }
    }
}