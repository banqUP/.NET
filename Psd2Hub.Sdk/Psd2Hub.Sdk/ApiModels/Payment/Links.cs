﻿using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels.Payment
{
    // internal
    public class Links
    {
        [JsonProperty(PropertyName = "self", Required = Required.Always)]
        public string Self { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        [JsonProperty(PropertyName = "cancel")]
        public string Cancel { get; set; }
    }
}
