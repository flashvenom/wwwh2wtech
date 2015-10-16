using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2W_lib;
using H2W_mvc.ViewModels;

namespace H2W_mvc
{
    public class PageController : Controller
    {
        //
        // GET: /Products/

        H2WtechEntities db = new H2WtechEntities();

        public ActionResult Show(string pagename)
        {
            // Redirect for moved pages
            switch(pagename)
            {
                case "formulas":
                    return RedirectPermanent("../page/calculator");
            }

            try {
                var pagerec = (from c in db.tblTexts where c.slug == pagename select c).FirstOrDefault();
                ManagePageViewModel MPVM = new ManagePageViewModel(db);
                MPVM.BuildVM(Convert.ToInt32(pagerec.pageId));
                ViewBag.Title = MPVM.currentVM.textrec.section;
                ViewBag.Description = MPVM.currentVM.textrec.description;
                ViewBag.Keywords = MPVM.currentVM.textrec.keywords;
                return View(MPVM.currentVM);
            }
            catch
            {
                return RedirectToAction("Error404", "Error");
            }

        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }

}
