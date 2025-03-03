﻿using System;
using Newtonsoft.Json;

namespace TwitchLib.Api.V5.Models.Teams
{
    /// <summary>Class representing a more detailed team object from Twitch API</summary>
    public class Team
    {
        #region Id
        /// <summary>Property representing the team ID.</summary>
        [JsonProperty(PropertyName = "_id")]
        public long Id { get; set; }
        #endregion
        #region Background
        /// <summary>Property representing the background.</summary>
        [JsonProperty(PropertyName = "background")]
        public string Background { get; set; }
        #endregion
        #region Banner
        /// <summary>Property representing the banner.</summary>
        [JsonProperty(PropertyName = "banner")]
        public string Banner { get; set; }
        #endregion
        #region CreatedAt
        /// <summary>Property representing the date time of team creation.</summary>
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }
        #endregion
        #region DisplayName
        /// <summary>Property representing the case sensitive display name of the team.</summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }
        #endregion
        #region Info
        /// <summary>Property representing the information of the team.</summary>
        [JsonProperty(PropertyName = "info")]
        public string Info { get; set; }
        #endregion
        #region Logo
        /// <summary>Property representing the logo of the team.</summary>
        [JsonProperty(PropertyName = "logo")]
        public string Logo { get; set; }
        #endregion
        #region Name
        /// <summary>Property representing the name of the team (always in lowercase).</summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        #endregion
        #region UpdatedAt
        /// <summary>Property representing the date time of last team update.</summary>
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }
        #endregion
        #region Users (or rather said, channels)
        /// <summary>Property representing the users in the team.</summary>
        [JsonProperty(PropertyName = "users")]
        public Channels.Channel[] Users { get; set; }
        #endregion
    }
}
