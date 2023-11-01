using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Events
{
    public class OnHypeTrainProgressionArgs : OnHypeTrainArgs
    {
        [JsonProperty("user_id")]
        public string UserId;

        [JsonProperty("user_login")]
        public string UserLogin;

        [JsonProperty("user_display_name")]
        public string UserDisplayName;

        [JsonProperty("user_profile_image_url")]
        public string UserProfileImageUrl;

        [JsonProperty("sequence_id")]
        public int SequenceId;

        [JsonProperty("action")]
        public string Action;

        [JsonProperty("source")]
        public string Source;

        [JsonProperty("quantity")]
        public int Quantity;

        [JsonProperty("progress")]
        public HypeTrainProgress Progress;

        [JsonProperty("is_boost_train")]
        public bool IsBoostTrain;

        [JsonProperty("is_large_event")]
        public bool IsLargeEvent;

        [JsonProperty("initiator_currency")]
        public string InitiatorCurrency;
    }
}
