﻿using Newtonsoft.Json;

namespace AnalyzerDatabase.Models.Springer
{
    public class Url
    {
        #region Variables
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        #endregion

        #region Constructors
        public Url(string format, string platform, string value)
        {
            Format = format;
            Platform = platform;
            Value = value;
        }
        #endregion
    }
}