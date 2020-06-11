using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_TwoFA.APIRoots
{
   public class CheckOTPRoots
    {
        [JsonProperty("pass")]
        public string pass { get; set; }

        [JsonProperty("realm")]
        public string realm { get; set; }

        [JsonProperty("user")]
        public string user { get; set; }
    }
}
