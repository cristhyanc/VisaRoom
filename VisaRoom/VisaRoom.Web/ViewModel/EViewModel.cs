using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisaRoom.Web.Models;

namespace VisaRoom.Web.ViewModel
{
    public class EViewModel
    {
        public System.Web.Mvc.SelectList Countries;

        public UserTo User { get; set; }

        public int countryID { get; set; }
    }
}