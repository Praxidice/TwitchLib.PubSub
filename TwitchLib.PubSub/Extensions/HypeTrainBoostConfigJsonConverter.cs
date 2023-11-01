using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Extensions
{
    internal class HypeTrainBoostConfigJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            if(objectType == typeof(HypeTrainBoostConfig))
            {
                return true;
            }

            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            HypeTrainBoostConfig res = new HypeTrainBoostConfig();
            JObject obj = JObject.Load(reader);

            if (obj["twitch_impressions"] != null)
            {
                var i = obj["twitch_impressions"];

                if (i["EASY"] != null)
                    res.ImpressionsEasy = i["EASY"].ToObject<int>();

                if (i["MEDIUM"] != null)
                    res.ImpressionsMedium = i["MEDIUM"].ToObject<int>();

                if (i["HARD"] != null)
                    res.ImpressionsHard = i["HARD"].ToObject<int>();

                if (i["SUPER HARD"] != null)
                    res.ImpressionsSuperHard = i["SUPER HARD"].ToObject<int>();

                if (i["INSANE"] != null)
                    res.ImpressionsInsane = i["INSANE"].ToObject<int>();
            }

            return res;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanWrite => false;
        public override bool CanRead => true;
    }
}
