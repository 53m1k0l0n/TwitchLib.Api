﻿using System.Collections.Generic;
using TwitchLib.Api.Core.Enums;
using TwitchLib.Api.Core.Interfaces;

namespace TwitchLib.Api
{
    public class ApiSettings : IApiSettings
    {
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public string AccessToken { get; set; }
        public bool SkipDynamicScopeValidation { get; set; }
        public bool SkipAutoServerTokenGeneration { get; set; }
        public List<AuthScopes> Scopes { get; set; }
    }
}
