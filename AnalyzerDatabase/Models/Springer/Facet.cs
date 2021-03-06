﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnalyzerDatabase.Models.Springer
{
    public class Facet
    {
        #region Variables
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public IList<Value> Values { get; set; }
        #endregion

        #region Constructors
        public Facet(string name, IList<Value> values)
        {
            Name = name;
            Values = values;
        }
        #endregion
    }
}