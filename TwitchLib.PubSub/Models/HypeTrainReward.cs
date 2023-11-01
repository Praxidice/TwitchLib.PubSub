using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Events;

namespace TwitchLib.PubSub.Models
{
    public class HypeTrainReward
    {
        [JsonProperty(PropertyName = "type")]
        public string Type;

        [JsonProperty(PropertyName = "id")]
        public string Id;

        [JsonProperty(PropertyName = "group_id")]
        public string GroupId;

        [JsonProperty(PropertyName = "reward_level")]
        public int RewardLevel;

        [JsonProperty(PropertyName = "set_id")]
        public string SetId;

        [JsonProperty(PropertyName = "token")]
        public string Token;
    }
}
