﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YaMaps
{

    public partial class GeocoderResponse
    {
        public class GeocoderMetaData2
        {

            [JsonProperty("kind")]
            public string Kind { get; set; }

            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("precision")]
            public string Precision { get; set; }

            [JsonProperty("AddressDetails")]
            public AddressDetails2 AddressDetails { get; set; }
        }
    }

}
