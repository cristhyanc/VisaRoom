using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisaRoom.Web.Controllers
{
    public class DashBoardController : PrivateUserController
    {
        //
        // GET: /DashBoard/

        
        public ActionResult Index()
        {
            return View();
        }

    }
}
