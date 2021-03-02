using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RedditAPILab.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RedditAPILab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RedditDAL rdd = new RedditDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Error(string message)
        //{
        //    return View(message);
        //}

        public IActionResult TopTen(string subreddit)
        {
            TempData["sub"] = subreddit;

            SubRedditRoot srr = rdd.GetPosts(subreddit);
            
            Child[] childrens = srr.data.children;
            List<Child> c = childrens.ToList();
            if(c.Count == 1)
            {
                Child ch = c[0];
                TempData["error"] = subreddit + " does not exist. Please try again.";
            }
            if(c.Count == 0)
            {
                TempData["error"] = subreddit +" does not exist. Please try again.";
                return RedirectToAction("Index");
            }

            return View(c);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
