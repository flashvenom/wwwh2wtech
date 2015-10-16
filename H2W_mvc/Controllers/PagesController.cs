using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2W_lib;
using H2W_mvc.ViewModels;

namespace H2W_mvc
{
    public class PagesController : Controller
    {
        //Says db is already defined in the namespace... is that going to be a problem?
        H2WtechEntities db2 = new H2WtechEntities();

        public ActionResult Show(int pageid)
        {
            //ManagePageViewModel MPVM = new ManagePageViewModel(db2);
            //MPVM.BuildVM(pageid);
            //ViewBag.Title = MPVM.currentVM.textrec.section;
            //ViewBag.Description = MPVM.currentVM.textrec.section;
            //ViewBag.Keywords = MPVM.currentVM.textrec.section;

            var pagerec = (from c in db2.tblTexts where c.pageId == pageid select c).FirstOrDefault();
            string redirUrl = "../page/" + pagerec.slug;
            return RedirectPermanent(redirUrl);

            //return View(MPVM.currentVM);


        }

    }
}
