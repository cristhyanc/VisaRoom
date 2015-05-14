using BootstrapMvcSample.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisaRoom.Web.Helper;

namespace VisaRoom.Web.Controllers
{
    [SessionExpireFilter]
    public class PrivateUserController : BaseController
    {

        public PrivateUserController()
        {
        }

        protected bool RedirectDashBoard(bool fromApplicant)
        {
            if (Helper.Helper.CurrentUser != null)
            {
                if (Helper.Helper.CurrentUser.TypeOfUser == Common.Helper.enumTypeOfUsers.Applicant && !fromApplicant)
                {
                    return true;
                }
                if (Helper.Helper.CurrentUser.TypeOfUser == Common.Helper.enumTypeOfUsers.Agent && fromApplicant)
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}