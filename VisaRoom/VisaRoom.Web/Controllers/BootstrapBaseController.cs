using System.Web.Mvc;
using BootstrapSupport;
using VisaRoom.Common.Helper;
using System.Configuration;
using System;

namespace BootstrapMvcSample.Controllers
{
    public class BootstrapBaseController: Controller
    {

        VisaRoomLogError _log;
        public VisaRoomLogError LogError
        {
            get
            {
                if (_log == null)
                {
                    _log = new VisaRoomLogError(Server.MapPath("~") + ConfigurationManager.AppSettings["logFolder"]);
                }
                return _log;
            }
        }

        protected void ProcessExection(string module, Exception ex, string errorMessage)
        {

            LogError.ErrorLog(module, ex);
            if (ex.InnerException != null && ex.InnerException.Source.Equals(Helper.APPLICATION_NAME))
            {
                errorMessage = ex.Message;
            }
            this.Error(errorMessage);
        }

        public void Attention(string message)
        {
            TempData.Add(Alerts.ATTENTION, message);
        }

        public void Success(string message)
        {
            TempData.Add(Alerts.SUCCESS, message);
        }

        public void Information(string message)
        {
            TempData.Add(Alerts.INFORMATION, message);
        }

        public void Error(string message)
        {
            TempData.Add(Alerts.ERROR, message);
        }
    }
}
