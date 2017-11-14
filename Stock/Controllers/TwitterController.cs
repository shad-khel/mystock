using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stock.Helpers;
using Stock.Models;

namespace Stock.Controllers
{
    public class TwitterController : Controller
    {
        private IStockProvider _YahooAPI;

        public TwitterController(IStockProvider YahooAPI)
        {
            _YahooAPI = YahooAPI;
        }

        // GET: Twitter
        public ActionResult Index()
        {
            string rawJSONObject =  _YahooAPI.FetchLatestFeed();
            QueryResult LiveTwitter = new QueryResult();
            return View(LiveTwitter);
        }
    }
}