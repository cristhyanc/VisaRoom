using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisaRoom.Common.Models;

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
            List<ValueTo> listStates = Web.Helper.Helper.getGlobalInformation().GetStatesByCountry(countryId);
            return Json(listStates, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetCityByState(string stateId)
        {
            List<ValueTo> listStates = Web.Helper.Helper.getGlobalInformation().GetCitiesByState(stateId);         
            return Json(listStates, JsonRequestBehavior.AllowGet);
        }

    }
}
