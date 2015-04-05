using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisaRoom.Common.Models;

namespace VisaRoom.Web.Helper
{
    public interface IGlobalInformation
    {
        List<ValueTo> GetCountries();

        ValueTo GetCountry(string countryId);

        List<ValueTo> GetCitiesByState(string cityId);

        List<ValueTo> GetStatesByCountry(string countryId);

        List<ValueTo> GetMaritalStates();

        List<ValueTo> GetLanguages();

    }
}
