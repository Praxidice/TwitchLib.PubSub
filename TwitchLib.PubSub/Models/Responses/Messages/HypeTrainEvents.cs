using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TwitchLib.PubSub.Enums;
using TwitchLib.PubSub.Events;

namespace TwitchLib.PubSub.Models.Responses.Messages
{
    public class HypeTrainEvents : MessageData
    {
        /// <summary>
        /// Channel id
        /// </summary>
        /// <value>The channel id</value>
        public string ChannelId { get; private set; }

        public OnHypeTrainArgs Data;

        public HypeTrainEvents(string jsonStr, string ChannelId)
        {
            this.ChannelId = ChannelId;

            JToken json = JObject.Parse(jsonStr);
            switch (json.SelectToken("type").ToString())
            {
                case "hype-train-approaching":
                    Data = json.SelectToken("data").ToObject<OnHypeTrainApproachingArgs>();
                    break;
                case "hype-train-conductor-update":
                    var c = json.SelectToken("data").ToObject<OnHypeTrainConductorUpdateArgs>();
                    c.UserId = json.SelectToken("data.user.id").ToObject<string>();
                    c.UserLogin = json.SelectToken("data.user.login").ToObject<string>();
                    c.UserDisplayName = json.SelectToken("data.user.display_name").ToObject<string>();
                    c.UserProfileImageUrl = json.SelectToken("data.user.profile_image_url").ToObject<string>();
                    Data = c;
                    break;
                case "hype-train-cooldown-expiration":
                    Data = new OnHypeTrainCooldownExpirationArgs();
                    break;
                case "hype-train-end":
                    Data = json.SelectToken("data").ToObject<OnHypeTrainEndArgs>();
                    break;
                case "hype-train-level-up":
                    Data = json.SelectToken("data").ToObject<OnHypeTrainLevelUpArgs>();
                    break;
                case "hype-train-progression":
                    Data = json.SelectToken("data").ToObject<OnHypeTrainProgressionArgs>();
                    break;
                case "hype-train-start":
                    Data = json.SelectToken("data").ToObject<OnHypeTrainStartArgs>();
                    break;
                case "hype-train-rewards":
                    Data = json.SelectToken("data").ToObject<OnHypeTrainRewardsArgs>();
                    break;
            }

            if (Data != null)
            {
                Data.ChannelId = ChannelId;
            }
        }
    }
}
