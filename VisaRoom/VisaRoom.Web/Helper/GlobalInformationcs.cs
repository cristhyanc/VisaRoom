using BusinessLogic.Common;
using NGeo.GeoNames;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using VisaRoom.Common.Models;

namespace VisaRoom.Web.Helper
{
    public class GlobalInformation : IGlobalInformation
    {

        #region Properties
        private List<ValueTo> _listCountries;
        private Hashtable _listStates;
        private Hashtable _listCities;
        private List<ValueTo> _listMaritalStates;
        private BusinessLogic.Common.Common _bsCommon;
        #endregion

        public GlobalInformation()
        {
            _bsCommon = new Factory().GetCommonClass();
        }

        public List<ValueTo> GetCountries()
        {
            if (_listCountries == null || _listCountries.Count == 0)
            {
                var geoNamesClient = new GeoNamesClient();
                var serResult = geoNamesClient.Countries("cristhyan17");
                List<Country> result = new List<Country>();
                if (serResult != null)
                {
                    result = serResult.ToList();
                }
                _listCountries = (from ct in result
                                        select new ValueTo { Text = ct.CountryName, Value = ct.GeoNameId.ToString() }).ToList();
               
            }

            return _listCountries;
        }

        public ValueTo GetCountry(string countryId)
        {
            return null;
        }

        public List<ValueTo> GetCitiesByState(string cityId)
        {
            List<ValueTo> result = new List<ValueTo>();
            if (_listCities != null)
            {
                if (_listCities.Contains(cityId))
                {
                    result = (List<ValueTo>)_listCities[cityId];
                    return result;
                }
            }
            else
            {
                _listCities = new Hashtable();
            }

            result = getChildren(int.Parse(cityId));
            _listCities.Add(cityId, result);
            return result;


        }

        public List<ValueTo> GetStatesByCountry(string countryId)
        {
            List<ValueTo> result = new List<ValueTo>();
            if (_listStates != null)
            {
                if (_listStates.Contains(countryId))
                {
                    result = (List<ValueTo>)_listStates[countryId];
                    return result;
                }
            }
            else
            {
                _listStates = new Hashtable();
            }

            result = getChildren(int.Parse(countryId));
            _listStates.Add(countryId, result);
            return result;
        }

        private static List<ValueTo> getChildren(int parentId)
        {

            try
            {
                List<ValueTo> result = new List<ValueTo>();
                var geoNamesClient = new GeoNamesClient();
                var serResult = geoNamesClient.Children(parentId, "cristhyan17");
                if (serResult != null)
                {
                    result = (from st in serResult select new ValueTo { Value = st.GeoNameId.ToString(), Text = st.Name }).ToList();
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ValueTo> GetMaritalStates()
        {
            if (_listMaritalStates == null || _listMaritalStates.Count == 0)
            {
                _listMaritalStates=_bsCommon.GetMaritalStates();
            }
            return _listMaritalStates;
        }
    }
}