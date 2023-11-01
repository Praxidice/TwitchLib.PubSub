using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.PubSub.Models
{
    public class HypeTrainConductorReward
    {
        [JsonProperty(PropertyName = "type")]
        public string Type;

        [JsonProperty(PropertyName = "id")]
        public string Id;

        [JsonProperty(PropertyName = "group_id")]
        public string GroupId;

        [JsonProperty(PropertyName = "reward_level")]
        public int RewardLevel;

        [JsonProperty(PropertyName = "badge_id")]
        public string BadgeId;

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl;
    }
}
