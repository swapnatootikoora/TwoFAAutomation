using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace TwoFA.APIRoots
{
    public partial class ValidateOtp
    {
        [JsonProperty("detail")]
        public OTPDetail Detail { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("versionnumber")]
        public string Versionnumber { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }
    }

    public partial class OTPDetail
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("otplen")]
        public long Otplen { get; set; }

        [JsonProperty("serial")]
        public string Serial_get { get; set; }

        [JsonProperty("threadid")]
        public long Threadid_get { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("value")]
        public bool Value { get; set; }
    }

}

