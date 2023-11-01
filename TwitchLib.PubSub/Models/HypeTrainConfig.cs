using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Extensions;

namespace TwitchLib.PubSub.Models
{
    public class HypeTrainConfig
    {
        [JsonProperty(PropertyName = "is_enabled")]
        public bool IsEnabled;

        [JsonProperty(PropertyName = "is_whitelisted")]
        public bool IsWhitelisted;

        [JsonProperty(PropertyName = "kickoff")]
        public HypeTrainKickoff Kickoff;

        [JsonProperty(PropertyName = "cooldown_duration")]
        [JsonConverter(typeof(NanosecondsToTimeSpanConverter))]
        public TimeSpan CooldownDuration;

        [JsonProperty(PropertyName = "level_duration")]
        [JsonConverter(typeof(NanosecondsToTimeSpanConverter))]
        public TimeSpan LevelDuration;

        [JsonProperty(PropertyName = "difficulty")]
        public string Difficulty;

        [JsonProperty(PropertyName = "reward_end_date")]
        public DateTime? rewardEndDate;

        [JsonProperty(PropertyName = "participation_conversion_rates")]
        public Dictionary<string, int> ParticipationConversionRates;

        [JsonProperty(PropertyName = "currency_conversion_rates")]
        public Dictionary<string, double> CurrencyConversionRates;

        [JsonProperty(PropertyName = "notification_thresholds")]
        public Dictionary<string, int> NotificationThresholds;

        [JsonProperty(PropertyName = "difficulty_settings")]
        public Dictionary<string, HypeTrainLevel[]> DifficultySettings;

        [JsonProperty(PropertyName = "conductor_rewards")]
        [JsonConverter(typeof(HypeTrainConductorRewardsJsonConverter))]
        public HypeTrainConductorRewards ConductorRewards;

        [JsonProperty(PropertyName = "callout_emote_id")]
        public string CalloutEmoteId;

        [JsonProperty(PropertyName = "callout_emote_token")]
        public string CalloutEmoteToken;

        [JsonProperty(PropertyName = "use_creator_color")]
        public bool UseCreatorColor;

        [JsonProperty(PropertyName = "primary_hex_color")]
        public string PrimaryHexColor;

        [JsonProperty(PropertyName = "use_personalized_settings")]
        public bool UsePersonalizedSettings;

        [JsonProperty(PropertyName = "has_conductor_badges")]
        public bool HasConductorBadges;

        [JsonProperty(PropertyName = "boost_train_config")]
        [JsonConverter(typeof(HypeTrainBoostConfigJsonConverter))]
        public HypeTrainBoostConfig BoostConfig;
    }
}
