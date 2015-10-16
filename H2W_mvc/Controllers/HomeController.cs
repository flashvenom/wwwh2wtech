using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2W_mvc.Models;
using H2W_lib;

namespace H2W_mvc.Controllers
{
    public class HomeController : Controller
    {
        public H2WtechEntities db = new H2WtechEntities();

        public ActionResult Index()
        {
           
           var catlist = (from c in db.tblCategories select c).ToList();
           ViewBag.catlist = catlist;

           var newslist = (from c in db.tblNewsArticles select c).OrderByDescending(x => x.PostedDate).Take(2).ToList();
           ViewBag.newslist = newslist;

           var featlist = (from c in db.tblCategories where c.Featured==true select c).OrderBy(c => c.FeaturedSequence).ToList();
           ViewBag.featlist = featlist;

           return View();
        }

        public ActionResult News()
        {
            var newslist = (from c in db.tblNewsArticles select c).OrderByDescending(c => c.PostedDate).ToList();
            ViewBag.newslist = newslist;
            ViewBag.Message = "News and Updates";
            return View();
        }

        public ActionResult ProductSelector()
        {
            ViewBag.Message = "Product Selector";
            return View();
        }

        public ActionResult SearchResults(string keyword)
        {
            ViewBag.keyword = HttpContext.Request.QueryString["keyword"];
            return View();
        }

        public ActionResult SiteMap()
        {
            ViewBag.Message = "Site Map";
            return View();
        }

        //[Authorize(Roles="Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }


        public ActionResult Test(string product)
        {
            HomeViewModel vm = new HomeViewModel();
            return View(vm);
        }
        [HttpPost]
        public ActionResult Test(HomeViewModel vm)
        {
            if (ModelState.IsValid)
            {

            }

            return View(vm);
        }

    }
}
