﻿using Newtonsoft.Json;
using System.Collections.Generic;
namespace TwitchLib.Api.Models.v3.Users
{
    public class UserEmotesResponse
    {
        [JsonProperty(PropertyName = "emoticon_sets")]
        public Dictionary<string, Emote[]> EmoticonSets { get; protected set; }
    }
}
