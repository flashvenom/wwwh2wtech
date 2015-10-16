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
    public class SearchController : Controller
    {
        private H2WtechEntities db = new H2WtechEntities();

        //
        // GET: /Test/

        public ActionResult Results(string filter)
        {
            string searchKey = string.Empty;
            if(String.IsNullOrEmpty(filter) == false){
                searchKey = filter.ToUpper().Trim();}

                var query = from c in db.tblProducts where c.ProductNo == searchKey select c;

                if (query.Count() == 0)
                {
                    return RedirectToAction("SearchResults", "Home", new { keyword = filter });
                }
                else
                {
                    //Go to product page
                    
                    return RedirectToAction("ShowProduct", "Products", new { productid = query.First().ProductId });
                }
            }
            
        }

        //
        // GET: /Test/Details/5

    }
