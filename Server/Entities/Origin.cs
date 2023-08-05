using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities
{
    public class Origin
    {
        public string Tiploc { get; set; }
        public string Description { get; set; }
        public string WorkingTime { get; set; }
        public string PublicTime { get; set; }

        public Origin(string tiploc, string description, string workingtime, string publictime) =>
        (Tiploc, Description, WorkingTime, PublicTime) = (tiploc, description, workingtime, publictime);
    }
}