using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities
{
    public class Root
    {
        public Location Location { get; set; }
        public object? Filter { get; set; }
        public List<Service>? Services { get; set; }

        public Root(Location location) =>
        Location = location;
    }
}