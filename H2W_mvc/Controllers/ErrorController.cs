using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2W_lib;
using H2W_mvc.ViewModels;

namespace H2W_mvc
{
    public class ErrorController : Controller
    {
        //
        // GET: /Products/

        H2WtechEntities db = new H2WtechEntities();

        public ActionResult Index()
        {   
            return View();
        }

        public ActionResult Error404()
        {
            Response.Status = "404 Not Found";
            Response.StatusCode = 404;
            return View();
        }

        public ActionResult NoProduct()
        {
            return View();
        }

        public ActionResult Error500()
        {
            Response.Status = "500 Server Error";
            Response.StatusCode = 500;
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }

}
