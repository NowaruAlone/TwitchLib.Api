﻿using Newtonsoft.Json;

namespace TwitchLib.Api.Helix.Models.Chat.Emotes.GetGlobalEmotes
{
    public class GetGlobalEmotesResponse
    {
        [JsonProperty("data")]
        public GlobalEmote[] GlobalEmotes { get; protected set; }
    }
}