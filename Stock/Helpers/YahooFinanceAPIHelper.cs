using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock.Helpers
{
    public class YahooFinanceAPIHelper : IStockProvider
    {
        
        const string YahooURI = "";
        const string TwitterSymbol = "TWTR";
        const string YahooSymbol = "YHOO";

        public string FetchLatestFeed()
        {
            string YQL = $"select * from yahoo.finance.quotes where symbol in (\"{YahooSymbol}\")";

            throw new NotImplementedException();
        }

    }
}