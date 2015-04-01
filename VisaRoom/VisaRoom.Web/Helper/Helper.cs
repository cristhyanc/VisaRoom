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
                var serResult = geoNamesClient.Countries("cristhyan17");
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

        public static List<ValueTO> getCity(int stateId)
        {
            return getChildren(stateId);
        }

        public static List<ValueTO> getState(int countryId)
        {
            return getChildren(countryId);
        }

        private static List<ValueTO> getChildren(int parentId)
        {

            try
            {
                var geoNamesClient = new GeoNamesClient();
                var serResult = geoNamesClient.Children(parentId, "cristhyan17");
                List<ValueTO> result = (from st in serResult select new ValueTO { Value = st.GeoNameId.ToString(), Text = st.Name }).ToList();
               
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}