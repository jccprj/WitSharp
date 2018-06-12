﻿namespace WitSharp.Objects
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    public class EntityValuesObject
    {
        internal EntityValuesObject() { }
        [JsonProperty("builtin")]
        public bool Builtin { get; internal set; }
        [JsonProperty("doc")]
        public string Description { get; internal set; }
        [JsonProperty("id")]
        public string Id { get; internal set; }
        [JsonProperty("lang")]
        public string Language { get; internal set; }
        [JsonProperty("lookups")]
        public string[] Lookups { get; internal set; }
        [JsonProperty("name")]
        public string Name { get; internal set; }
        [JsonProperty("values")]
        public List<Values> Values { get; internal set; }
    }

    public partial class Values
    {
        internal Values() { }
        [JsonProperty("value")]
        public string Value { get; internal set; }
        [JsonProperty("expressions")]
        public List<string> Expressions { get; internal set; }
    }
}