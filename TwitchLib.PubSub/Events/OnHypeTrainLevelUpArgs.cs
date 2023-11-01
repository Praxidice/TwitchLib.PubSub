using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Extensions;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Events
{
    public class OnHypeTrainLevelUpArgs : OnHypeTrainArgs
    {
        [JsonProperty("time_to_expire")]
        [JsonConverter(typeof(UnixMillisecondsToDateTimeConverter))]
        public DateTime ExpireTime;

        [JsonProperty("progress")]
        public HypeTrainProgress Progress;

        [JsonProperty("is_boost_train")]
        public bool IsBoostTrain;
    }
}
