﻿namespace VSCodeThemeImporter
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class ThemeFileContract
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "colors")]
        public Dictionary<string, string> Colors { get; set; }

        [DataMember(Name = "tokenColors")]
        public RuleContract[] TokenColors { get; set; }
    }
}