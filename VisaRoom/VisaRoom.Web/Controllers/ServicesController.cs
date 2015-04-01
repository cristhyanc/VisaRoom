using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisaRoom.Web.Models;

namespace VisaRoom.Web.Controllers
{
    public class ServicesController : Controller
    {
        //
        // GET: /Services/

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetStatesByCountryId(string countryId)
        {
            List<ValueTO> listStates = Helper.Helper.getState(Int32.Parse(countryId));
            List<SelectListItem> states = new List<SelectListItem>();
            return Json(listStates, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetCityByState(string stateId)
        {
            List<ValueTO> listStates = Helper.Helper.getState(Int32.Parse(stateId));
            List<SelectListItem> states = new List<SelectListItem>();
            return Json(listStates, JsonRequestBehavior.AllowGet);
        }

    }
}
