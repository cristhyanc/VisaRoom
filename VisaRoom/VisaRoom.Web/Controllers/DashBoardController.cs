using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisaRoom.Web.ViewModel;

namespace VisaRoom.Web.Controllers
{
    public class DashBoardController : PrivateUserController
    {
        //
        // GET: /DashBoard/

        public ActionResult Applicant()
        {
            DashBoardViewModel model = new DashBoardViewModel(Helper.Helper.CurrentUser);
            if (RedirectDashBoard(true))
            {
                return RedirectToAction("Agent", "DashBoard");
            }
            return View(model);
        }

        public ActionResult Agent()
        {
            DashBoardViewModel model = new DashBoardViewModel(Helper.Helper.CurrentUser);
            if (RedirectDashBoard(false))
            {
                return RedirectToAction("Applicant", "DashBoard");
            }
            return View(model);
        }

        public ActionResult Questions()
        {
            DashBoardViewModel model = new DashBoardViewModel(Helper.Helper.CurrentUser);
            return View(model);
        }

       

    }
}
