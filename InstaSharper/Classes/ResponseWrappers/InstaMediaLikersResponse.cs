﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstaSharper.Classes.ResponseWrappers
{
    internal class InstaMediaLikersResponse : BadStatusResponse
    {
        [JsonProperty("users")]
        public List<InstaUserShortResponse> Users { get; set; }

        [JsonProperty("user_count")]
        public int UsersCount { get; set; }
    }
}
