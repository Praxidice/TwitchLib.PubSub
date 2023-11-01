using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Events
{
    public class OnHypeTrainApproachingArgs : OnHypeTrainArgs
    {
        [JsonProperty("approaching_hype_train_id")]
        public Guid Id { get; protected set; }

        [JsonProperty("goal")]
        public int Goal { get; protected set; }

        [JsonProperty("events_remaining_durations")]
        public Dictionary<String, long> EventsRemainingDurations { get; protected set; }

        [JsonProperty("level_one_rewards")]
        public List<HypeTrainReward> LevelOneRewards { get; protected set; }

        [JsonProperty("creator_color")]
        public string CreatorColor { get; protected set; }

        [JsonProperty("is_boost_train")]
        public bool IsBoostTrain { get; protected set; }

        [JsonProperty("is_golden_kappa_train")]
        public bool IsGoldenKappaTrain { get; protected set; } = false;

        [JsonProperty("participants")]
        public List<string> Participants { get; protected set; }
    }
    
}
