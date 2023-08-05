using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Server.Entities
{
    public class LocationDetail
    {
        public bool RealtimeActivated { get; set; }
        public string Tiploc { get; set; }
        public string Crs { get; set; }
        public string Description { get; set; }
        public string GbttBookedArrival { get; set; }
        public string GbttBookedDeparture { get; set; }
        public List<Origin> Origin { get; set; }
        public List<Destination> Destination { get; set; }
        public bool IsCall { get; set; }
        public bool IsPublicCall { get; set; }
        public string RealtimeArrival { get; set; }
        public bool RealtimeArrivalActual { get; set; }
        public string RealtimeDeparture { get; set; }
        public bool RealtimeDepartureActual { get; set; }
        public string Platform { get; set; }
        public bool PlatformConfirmed { get; set; }
        public bool PlatformChanged { get; set; }
        public string DisplayAs { get; set; }
        public string ServiceLocation { get; set; }

        public LocationDetail(bool realtimeactivated, string tiploc, string crs, string description, string gbbttbookedarrival, string gbbttbookedeparture,
         List<Origin>  origin, List<Destination> destination, bool iscall, bool ispubliccall, string realtimearrival, bool realtimearrivalactual, 
         string realtimedeparture, bool realtimedepartureactual, string platform, bool platformconfirmed, bool platformchanged, string displayas, string servicelocation ) => 
            (RealtimeActivated, Tiploc, Crs, Description, GbttBookedArrival, GbttBookedDeparture, Origin, Destination, IsCall, IsPublicCall, RealtimeArrival, RealtimeArrivalActual,
            RealtimeDeparture, RealtimeDepartureActual, Platform, PlatformConfirmed, PlatformChanged, DisplayAs, ServiceLocation) 
        =   (realtimeactivated, tiploc, crs, description, gbbttbookedarrival, gbbttbookedeparture, origin, destination, iscall, ispubliccall, realtimearrival, realtimearrivalactual, 
            realtimedeparture, realtimedepartureactual, platform, platformconfirmed, platformchanged, displayas, servicelocation);
    }

    
}