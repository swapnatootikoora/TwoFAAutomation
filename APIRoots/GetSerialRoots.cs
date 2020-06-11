using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFA.APIRoots
{
    public partial class GetSerialRoots
    {
        [JsonProperty("detail")]
        public Detail Detail { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("result")]
        public Serial_Result Result { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("versionnumber")]
        public string Versionnumber { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }
    }

    public partial class Detail
    {
        [JsonProperty("googleurl")]
        public Googleurl Googleurl { get; set; }

        [JsonProperty("oathurl")]
        public Googleurl Oathurl { get; set; }

        [JsonProperty("otpkey")]
        public Googleurl Otpkey { get; set; }

        [JsonProperty("rollout_state")]
        public string RolloutState { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("threadid")]
        public long Threadid { get; set; }
    }

    public partial class Googleurl
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

       // [JsonProperty("value")]
        public string G_Value { get; set; }

        [JsonProperty("value_b32", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueB32 { get; set; }
    }

    public partial class Serial_Result
    {
       // [JsonProperty("status")]
        public bool Serial_Status { get; set; }

        //[JsonProperty("value")]
        public bool Serial_Value { get; set; }
    }
}

