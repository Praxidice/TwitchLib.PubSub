using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Extensions;

namespace TwitchLib.PubSub.Models
{
    public class HypeTrainProgress
    {
        [JsonProperty(PropertyName = "value")]
        public int Value;

        [JsonProperty(PropertyName = "goal")]
        public int Goal;

        [JsonProperty(PropertyName = "total")]
        public int Total;

        [JsonProperty(PropertyName = "remaining_seconds")]
        [JsonConverter(typeof(SecondsToTimeSpanConverter))]
        public TimeSpan RemainingTime;

        [JsonProperty(PropertyName = "level")]
        public HypeTrainLevel Level;
    }
}
