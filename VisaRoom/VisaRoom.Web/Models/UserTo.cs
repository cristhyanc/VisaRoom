using NGeo.GeoNames;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VisaRoom.Web.App_GlobalResources;

namespace VisaRoom.Web.Models
{
    public class UserTo
    {
        [Display(Name = "lbl_FirstName", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource),
                  ErrorMessageResourceName = "rqd_FirstName")]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "lbl_LastName", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource),
                  ErrorMessageResourceName = "rqd_LastName")]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "lbl_Age", ResourceType = typeof(Resource))]       
        public string Age { get; set; }

        [Display(Name = "lbl_Country", ResourceType = typeof(Resource))]
        public ValueTO Country { get; set; }

        [Display(Name = "lbl_State", ResourceType = typeof(Resource))]
        public ValueTO State { get; set; }

        [Display(Name = "lbl_City", ResourceType = typeof(Resource))]
        public ValueTO City { get; set; }

        [Display(Name = "lbl_Education", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource),
                  ErrorMessageResourceName = "rqd_LastName")]
        [StringLength(200)]
        public string Education { get; set; }

       
    }
}