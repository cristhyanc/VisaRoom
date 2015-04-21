using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using VisaRoom.Common.App_GlobalResources;
using VisaRoom.Common.Helper;
namespace VisaRoom.Common.Models
{
    public class UserTo
    {

        public int UserId { get; set; }

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

        [Display(Name = "lbl_Email", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource),
                  ErrorMessageResourceName = "rqd_Email")]
        [DataType(DataType.EmailAddress, ErrorMessageResourceType = typeof(Resource),
                                        ErrorMessageResourceName = "typ_Email")]
        public string Email { get; set; }

        [Display(Name = "lbl_Age", ResourceType = typeof(Resource))]
        public int Age { get; set; }

        [Display(Name = "lbl_CountryResidence", ResourceType = typeof(Resource))]
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

        [Display(Name = "lbl_CountryPassport", ResourceType = typeof(Resource))]
        public ValueTo CountryPassport { get; set; }

        [Display(Name = "lbl_JobExperience", ResourceType = typeof(Resource))]
        [StringLength(250)]
        public string JobExperience { get; set; }
        
        [Display(Name = "lbl_EnglishTest", ResourceType = typeof(Resource))]
        [StringLength(50)]
        public string EnglishTest { get; set; }

        [Display(Name = "lbl_EnglishTestScore", ResourceType = typeof(Resource))]
        [StringLength(50)]
        public string EnglishTestScore { get; set; }

        #region Languages

        private List<ValueTo> _languages { get; set; }
        [Display(Name = "lbl_PreferredLanguages", ResourceType = typeof(Resource))]
        public List<ValueTo> Languages
        {
            get
            {
                if (_languages == null || _languages.Count == 0)
                {
                    if (LanguagesIds != null && LanguagesIds.Count > 0)
                    {
                        _languages = new List<ValueTo>();
                        foreach (var item in LanguagesIds)
                        {
                            _languages.Add(new ValueTo { CodeId = item });
                        }
                        LanguagesIds = null;
                        return _languages;
                    }
                    _languages = new List<ValueTo>();
                    return _languages;
                }
                return _languages;
            }
            set
            {
                LanguagesIds = null;
                _languages = value;
            }
        }

        public List<int> LanguagesIds { get; set; }

        #endregion

        #region VisasInterested

        private List<VisasTo> _visasInterested;

        [Display(Name = "lbl_VisasInterested", ResourceType = typeof(Resource))]
        public List<VisasTo> VisasInterested
        {
            get
            {
                if (_visasInterested == null || _visasInterested.Count == 0)
                {
                    if (VisasInterestedIds != null && VisasInterestedIds.Count > 0)
                    {
                        _visasInterested = new List<VisasTo>();                       
                        foreach (var item in VisasInterestedIds)
                        {
                            _visasInterested.Add(new VisasTo { VisaId = item });
                        }
                        VisasInterestedIds = null;
                        return _visasInterested;
                    }
                    _visasInterested=new List<VisasTo>();
                    return _visasInterested;
                }
                return _visasInterested;
            }
            set
            {
                VisasInterestedIds = null;
                _visasInterested = value;
            }
        }

        public List<int> VisasInterestedIds { get; set; }

        #endregion

        [Display(Name = "lbl_PhotoProfile", ResourceType = typeof(Resource))]
        [StringLength(50)]
        public string PhotoProfile { get; set; }

        [Display(Name = "lbl_CurrentVisa", ResourceType = typeof(Resource))]
        public VisasTo CurrentVisa { get; set; }

        public enumTypeOfUsers TypeOfUser { get; set; }
    }
}
