using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.PubSub.Events
{
    public class OnHypeTrainConductorUpdateArgs : OnHypeTrainArgs
    {
        [JsonProperty("source")]
        public string Source;

        public string UserId;
        public string UserLogin;
        public string UserDisplayName;
        public string UserProfileImageUrl;

        [JsonProperty("participations")]
        public Dictionary<string, int> Participations;
    }
}
