using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFA.Utilities;

namespace BDD_TwoFA.Pages
{
    public class DashboardPage
    {

        [FindsBy(How = How.XPath, Using = ".//div[@id='header']")]
        private IWebElement AzureloginpageHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@title='Logout']")]
        private IWebElement VerifyDashboard { get; set; }


        public void AzurePageAction()
        {
            try
            {
                System.Threading.Thread.Sleep(3000);
                if (AzureloginpageHeader.Text.ToLower().Contains("defence gateway"))
                {
                    IList<IWebElement> accountexists = AUT.Current_Driver.FindElement(By.XPath(".//form[@id='hrd']")).FindElements(By.XPath("//div[@class='idpDescription float']/span"));

                    if (accountexists.Count > 0)
                    {
                        foreach (var account in accountexists)
                        {
                            account.Click();
                            break;

                        }
                    }

                    else
                    {
                        Console.WriteLine("No user is exists here.. check the error..");
                    }
                }

                else
                {
                    Console.WriteLine("Defence gateway  azure page is not present ..");

                }
            }
            catch (Exception e)
            {
                throw new Exception("Error while clicking azure page validations.." + e.Message);
            }
        }

        public void VerifyDashboardPage()
        {
            try
            {
                System.Threading.Thread.Sleep(8000);
                Assert.IsTrue(VerifyDashboard.Enabled, "Log out link is not present...");
                Console.WriteLine("Dashboard page has been verified...");
                

            }
            catch (Exception e)
            {

                throw new Exception("User has not reached to dash board--please check error ..." + e.Message);
            }


        }


    }
}
