using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisaRoom.Common.Models;
using VisaRoom.Web.Models;

namespace VisaRoom.Web.ViewModel
{
    public class RegisterAgentViewModel
    {
         public SelectList ListCountries { get; set; }
        public SelectList ListMaritalStatus { get; set; }
        public MultiSelectList ListLanguage { get; set; }
        public MultiSelectList ListVisaApplicant { get; set; }
        public RegisterModel Register { get; set; }
        public HttpPostedFileBase archivo { get; set; }
        public RegisterAgentViewModel()
        {
            List<ValueTo> listCountries = Helper.Helper.getGlobalInformation().GetCountries();
            List<ValueTo> listMaritalStatus = Helper.Helper.getGlobalInformation().GetMaritalStates();
            List<ValueTo> listLanguage = Helper.Helper.getGlobalInformation().GetLanguages();
            List<VisasTo> listVisaApplicant = Helper.Helper.getGlobalInformation().GetAgentVisasList();

            ListCountries = new SelectList(listCountries, "Value", "Text");
            ListMaritalStatus = new SelectList(listMaritalStatus, "Value", "Text");
            ListLanguage = new MultiSelectList(listLanguage, "CodeId", "Text");
            ListVisaApplicant = new SelectList(listVisaApplicant, "VisaId", "Name");
            Register = new RegisterModel();
        }

    }
}