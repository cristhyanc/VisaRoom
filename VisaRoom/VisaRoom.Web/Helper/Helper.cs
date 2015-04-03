using NGeo.GeoNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisaRoom.Common.Models;

namespace VisaRoom.Web.Helper
{
    public class Helper
    {
        
        public static IGlobalInformation getGlobalInformation()
        {
            return (IGlobalInformation)System.Web.HttpContext.Current.Application["GlobalInformation"];
        }
    }
}