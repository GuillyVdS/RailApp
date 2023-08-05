using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    public class AppConfiguration
    {
        public string ApiUsername { get; set; } 
        public string ApiPassword { get; set; }

        public AppConfiguration(string ApiUsr, string ApiPsw) =>
            (ApiUsername , ApiPassword) = (ApiUsr, ApiPsw);
    }
}