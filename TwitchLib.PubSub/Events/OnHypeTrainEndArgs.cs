using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Extensions;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Events
{
    public class OnHypeTrainEndArgs : OnHypeTrainArgs
    {
        [JsonProperty(PropertyName = "ended_at")]
        [JsonConverter(typeof(UnixMillisecondsToDateTimeConverter))]
        public DateTime EndedAt;

        [JsonProperty(PropertyName = "ending_reason")]
        public string EndingReason;

        [JsonProperty(PropertyName = "is_boost_train")]
        public bool IsBoostTrain;

        [JsonProperty(PropertyName = "participation_totals")]
        public HypeTrainParticipationTotal[] ParticipationTotals;
    }
}
