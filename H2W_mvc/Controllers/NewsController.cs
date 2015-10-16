using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2W_lib;
using H2W_mvc.ViewModels;

namespace H2W_mvc.Controllers
{
    public class NewsController : Controller
    {
        H2WtechEntities db = new H2WtechEntities();

        public ActionResult Show(int articleid)
        {
            ManageNewsViewModel MNVM = new ManageNewsViewModel(db);
            MNVM.BuildVM(articleid);
            return View(MNVM.currentVM);
        }

        public ActionResult Display(string slug)
        {
            try
            {
                var articlerec = (from c in db.tblNewsArticles where c.slug == slug select c).FirstOrDefault();

                ManageNewsViewModel MNVM = new ManageNewsViewModel(db);
                MNVM.BuildVM(articlerec.NewsArticleId);
                return View(MNVM.currentVM);
            }
            catch
            {
                return RedirectToAction("Error404", "Error");
            }
        }

        public ActionResult Index()
        {
            var newslist = (from c in db.tblNewsArticles select c).OrderByDescending(x => x.PostedDate).ToList();
            ViewBag.newslist = newslist;
            return View();
        }
    }
}
