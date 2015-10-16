using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2W_lib;
using H2W_mvc.ViewModels;

namespace H2W_mvc
{
    public class ProductsController : Controller
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
                ViewBag.Description = MPVM.currentVM.prodrec.tblCategory.headDescription;
                ViewBag.Keywords = MPVM.currentVM.prodrec.tblCategory.headKeywords;
                //if (MPVM.currentVM.prodrec.ProductNo) ;
                //if(MPVM.currentVM.prodrec.ProductNo)

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

        public ActionResult ShowCategory(int catid)
        {
            var catrec = (from c in db.tblCategories where c.CategoryId == catid select c).FirstOrDefault();
            string redirUrl = "../category/" + catrec.CategoryPageUrl;
            return RedirectPermanent(redirUrl);
            //return View(MPVM.currentVM);
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

        public ActionResult ShowProduct(int productid)
        {
            try
            {
                ManageProductViewModel MPVM = new ManageProductViewModel(db);
                MPVM.BuildVM(productid);
                ViewBag.Title = MPVM.currentVM.prodrec.tblCategory.headTitle;
                ViewBag.Description = MPVM.currentVM.prodrec.tblCategory.headDescription;
                ViewBag.Keywords = MPVM.currentVM.prodrec.tblCategory.headKeywords;
                //if (MPVM.currentVM.prodrec.ProductNo) ;
                //if(MPVM.currentVM.prodrec.ProductNo)

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

                // I believe this is where the redirect works via the SLUG
                string redirUrl = "../product/" + MPVM.currentVM.prodrec.tblCategory.CategoryPageUrl + "/" + MPVM.currentVM.prodrec.ProductNo;
                return RedirectPermanent(redirUrl);
                //return View(MPVM.currentVM);
            }
            catch
            {
                return RedirectToAction("NoProduct", "Error");
            }
        }
        [HttpPost]
        public ActionResult ShowProduct(ProductVM vm)
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

        public ActionResult StagesIndex()
        {
            var featlist = (from c in db.tblCategories where c.CategoryGroup == "stages" select c).ToList();
            ViewBag.featlist = featlist;
            return View();
        }

        public ActionResult MotorsIndex()
        {
            var featlist = (from c in db.tblCategories where c.CategoryGroup == "motors" select c).ToList();
            ViewBag.featlist = featlist;
            return View();
        }


        public ActionResult MotorsLink(string id)
        {
            //string mp = Request.QueryString["id"].ToString();
            //Response.Redirect("http://flashvenom.com/?what2=" + id + "&what=1");
            //return View();
            var query = from c in db.tblProducts where c.ProductNo == id select c;

            if (query.Count() == 0)
            {
                return RedirectToAction("MotorNotFound", "Products", new { productid = id });
            }
            else
            {
                return RedirectToAction("ShowProduct", "Products", new { productid = query.First().ProductId });
            }
        }
        //public ActionResult Category()
        //{
        //    ViewBag.TestVar = "PASS2";
        //    return View();
        //}

        public ActionResult MotorNotFound(string productid)
        {
            ViewBag.MotorNumber = productid;
            return View();
        }

        [Authorize]
        public ActionResult Add()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }

}
