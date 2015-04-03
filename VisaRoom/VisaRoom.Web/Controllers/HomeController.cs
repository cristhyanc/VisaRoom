using BootstrapMvcSample.Controllers;
using NGeo.GeoNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisaRoom.Web.Models;

namespace VisaRoom.Web.Controllers
{
    public class HomeController : BootstrapBaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }


         [AllowAnonymous]
        public ActionResult About()
        {
           
            return View();
           
        }

       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpPost]        
        [ValidateAntiForgeryToken]
        public ActionResult About(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

    }
}
