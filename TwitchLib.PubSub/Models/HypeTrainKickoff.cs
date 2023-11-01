using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Extensions;

namespace TwitchLib.PubSub.Models
{
    public class HypeTrainKickoff
    {
        [JsonProperty(PropertyName = "num_of_events")]
        public int NumEvents;

        [JsonProperty(PropertyName = "min_points")]
        public int MinPoints;

        [JsonProperty(PropertyName = "duration")]
        [JsonConverter(typeof(NanosecondsToTimeSpanConverter))]
        public TimeSpan Duration;
    }
}
