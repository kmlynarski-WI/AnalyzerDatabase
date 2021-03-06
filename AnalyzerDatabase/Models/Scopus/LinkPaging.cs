﻿using Newtonsoft.Json;

namespace AnalyzerDatabase.Models.Scopus
{
    public class LinkPaging
    {
        #region Variables
        [JsonProperty("@_fa")]
        public string Fa { get; set; }

        [JsonProperty("@ref")]
        public string Ref { get; set; }

        [JsonProperty("@href")]
        public string Href { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }
        #endregion

        #region Constructors
        public LinkPaging(string fa, string @ref, string href, string type)
        {
            Fa = fa;
            Ref = @ref;
            Href = href;
            Type = type;
        }
        #endregion
    }
}