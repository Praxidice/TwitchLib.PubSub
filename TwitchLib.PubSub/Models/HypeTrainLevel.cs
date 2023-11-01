using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.PubSub.Models
{
    public class HypeTrainLevel
    {
        [JsonProperty(PropertyName = "value")]
        public int Value;

        [JsonProperty(PropertyName = "goal")]
        public int Goal;

        [JsonProperty(PropertyName = "impressions")]
        public int Impressions;

        [JsonProperty(PropertyName = "rewards")]
        public List<HypeTrainReward> Rewards;
    }
}
