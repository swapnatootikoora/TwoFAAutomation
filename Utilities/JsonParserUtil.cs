using BDD_TwoFA.APIRoots;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_TwoFA.Utilities
{
   public class JsonParserUtil
    {

public static void updateJsonFiles (string type,string typevalue)
        {

            string binpath = AppDomain.CurrentDomain.BaseDirectory;
            smsBodyroots roots = null;
            emailBodyroots Emailroots = null;
            AuthAppRoots AuthApproots = null;
            if (type.ToLower().Contains("sms"))
            {
                roots = JsonConvert.DeserializeObject<smsBodyroots>(File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\SMSAPIBody.json")));
               
                roots.phone = typevalue;

                string output = JsonConvert.SerializeObject(roots);
                File.WriteAllText(Path.Combine(binpath + "\\APIDataFiles\\SMSAPIBody.json"), output);


            }        
             else if (type.ToLower().Contains("email"))
                {
                    Emailroots = JsonConvert.DeserializeObject<emailBodyroots>(File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\EmailAPIBody.json")));

                    Emailroots.email = typevalue;

                    string output = JsonConvert.SerializeObject(Emailroots);
                    File.WriteAllText(Path.Combine(binpath + "\\APIDataFiles\\EmailAPIBody.json"), output);


                }

            


        }

        public static void InvalidUser(string type,string typevalue)
        {

            string binpath = AppDomain.CurrentDomain.BaseDirectory;
            smsBodyroots roots = null;
            emailBodyroots Emailroots = null;
            AuthAppRoots AuthApproots = null;
            if (type.ToLower().Contains("sms"))
            {
                roots = JsonConvert.DeserializeObject<smsBodyroots>(File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\SMSAPIBody.json")));

                roots.user = typevalue;

                string output = JsonConvert.SerializeObject(roots);
                File.WriteAllText(Path.Combine(binpath + "\\APIDataFiles\\SMSAPIBody.json"), output);


            }
            else if (type.ToLower().Contains("email"))
            {
                Emailroots = JsonConvert.DeserializeObject<emailBodyroots>(File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\EmailAPIBody.json")));

                Emailroots.user = typevalue;

                string output = JsonConvert.SerializeObject(Emailroots);
                File.WriteAllText(Path.Combine(binpath + "\\APIDataFiles\\EmailAPIBody.json"), output);


            }




        }

        public static void UpdateSerial(string typevalue)
        {

            string binpath = AppDomain.CurrentDomain.BaseDirectory;
            GetTokenAPIRoots roots = null;
           
                roots = JsonConvert.DeserializeObject<GetTokenAPIRoots>(File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\GetTokenAPIBody.json")));

                roots.serial = typevalue;

                string output = JsonConvert.SerializeObject(roots);
                File.WriteAllText(Path.Combine(binpath + "\\APIDataFiles\\GetTokenAPIBody.json"), output);


        }

        public static void UpdateOTP(string typevalue)
        {

            string binpath = AppDomain.CurrentDomain.BaseDirectory;
            CheckOTPRoots roots = null;

            roots = JsonConvert.DeserializeObject<CheckOTPRoots>(File.ReadAllText(Path.Combine(binpath + "\\APIDataFiles\\CheckOTPBody.json")));

            roots.pass = typevalue;

            string output = JsonConvert.SerializeObject(roots);
            File.WriteAllText(Path.Combine(binpath + "\\APIDataFiles\\CheckOTPBody.json"), output);


        }

    }
}
