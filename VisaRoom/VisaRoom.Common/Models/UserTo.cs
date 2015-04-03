using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using VisaRoom.Common.App_GlobalResources;
namespace VisaRoom.Common.Models
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
        public ValueTo Country { get; set; }

        [Display(Name = "lbl_State", ResourceType = typeof(Resource))]
        public ValueTo State { get; set; }

        [Display(Name = "lbl_City", ResourceType = typeof(Resource))]
        public ValueTo City { get; set; }

        [Display(Name = "lbl_Education", ResourceType = typeof(Resource))]
        [StringLength(200)]
        public string Education { get; set; }

        [Display(Name = "lbl_DateofGraduation", ResourceType = typeof(Resource))]
        [DataType(DataType.Date)]
        public DateTime DateOfGraduation { get; set; }

        [Display(Name = "lbl_MaritalStatus", ResourceType = typeof(Resource))]
        public ValueTo MaritalStatus { get; set; }
    }
}
