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

        public ActionResult Applicant()
        {
            if (RedirectDashBoard(true))
            {
                return RedirectToAction("Agent", "DashBoard");
            }
            return View(Helper.Helper.CurrentUser);
        }

        public ActionResult Agent()
        {
            if (RedirectDashBoard(false))
            {
                return RedirectToAction("Applicant", "DashBoard");
            }
            return View(Helper.Helper.CurrentUser);
        }

       

    }
}
