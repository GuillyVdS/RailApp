using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Server.Entities;
using System;
using System.Collections.Generic;

namespace Server
{
    public class LocationConverter : JsonConverter<Location>
    {
        public override Location ReadJson(JsonReader reader, Type objectType, Location existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);

            string name = jsonObject["name"]?.Value<string>();
            string crs = jsonObject["crs"]?.Value<string>();
            List<string> tiploc = GetTiplocValue(jsonObject["tiploc"]);
            string country = jsonObject["country"]?.Value<string>();
            string system = jsonObject["system"]?.Value<string>();

            return new Location(name, crs, tiploc, country, system);
        }

        private List<string> GetTiplocValue(JToken token)
        {
            if (token == null)
                return null;

            if (token.Type == JTokenType.Array)
                return token.ToObject<List<string>>();
            else if (token.Type == JTokenType.String)
                return new List<string> { token.Value<string>() };
            else
                throw new JsonSerializationException("Invalid 'tiploc' value.");
        }

        public override void WriteJson(JsonWriter writer, Location value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
