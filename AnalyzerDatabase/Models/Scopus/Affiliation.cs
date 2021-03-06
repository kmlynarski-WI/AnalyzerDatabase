﻿using Newtonsoft.Json;

namespace AnalyzerDatabase.Models.Scopus
{
    public class Affiliation
    {
        #region Variables
        [JsonProperty("@_fa")]
        public string Fa { get; set; }

        [JsonProperty("affilname")]
        public string Affilname { get; set; }

        [JsonProperty("affiliation-city")]
        public string AffiliationCity { get; set; }

        [JsonProperty("affiliation-country")]
        public string AffiliationCountry { get; set; }
        #endregion

        #region Constructors
        public Affiliation(string fa, string affilname, string affiliationCity, string affiliationCountry)
        {
            Fa = fa;
            Affilname = affilname;
            AffiliationCity = affiliationCity;
            AffiliationCountry = affiliationCountry;
        }
        #endregion
    }
}