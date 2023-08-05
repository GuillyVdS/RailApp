using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities
{
    public class Service
    {
        public LocationDetail LocationDetail { get; set; }
        public string ServiceUid { get; set; }
        public string RunDate { get; set; }
        public string TrainIdentity { get; set; }
        public string RunningIdentity { get; set; }
        public string AtocCode { get; set; }
        public string AtocName { get; set; }
        public string ServiceType { get; set; }
        public bool IsPassenger { get; set; }

        public Service(LocationDetail locationdetail, string serviceuid, string rundate, string trainidentity,
         string runningidentity, string atoccode, string atocname, string servicetype, bool ispassenger) =>
            (LocationDetail, ServiceUid, RunDate, TrainIdentity, RunningIdentity, AtocCode, AtocName, ServiceType, IsPassenger) 
        =   (locationdetail, serviceuid, rundate, trainidentity, runningidentity, atoccode, atocname, servicetype, ispassenger);
    }

    


}