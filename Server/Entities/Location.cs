using Newtonsoft.Json;

namespace Server.Entities
{
     [JsonConverter(typeof(LocationConverter))]
    public class Location
    {
        public string Name { get; set; }
        public string Crs { get; set; }
        public List<string> Tiploc { get; set; }
        public string Country { get; set; }
        public string System { get; set; }

        public Location(string name, string crs, List<string> tiploc, string country, string system) => 
            (Name, Crs, Tiploc, Country, System) 
        =   (name, crs, tiploc, country, system);
    }


}