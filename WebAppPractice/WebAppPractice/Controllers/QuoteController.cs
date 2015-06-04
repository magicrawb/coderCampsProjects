using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPractice.Models;

namespace WebAppPractice.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        [ChildActionOnly]
        public ActionResult GetQuote()
        {
            Quote seuss1 = new Quote();
            seuss1.FullQuote = "Today you are you! That is truer than true! There is no one alive who is you-er than you!";
            seuss1.Author = "Dr. Seuss";

            Quote einstein1 = new Quote();
            einstein1.FullQuote = "Insanity: doing the same thing over and over again and expecting different results.";
            einstein1.Author = "Albert Einstein";

            Quote buddha1 = new Quote();
            buddha1.FullQuote = "Do not dwell in the past, do not dream of the future, concentrate the mind on the present moment.";
            buddha1.Author = "Buddha";

            IList<Quote> QuoteList = new List<Quote>();

            QuoteList.Add(seuss1);
            QuoteList.Add(einstein1);
            QuoteList.Add(buddha1);

            Random rnd = new Random();
            rnd.Next(QuoteList.Count());

            return View();
        }
    }
}