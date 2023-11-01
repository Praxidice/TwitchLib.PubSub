using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TwitchLib.PubSub.Extensions
{
    internal class UnixMillisecondsToDateTimeConverter : DateTimeConverterBase
    {
        internal static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Initializes a new instance of the <see cref="UnixDateTimeConverter"/> class.
        /// </summary>
        public UnixMillisecondsToDateTimeConverter()
        {
        }


        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            long seconds;

            if (value is DateTime dateTime)
            {
                seconds = (long)(dateTime.ToUniversalTime() - UnixEpoch).TotalSeconds;
            }
            else
            {
                throw new JsonSerializationException("Expected date object value.");
            }

            writer.WriteValue(seconds * 1000);
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing property value of the JSON that is being converted.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
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

            if (seconds >= 0)
            {
                DateTime d = UnixEpoch.AddMilliseconds(seconds);
                return d;
            }
            else
            {
                throw new JsonSerializationException();
            }
        }
    }
}
