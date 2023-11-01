using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Extensions;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Events
{
    public class OnHypeTrainStartArgs : OnHypeTrainArgs
    {
        [JsonProperty("id")]
        public Guid Id { get; protected set; }

        [JsonProperty("config")]
        public HypeTrainConfig Config { get; protected set; }

        [JsonProperty("participations")]
        public Dictionary<string, int> Participations;

        [JsonProperty("progress")]
        public HypeTrainProgress Progress { get; protected set; }

        [JsonProperty("started_at")]
        [JsonConverter(typeof(UnixMillisecondsToDateTimeConverter))]
        public DateTime StartedAt { get; protected set; }

        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixMillisecondsToDateTimeConverter))]
        public DateTime ExpiresAt { get; protected set; }

        [JsonProperty("updated_at")]
        [JsonConverter(typeof(UnixMillisecondsToDateTimeConverter))]
        public DateTime UpdatedAt { get; protected set; }

        [JsonProperty("is_boost_train")]
        public bool IsBoostTrain { get; protected set; }

        [JsonProperty("is_golden_kappa_train")]
        public bool IsGoldenKappaTrain { get; protected set; } = false;

        [JsonProperty("all_time_high_progress")]
        public HypeTrainProgress AllTimeHighProgress { get; protected set; }
    }
}
