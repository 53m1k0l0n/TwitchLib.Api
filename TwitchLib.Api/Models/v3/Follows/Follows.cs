﻿using Newtonsoft.Json;
using System;

namespace TwitchLib.Api.Models.v3.Follows
{
    public class Follows
    {
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; protected set; }
        [JsonProperty(PropertyName = "notifications")]
        public bool Notifications { get; protected set; }
        [JsonProperty(PropertyName = "channel")]
        public Channels.Channel Channel { get; protected set; }
    }
}
