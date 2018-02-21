﻿using Newtonsoft.Json;

namespace TwitchLib.Api.Models.v3.Videos
{
    public class Channel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; protected set; }
    }
}
