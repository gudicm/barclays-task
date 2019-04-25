﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using PrintExample;
//
//    var vat = Vat.FromJson(jsonString);

using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PrintExample.Model
{
    public partial class Vat
    {
        [JsonProperty("details")]
        public Uri Details { get; set; }

        [JsonProperty("version")]
        public object Version { get; set; }

        [JsonProperty("rates")]
        public List<Rate> Rates { get; set; }
    }

    public partial class Rate
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("periods")]
        public List<Period> Periods { get; set; }
    }

    public partial class Period
    {
        [JsonProperty("effective_from")]
        public string EffectiveFrom { get; set; }

        [JsonProperty("rates")]
        public Rates Rates { get; set; }
    }

    public partial class Rates
    {
        [JsonProperty("super_reduced", NullValueHandling = NullValueHandling.Ignore)]
        public double? SuperReduced { get; set; }

        [JsonProperty("reduced", NullValueHandling = NullValueHandling.Ignore)]
        public double? Reduced { get; set; }

        [JsonProperty("standard")]
        public double Standard { get; set; }

        [JsonProperty("reduced1", NullValueHandling = NullValueHandling.Ignore)]
        public double? Reduced1 { get; set; }

        [JsonProperty("reduced2", NullValueHandling = NullValueHandling.Ignore)]
        public double? Reduced2 { get; set; }

        [JsonProperty("parking", NullValueHandling = NullValueHandling.Ignore)]
        public double? Parking { get; set; }
    }

    public partial class Vat
    {
        public static Vat FromJson(string json) => JsonConvert.DeserializeObject<Vat>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Vat self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}