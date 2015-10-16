using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2W_lib;
using H2W_mvc.ViewModels;

namespace H2W_mvc
{
    public class ProductController : Controller
    {
        //
        // GET: /Products/

        H2WtechEntities db = new H2WtechEntities();

        public ActionResult Show(string categoryurl, string productid)
        {

            try
            { 
                var prodrec = (from c in db.tblProducts where c.ProductNo == productid select c).FirstOrDefault();

                ManageProductViewModel MPVM = new ManageProductViewModel(db);
                MPVM.BuildVM(prodrec.ProductId);
                ViewBag.Title = MPVM.currentVM.prodrec.tblCategory.headTitle + " - Product Number: " + prodrec.ProductNo;
                ViewBag.Description = MPVM.currentVM.prodrec.tblCategory.headDescription + " - Product Number: " + prodrec.ProductNo;
                ViewBag.Keywords = MPVM.currentVM.prodrec.tblCategory.headKeywords;
            


                ViewBag.DivBack = "specifications1";

                if (MPVM.currentVM.prodrec.ProductNo.StartsWith("VMS"))
                {
                    ViewBag.DivBack = "vmsbox1";
                }


                if (MPVM.currentVM.prodrec.ProductNo.StartsWith("BLST"))
                {
                    ViewBag.DivBack = "blsmagbox1";
                }
                if (MPVM.currentVM.prodrec.ProductNo.StartsWith("BLDT"))
                {
                    ViewBag.DivBack = "bldmagbox1";
                }
                if (MPVM.currentVM.prodrec.ProductNo.StartsWith("BLDM"))
                {
                    ViewBag.DivBack = "bldbox1";
                }
                if (MPVM.currentVM.prodrec.ProductNo.StartsWith("BLSM"))
                {
                    ViewBag.DivBack = "blsbox1";
                }


                if (MPVM.currentVM.prodrec.ProductNo.StartsWith("NCM"))
                {
                    ViewBag.DivBack = "ncmbox1";
                }


                if (MPVM.currentVM.prodrec.ProductNo.StartsWith("VMS"))
                {
                    ViewBag.DivBack = "vmsbox1";
                }

                if (MPVM.currentVM.prodrec.ProductNo.StartsWith("STP"))
                {
                    ViewBag.DivBack = "platensbox1";
                }

                if (MPVM.currentVM.prodrec.ProductNo.StartsWith("P12"))
                {
                    ViewBag.DivBack = "platensbox1";
                }


                return View(MPVM.currentVM);
            }
            catch
            {
                return RedirectToAction("NoProduct", "Error");
            }
           
        }

        [HttpPost]
        public ActionResult Show(ProductVM vm)
        {
            if (ModelState.IsValid)
            {
                string st = "<strong>Request for Quote Form</strong><br><br>";
                st += "From: " + vm.FullName + "<br>";
                st += "Company: " + vm.Company + "<br>";
                st += "Phone: " + vm.Phone + "<br>";
                st += "Email: " + vm.Email + "<br><br>";
                st += "Product Number: " + vm.Quest1 + "<br>";
                st += "Quantity Needed: " + vm.Quest2 + "<br><br>";
                st += "Comments: " + vm.Comments + "<br>";

                Utility.SendFormEmail(st);

                return RedirectToAction("ThankYou", "Forms");
            }
            return View(vm);
        }

        public ActionResult Category(string category)
        {
            try
            {
                var catrec = (from c in db.tblCategories where c.CategoryPageUrl == category select c).FirstOrDefault();

                ManageCategoryViewModel MPVM = new ManageCategoryViewModel(db);
                MPVM.BuildVM(catrec.CategoryId);
                ViewBag.Title = MPVM.currentVM.catrec.headTitle;
                ViewBag.Description = MPVM.currentVM.catrec.headDescription;
                ViewBag.Keywords = MPVM.currentVM.catrec.headKeywords;
                return View("ShowCategory", MPVM.currentVM);
            }
            catch
            {
                return RedirectToAction("NoProduct", "Error");
            }
           
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }

}
