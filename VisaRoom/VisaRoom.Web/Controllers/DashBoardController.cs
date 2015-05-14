using BusinessLogic.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisaRoom.Web.App_GlobalResources;
using VisaRoom.Web.ViewModel;

namespace VisaRoom.Web.Controllers
{
    [AllowAnonymous]
    public class DashBoardController : PrivateUserController
    {
        
        public DashBoardController()
        {
        }
        //
        // GET: /DashBoard/
        [AllowAnonymous]
        public ActionResult Applicant()
        {
            DashBoardViewModel model = new DashBoardViewModel(Helper.Helper.CurrentUser);
            if (RedirectDashBoard(true))
            {
                return RedirectToAction("Agent", "DashBoard");
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Agent()
        {
            DashBoardViewModel model = new DashBoardViewModel(Helper.Helper.CurrentUser);
            if (RedirectDashBoard(false))
            {
                return RedirectToAction("Applicant", "DashBoard");
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Questions()
        {
            DashBoardViewModel model = new DashBoardViewModel(Helper.Helper.CurrentUser);
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Questions(DashBoardViewModel model)
        {
            try
            {
                if (ModelState.ContainsKey("CurrentUser.FirstName"))
                {
                    ModelState["CurrentUser.FirstName"].Errors.Clear();
                }
                if (ModelState.ContainsKey("CurrentUser.LastName"))
                {
                    ModelState["CurrentUser.LastName"].Errors.Clear();
                }
                if (ModelState.ContainsKey("CurrentUser.Email"))
                {
                    ModelState["CurrentUser.Email"].Errors.Clear();
                }
                if (ModelState.ContainsKey("CurrentUser.MarnNumber"))
                {
                    ModelState["CurrentUser.MarnNumber"].Errors.Clear();
                }
                IBLUser bl = new BLUser(this.LogError.SLogPath);
                if (ModelState.IsValid)
                {
                    bl.SaveQuestion(model.NewQuestion, model.CurrentUser.UserId);
                }

                model = new DashBoardViewModel(Helper.Helper.CurrentUser);

            }
            catch (Exception ex)
            {
                ProcessExection("Web.DashBoardController.Questions", ex, Resource.Error_SaveQuestion);
            }
            return View(model);
        }



       
    }
}
