using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_TwoFA.APIRoots
{
   public class smsBodyroots
    {

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("phone")]
        public string phone { get; set; }

        [JsonProperty("user")]
        public string user { get; set; }

        [JsonProperty("realm")]
        public string realm { get; set; }

        [JsonProperty("otplen")]
        public string otplen { get; set; }

    }
}
