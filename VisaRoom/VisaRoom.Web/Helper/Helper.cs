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
        
        public static GlobalInformation getGlobalInformation()
        {
            return (GlobalInformation)System.Web.HttpContext.Current.Application["GlobalInformation"];
        }

        

        public static UserTo CurrentUser
        {
            get
            {
                var us = new UserTo();
                if (HttpContext.Current.Session["userDetails"] != null)
                {
                    us =(UserTo)HttpContext.Current.Session["userDetails"];
                    return us;
                }

                return null;

            }
            set
            {
                HttpContext.Current.Session["userDetails"] = value;
            }
        }
    }
}