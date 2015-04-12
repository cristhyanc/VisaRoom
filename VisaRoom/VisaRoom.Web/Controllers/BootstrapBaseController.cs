using System.Web.Mvc;
using BootstrapSupport;
using VisaRoom.Common.Helper;
using System.Configuration;

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
