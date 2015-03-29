using NGeo.GeoNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisaRoom.Web.Models;

namespace VisaRoom.Web.Helper
{
    public class Helper
    {
        public static List<Country> getCountries()
        {

            try
            {                
                var geoNamesClient = new GeoNamesClient();
                var serResult = geoNamesClient.Countries("demo");
                List<Country> result = new List<Country>();
                if (serResult != null)
                {
                    result = serResult.ToList();
                }
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}