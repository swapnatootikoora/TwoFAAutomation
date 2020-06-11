using BDD_TwoFA.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using TwoFA.APIRoots;

namespace TwoFA.ApplicationCommon
{
    public class APIMethods
    {

        public APIMethods()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;

        }
        string endpoint = ConfigurationManager.AppSettings["apiEndPoint"];
        public string GetToken()
        {

            try
            {
                string user = ConfigurationManager.AppSettings["APIuser"];
                string psw = ConfigurationManager.AppSettings["APIpsw"];
                var client = new RestClient(endpoint + "/auth");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "text/plain");
                request.AddParameter("text/plain", " { \"username\": \"" + user + "\",\n  \"password\": \"" + psw + "\"\n  }", ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);
                Assert.AreEqual(response.StatusCode.ToString(), "OK", "Not getting correct API response..");

                var gettokenroots = JsonConvert.DeserializeObject<GetTokenRoots>(response.Content);

                return gettokenroots.Result.Value.Token;
            }
            catch (Exception e)
            {
                throw new Exception("Enable to get the token.." + e.Message);
            }

        }


        public string GetSerialviaType(string token, string type, string typevalue)
        {
            try
            {
                var client = new RestClient(endpoint + "/token/init?genkey=1");
                string binpath = AppDomain.CurrentDomain.BaseDirectory;
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("PI-Authorization", token);
                request.AddHeader("Content-Type", "application/json");

                if (type.ToLower().Contains("sms"))
                {

                    JsonParserUtil.updateJsonFiles(type, typevalue);
                    request.AddParameter("application/json", File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\SMSAPIBody.json")), ParameterType.RequestBody);
                }
                else if (type.ToLower().Contains("email"))
                {
                    JsonParserUtil.updateJsonFiles(type, typevalue);
                    request.AddParameter("application/json", File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\EmailAPIBody.json")), ParameterType.RequestBody);
                }
                else if (type.ToLower().Contains("hotp"))
                {

                    request.AddParameter("application/json", File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\AuthAppAPIBody.json")), ParameterType.RequestBody);
                }
                else
                {
                    Assert.Fail("Wrong value in type value .. please correct it..");

                }


                IRestResponse response = client.Execute(request);
                Assert.AreEqual(response.StatusCode.ToString(), "OK", "Not getting correct API response..");

                //Console.WriteLine(response.Content);
                var getserialroots = JsonConvert.DeserializeObject<GetSerialRoots>(response.Content);
                return getserialroots.Detail.Serial;

            }
            catch (Exception e)
            {
                throw new Exception("Error while validating the API result for --" + type + "With value..--" + typevalue + "Error received--" + e.Message);
            }
        }




        public IRestResponse VerifyErrorMsgWithInvalidUserName(String token, String user)
        {
            try
            {
                string binpath = AppDomain.CurrentDomain.BaseDirectory;
                var client = new RestClient("https://privacyidea.dgw-dev.mod.uk/token/init?genkey=1");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("PI-Authorization", token);
                request.AddHeader("Content-Type", "application/json");

                JsonParserUtil.InvalidUser("sms", user);
                request.AddParameter("application/json", File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\SMSAPIBody.json")), ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public string GetCodeusingToken(string serial, string token)
        {
            try
            {
                string binpath = AppDomain.CurrentDomain.BaseDirectory;
                var client = new RestClient(endpoint + "/validate/triggerchallenge");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("PI-Authorization", token);
                request.AddHeader("Content-Type", "text/plain");
                JsonParserUtil.UpdateSerial(serial);
                request.AddParameter("application/json", File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\GetTokenAPIBody.json")), ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);
                Assert.AreEqual(response.StatusCode.ToString(), "OK", "Not getting correct API response..");

                return "code";
            }
            catch (Exception e)
            {
                throw;
            }

        }


        public string ValidateOTP(string pass, string token)
        {
            try
            {
                string binpath = AppDomain.CurrentDomain.BaseDirectory;
                var client = new RestClient(endpoint + "/validate/check");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("PI-Authorization", token);
                request.AddHeader("Content-Type", "text/plain");
                JsonParserUtil.UpdateOTP(pass);
                request.AddParameter("application/json", File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\CheckOTPBody.json")), ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);
                Assert.AreEqual(response.StatusCode.ToString(), "OK", "Not getting correct API response..");
                var validateroots = JsonConvert.DeserializeObject<ValidateOtp>(response.Content);
                return validateroots.Detail.Message;
            }
            catch (Exception e)
            {
                throw;
            }

        }

    }

}

