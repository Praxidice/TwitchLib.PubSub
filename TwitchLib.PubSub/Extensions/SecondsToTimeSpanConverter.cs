using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.PubSub.Extensions
{
    internal class SecondsToTimeSpanConverter : Newtonsoft.Json.JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            long seconds;

            if (reader.TokenType == JsonToken.Integer)
            {
                seconds = (long)reader.Value;
            }
            else if (reader.TokenType == JsonToken.String)
            {
                if (!long.TryParse((string)reader.Value, out seconds))
                {
                    throw new JsonSerializationException();
                }
            }
            else
            {
                throw new JsonSerializationException();
            }

            return TimeSpan.FromSeconds(seconds);
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(TimeSpan) || objectType == typeof(TimeSpan?))
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
