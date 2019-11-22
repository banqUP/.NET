﻿using Newtonsoft.Json;

namespace Psd2Hub.Sdk.ApiModels
{
    internal class Error
    {
        [JsonProperty(PropertyName = "details")]
        public object Details { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string DisplayMessage { get; set; }
    }
}
