using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_TwoFA.APIRoots
{
   public class AuthAppRoots
    {

        [JsonProperty("type")]
        public string type { get; set; }

  
        [JsonProperty("user")]
        public string user { get; set; }

        [JsonProperty("realm")]
        public string realm { get; set; }

        [JsonProperty("validity_period_start")]
        public string validity_period_start { get; set; }

        [JsonProperty("validity_period_end")]
        public string validity_period_end { get; set; }


    }
}
