using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2W_lib;

namespace H2W_mvc.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private H2WtechEntities db = new H2WtechEntities();

        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View(db.tblTexts.ToList());
        }

        public ActionResult Pages()
        {
            return View(db.tblTexts.ToList());
        }

        public ActionResult Tabs()
        {
            return View(db.tblTexts.ToList());
        }

        public ActionResult Specifications()
        {
            return View(db.tblCategorySpecificSpecs.OrderBy(x => x.CategoryId).ThenBy(x => x.Sequence).ToList()); 
        }

        public ActionResult Categories()
        {
            return View(db.tblCategories);
        }


        //--------------------------------------------------------------//
        //                  Product Controllers                         //
        //--------------------------------------------------------------//

        public ActionResult ProductAdd()
        {
            var featlist = (from c in db.tblCategories where c.CategoryGroup != "" select c).ToList();
            ViewBag.featlist = featlist;
            return View();
        }

        public ActionResult ProductAddDo(int cat)
        {
            //Get a list of specIds related to the category they would like to add a product to
            var speclist = (from c in db.tblCategorySpecificSpecs where c.CategoryId == cat select c).ToList();

            //Add the product record
            tblProduct prod = new tblProduct();
            prod.CategoryId = cat;
            prod.Active = false;
            db.tblProducts.Add(prod);

            //Create a record for each specid
            foreach (var item in speclist)
            {
                tblProductSpec prodSpec = new tblProductSpec();
                prodSpec.CatSpecId = item.CSpecId;
                prodSpec.ProductId = prod.ProductId;
                prodSpec.SpecValue1 = "1";
                prodSpec.SpecValue2 = "2";
                db.tblProductSpecs.Add(prodSpec);
            }

            //Save
            db.SaveChanges();
            return RedirectToAction("ProductEdit", null, new { id = prod.ProductId });
            //return View("ProductEdit", prod.ProductId);
        }

        //
        // GET: /Admin/ProductDelete/5
        public ActionResult ProductDelete(int id = 0)
        {
            tblProduct prod = db.tblProducts.Find(id);

            if (prod == null)
            {
                return HttpNotFound();
            }
            return View(prod);
        }

        //
        // POST: /Admin/ProductDeleteConfirmed/5
        public ActionResult ProductDeleteConfirmed(int id)
        {
            tblProduct prod = db.tblProducts.Find(id);

            //Remove all the pSpecs
            foreach (var item in prod.tblProductSpecs.ToList()) {
                {
                    tblProductSpec prodspec = db.tblProductSpecs.Find(item.PSpecId);
                    db.tblProductSpecs.Remove(prodspec);
                }
            }

            db.tblProducts.Remove(prod);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        //
        // GET: /Admin/ProductList
        public ActionResult ProductList()
        {
            return View(db.tblProducts.OrderBy(x => x.CategoryId).ToList());
        }

        //
        // GET: /Admin/ProductEdit/5
        public ActionResult ProductEdit(int id = 0)
        {
            tblProduct tblProduct = db.tblProducts.Find(id);
            if (tblProduct == null)
            {
                return HttpNotFound();
            }
            return View(tblProduct);
        }

        //
        // POST: /Admin/ProductEdit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProductEdit(tblProduct tblProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ProductList");
            }
            return View(tblProduct);
        }


        //--------------------------------------------------------------//
        //                    Text/Pages Controllers                    //
        //--------------------------------------------------------------//
        //
        // GET: /Admin/Details/5
        public ActionResult Details(int id = 0)
        {
            tblText tbltext = db.tblTexts.Find(id);
            if (tbltext == null)
            {
                return HttpNotFound();
            }
            return View(tbltext);
        }

        //
        // GET: /Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Create

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(tblText tbltext)
        {
            if (ModelState.IsValid)
            {
                db.tblTexts.Add(tbltext);
                db.SaveChanges();
                return RedirectToAction("Edit", null, new { id = tbltext.ID});


            }

            return View(tbltext);
        }

        //
        // GET: /Admin/Edit/5
        public ActionResult Edit(int id = 0)
        {
            tblText tbltext = db.tblTexts.Find(id);
            if (tbltext == null)
            {
                return HttpNotFound();
            }
            return View(tbltext);
        }

        //
        // POST: /Admin/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(tblText tbltext)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbltext).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Pages");
            }
            return View(tbltext);
        }

        //
        // GET: /Admin/Delete/5
        public ActionResult Delete(int id = 0)
        {
            tblText tbltext = db.tblTexts.Find(id);
            if (tbltext == null)
            {
                return HttpNotFound();
            }
            return View(tbltext);
        }

        //
        // POST: /Admin/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tblText tbltext = db.tblTexts.Find(id);
            db.tblTexts.Remove(tbltext);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //--------------------------------------------------------------//
        //                  News Articles Controllers                   //
        //--------------------------------------------------------------//
        //
        // GET: /Admin/ArticleList
        public ActionResult ArticleList()
        {
            return View(db.tblNewsArticles.ToList());
        }
        //
        // GET: /Admin/ArticleAdd
        public ActionResult ArticleAdd()
        {
            return View("ArticleAdd");
        }
        //
        // POST: /Admin/ArticleAdd
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ArticleAdd(tblNewsArticle tblNewsArticle)
        {
            tblNewsArticle.PostedDate = DateTime.Now;
            db.tblNewsArticles.Add(tblNewsArticle);
            db.SaveChanges();
            return RedirectToAction("ArticleList");
         
        }
        //
        // GET: /Admin/ArticleEdit/5
        public ActionResult ArticleEdit(int id = 0)
        {
            tblNewsArticle article = db.tblNewsArticles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }
        //
        // POST: /Admin/ArticleEdit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ArticleEdit(tblNewsArticle tblNewsArticle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblNewsArticle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ArticleList");
            }
            return View(tblNewsArticle);
        }
        //
        // POST: /Admin/ProductDeleteConfirmed/5
        public ActionResult ArticleDelete(int id)
        {
            tblNewsArticle prod = db.tblNewsArticles.Find(id);
            db.tblNewsArticles.Remove(prod);
            db.SaveChanges();
            return RedirectToAction("ArticleList");
        }




        //--------------------------------------------------------------//
        //                    Categories Controllers                    //
        //--------------------------------------------------------------//
        //
        //
        // GET: /Admin/CategoriesEdit/5
        public ActionResult CategoriesEdit(int id = 0)
        {
            tblCategory tblCategory = db.tblCategories.Find(id);
            if (tblCategory == null)
            {
                return HttpNotFound();
            }
            return View(tblCategory);
        }

        //
        // POST: /Admin/CategoriesEdit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CategoriesEdit(tblCategory tblCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Categories");
            }
            return View(tblCategory);
        }



        //--------------------------------------------------------------//
        //                Specifications Controllers                    //
        //--------------------------------------------------------------//
        //
        // GET: /Admin/SpecEdit/5
        public ActionResult SpecEdit(int id = 0)
        {
            tblProductSpec tblProductSpec = db.tblProductSpecs.Find(id);
            if (tblProductSpec == null)
            {
                return HttpNotFound();
            }
            return View(tblProductSpec);
        }

        //
        // POST: /Admin/SpecEdit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SpecEdit(tblProductSpec tblProductSpec)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblProductSpec).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ProductEdit", null, new { id = tblProductSpec.ProductId });
            }
            return View(tblProductSpec);
        }

        // GET: /Admin/CatSpecEdit/5
        public ActionResult CatSpecEdit(int id = 0)
        {
            tblCategorySpecificSpec tblCategorySpecificSpec = db.tblCategorySpecificSpecs.Find(id);
            if (tblCategorySpecificSpec == null)
            {
                return HttpNotFound();
            }
            return View(tblCategorySpecificSpec);
        }

        //
        // POST: /Admin/CatSpecEdit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CatSpecEdit(tblCategorySpecificSpec tblCategorySpecificSpec)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblCategorySpecificSpec).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Specifications");
            }
            return View(tblCategorySpecificSpec);
        }



        //--------------------------------------------------------------//
        //                       Misc Controllers                       //
        //--------------------------------------------------------------//
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}