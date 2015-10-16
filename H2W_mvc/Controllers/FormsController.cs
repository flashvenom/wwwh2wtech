using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
using H2W_mvc.Models;
using H2W_lib;

namespace H2W_mvc.Controllers
{
    public class FormsController : Controller
    {
        //
        // GET: /Forms/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ThankYou()
        {
            return View();
        }


        public ActionResult LinearMotorsWorksheet()
        {
            LinearMotorsWorksheet vm = new LinearMotorsWorksheet();
            return View(vm);
        }
        [HttpPost]
        public ActionResult LinearMotorsWorksheet(LinearMotorsWorksheet vm)
        {
            if (ModelState.IsValid)
            {
                string st = "<strong>Positioning Stage</strong><br><br>";
                st += "From: " + vm.FullName + "<br>";
                st += "Company: " + vm.Company + "<br>";
                st += "Phone: " + vm.Phone + "<br>";
                st += "Email: " + vm.Email + "<br><br>";
                st += "What force is required?  " + vm.Quest1 + " " + vm.Quest1ddl + "<br>";
                st += "What is the weight of your payload? " + vm.Quest2 + " " + vm.Quest2ddl + "<br>";
                st += "What is the required acceleration? " + vm.Quest3 + "[g's]<br>";
                st += "What is the time required to complete the travel? " + vm.Quest4 + "[sec]<br>";
                st += "What is the total required travel? " + vm.Quest5 + " " + vm.Quest5ddl + "<br>";
                st += "What is the duty cycle for force or acceleration required? " + vm.Quest6 + "[%]<br>";
                st += "What is the required velocity? " + vm.Quest7 + " " + vm.Quest7ddl + "<br>";
                st += "Open or closed loop operation? " + vm.Quest8 + "<br>";
                st += "Horizontal or vertical orientation? " + vm.Quest12 + "<br>";
                st += "Does your motor require bearings? " + vm.Quest9 + "<br>";
                st += "What are the ambient conditions of the application? " + vm.Quest10 + "<br>";
                st += "What is the available power source? " + vm.Quest11 + " " + vm.Quest11ddl + "<br>";
                st += "Comments: " + vm.Comments + "<br>";

                Utility.SendFormEmail(st);

                return RedirectToAction("ThankYou");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult RotaryMotorsWorksheet()
        {
            RotaryMotorsWorksheet vm = new RotaryMotorsWorksheet();
            return View(vm);
        }
        [HttpPost]
        public ActionResult RotaryMotorsWorksheet(RotaryMotorsWorksheet vm)
        {
            if (ModelState.IsValid)
            {
                string st = "<strong>Rotary Motors Worksheet</strong><br><br>";
                st += "From: " + vm.FullName + "<br>";
                st += "Company: " + vm.Company + "<br>";
                st += "Phone: " + vm.Phone + "<br>";
                st += "Email: " + vm.Email + "<br><br>";
                st += "What is your total angular excursion? " + vm.Quest1 + " [degrees]<br>";
                st += "What is the inertia of your payload? " + vm.Quest2 + " [oz-in-sec]<br>";
                st += "What is the required speed? " + vm.Quest3 + " [rpm]<br>";
                st += "What is the time required to complete the rotation? " + vm.Quest4 + " [sec]<br>";
                st += "What is the required angular acceleration? " + vm.Quest5 + " [rad/sec<sup>2</sup>]<br>";
                st += "What continuous torque is required? " + vm.Quest6 + " "+ vm.Quest6ddl + "<br>";
                st += "What is the peak torque is required? " + vm.Quest7 + " " + vm.Quest7ddl + "<br>";
                st += "What is the duty cycle for torque or acceleration required? " + vm.Quest8 + " %<br>";
                st += "Is position feedback required?  " + vm.Quest9 + "<br>";
                st += "What is the required accuracy?  " + vm.Quest10 + " " + vm.Quest10ddl + "<br>";
                st += "What is the required repeatability? " + vm.Quest11 + " " + vm.Quest11ddl + "<br>";
                st += "What are the ambient conditions of the application?  " + vm.Quest12 + " " + vm.Quest12ddl + "<br>";
                st += "What is the available continuous current (amps)?  " + vm.Quest13 + " " + vm.Quest13ddl + "<br>";

                st += "Comments: " + vm.Comments + "<br>";

                Utility.SendFormEmail(st);

                return RedirectToAction("ThankYou");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        public ActionResult PositioningStagesWorksheet()
        {
            PositioningStagesWorksheet vm = new PositioningStagesWorksheet();
            return View(vm);
        }
        [HttpPost]
        public ActionResult PositioningStagesWorksheet(PositioningStagesWorksheet vm)
        {
            if (ModelState.IsValid)
            {
                string st = "<strong>Positioning Stage</strong><br><br>";
                st += "From: " + vm.FullName + "<br>";
                st += "Company: " + vm.Company + "<br>";
                st += "Phone: " + vm.Phone + "<br>";
                st += "Email: " + vm.Email + "<br><br>";
                st += "What force is required?  " + vm.Quest1 + " " + vm.Quest1ddl + "<br>";
                st += "What is the weight of your payload? " + vm.Quest2 + " " + vm.Quest2ddl + "<br>";
                st += "What is the required acceleration? " + vm.Quest3 + "<br>";
                st += "What is the time required to complete the travel? " + vm.Quest4 + "<br>";
                st += "What is the total required travel? " + vm.Quest5 + " " + vm.Quest5ddl + "<br>";
                st += "What is the duty cycle for force or acceleration required? " + vm.Quest6 + "<br>";
                st += "What is the required velocity? " + vm.Quest7 + " " + vm.Quest7ddl + "<br>";
                st += "What is the required accuracy? " + vm.Quest8 + " " + vm.Quest8ddl + "<br>";
                st += "What is the required repeatability? " + vm.Quest9 + " " + vm.Quest9ddl + "<br>";
                st += "What is the required flatness of motion? " + vm.Quest10 + " " + vm.Quest10ddl + "<br>";
                st += "What is the required straightness of motion? " + vm.Quest11 + " " + vm.Quest12ddl + "<br>";
                st += "What are the ambient conditions for the application? " + vm.Quest13 + "<br>";
                st += "What is the available continuous current (amps)? " + vm.Quest14 + " " + vm.Quest14ddl + "<br>";
                st += "Horizontal or vertical orientation? " + vm.Quest15 + "<br>";
                st += "What are the ambient conditions of the application? " + vm.Quest16 + "<br>";

                st += "Comments: " + vm.Comments + "<br>";

                Utility.SendFormEmail(st);

                return RedirectToAction("ThankYou");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult RequestForQuoteForm(string productNo, string catID)
        {
            RequestForQuoteForm vm = new RequestForQuoteForm();
            ViewBag.productNo = HttpContext.Request.QueryString["productNo"];
            ViewBag.catID = HttpContext.Request.QueryString["cat"];
            return View(vm);
        }
        [HttpPost]
        public ActionResult RequestForQuoteForm(RequestForQuoteForm vm)
        {
            if (ModelState.IsValid)
            {
                string st = "<strong>Request for Quote Form</strong><br><br>";
                st += "From: " + vm.FullName + "<br>";
                st += "Company: " + vm.Company + "<br>";
                st += "Phone: " + vm.Phone + "<br>";
                st += "Email: " + vm.Email + "<br><br>";
                st += "Interest in Product Number: " + vm.Quest1 + "<br>";
                st += "Interested in Category: " + vm.Quest2 + "<br>";
                st += "Quantity Needed: " + vm.Quest3 + "<br><br>";
                st += "Comments: " + vm.Comments + "<br>";

                Utility.SendFormEmail(st);

                return RedirectToAction("ThankYou");
            }
            return View(vm);
        }
    }

}