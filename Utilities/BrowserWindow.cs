using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

namespace TwoFA.Utilities
{
    public static class AUT
    {

        private static IWebDriver webDriver;

        private static WebDriverWait wait;

        public static IWebDriver Current_Driver

        {

            get

            {

                return webDriver;

            }

            set

            {

                webDriver = value;

            }

        }

        public static WebDriverWait WebDriverWait

        {

            get

            {

                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(60));

                return wait;

            }

            set

            {

                wait = value;

            }

        }


        public static void BrowserLaunch_sel(string URL)

        {

            try

            {

                string test = ConfigurationManager.AppSettings["Browser"];
       
                var option = new ChromeOptions();

                option.AddArgument("no-sandbox");

                option.AddArguments("disable-infobars");

                option.AddUserProfilePreference("credentials_enable_service", true);

              
                //Closing all drivers before launching the new one 

                if (AUT.Current_Driver != null)

                {

                    AUT.Current_Driver.Close();

                }

                System.Threading.Thread.Sleep(2000);

                if (test == "Internet")

                {

                    InternetExplorerOptions options = new InternetExplorerOptions();

                    options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    string binpath = AppDomain.CurrentDomain.BaseDirectory;

                    AUT.Current_Driver = new InternetExplorerDriver(binpath, options, TimeSpan.FromMinutes(5));

                }

                else if (test == "FIREFOX")

                    AUT.Current_Driver = new FirefoxDriver();

                else if (test == "Chrome")

                    AUT.Current_Driver = new ChromeDriver();

                #region Navigate to URL

                System.Threading.Thread.Sleep(2000);
                AUT.Current_Driver.Manage().Window.Maximize();
                AUT.Current_Driver.Navigate().GoToUrl(URL);

                #endregion
            }

            catch (Exception e)

            {

                throw new Exception("Not able to launch Browser :" + e.Message);

            }

        }

    }


    public class CleanUp
    {

        public static void KillingChromeDriver()
        {

            var chromeDriverProcesses = Process.GetProcesses().
                                 Where(pr => pr.ProcessName.Contains("chromedriver"));

            foreach (var process in chromeDriverProcesses)
            {
                process.Kill();
            }

        }

    }

}
