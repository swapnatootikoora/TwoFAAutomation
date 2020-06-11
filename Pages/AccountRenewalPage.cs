using BDD_TwoFA.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_TwoFA.Pages
{
    public class AccountRenewalPage : CommonObjects
    {
        //maincontent_butSubmit

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'maincontent_butSubmit')]")]
        private IWebElement ContinueButton { get; set; }



        public void UpdateFinish()
        {
            try
            {
                System.Threading.Thread.Sleep(5000);
                ContinueButton.MouseClick();
            }
            catch (Exception e)
            {
                throw new Exception("Unable to submit the button.." + e.Message);
            }

        }
    }
}
