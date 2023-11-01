using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Extensions
{
    internal class HypeTrainConductorRewardsJsonConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            HypeTrainConductorRewards res = new HypeTrainConductorRewards();
            JObject obj = JObject.Load(reader);

            if (obj["BITS"] != null)
            {
                if (obj["BITS"]["CURRENT"] != null)
                    res.BitsCurrent = obj["BITS"]["CURRENT"].ToObject<HypeTrainConductorReward[]>();

                if (obj["BITS"]["FORMER"] != null)
                    res.BitsFormer = obj["BITS"]["FORMER"].ToObject<HypeTrainConductorReward[]>();
            }

            if (obj["EXPLICIT_PURCHASE"] != null)
            {
                if (obj["EXPLICIT_PURCHASE"]["CURRENT"] != null)
                    res.PurchaseCurrent = obj["EXPLICIT_PURCHASE"]["CURRENT"].ToObject<HypeTrainConductorReward[]>();

                if (obj["EXPLICIT_PURCHASE"]["FORMER"] != null)
                    res.PurchaseFormer = obj["EXPLICIT_PURCHASE"]["FORMER"].ToObject<HypeTrainConductorReward[]>();
            }

            if (obj["SUBS"] != null)
            {
                if (obj["SUBS"]["CURRENT"] != null)
                    res.SubsCurrent = obj["SUBS"]["CURRENT"].ToObject<HypeTrainConductorReward[]>();

                if (obj["SUBS"]["FORMER"] != null)
                    res.SubsFormer = obj["SUBS"]["FORMER"].ToObject<HypeTrainConductorReward[]>();
            }

            return res;
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(HypeTrainConductorRewards))
            {
                return true;
            }

            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanRead => true;
        public override bool CanWrite => false;
    }
}
