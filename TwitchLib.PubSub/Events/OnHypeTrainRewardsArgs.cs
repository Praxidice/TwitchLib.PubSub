using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Events
{
    public class OnHypeTrainRewardsArgs : OnHypeTrainArgs
    {
        [JsonProperty(PropertyName = "completed_level")]
        public int CompletedLevel;

        [JsonProperty(PropertyName = "is_boost_train")]
        public bool IsBoostTrain;

        [JsonProperty(PropertyName = "is_golden_kappa_train")]
        public bool IsGoldenKappaTrain;

        [JsonProperty(PropertyName = "rewards")]
        public List<HypeTrainReward> Rewards;
    }
}
