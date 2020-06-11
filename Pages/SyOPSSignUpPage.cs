using BDD_TwoFA.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_TwoFA.Pages
{
    public class SyOPSSignUpPage : CommonObjects
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_chkSyOps']")]
        private IWebElement SyOPsInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_chk740']")]
        private IWebElement JSP740Input { get; set; }

        //maincontent_butSubmit

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'maincontent_butSubmit')]")]
        private IWebElement SaveDetailsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h2[contains(text(),'SyOPs')]")]
        private IWebElement Headerverify { get; set; }

        public void SaveRenewAccountDetails()
        {
            try
            {
                Assert.IsTrue(Headerverify.Enabled, "Header is incorrect");
                SyOPsInput.MouseClick();
                JSP740Input.MouseClick();
            }
            catch (Exception e)
            {
                throw new Exception("Unable to check the Details the .." + e.Message);
            }

        }

        public void SubmitAccountDetails()
        {
            try
            {
                SaveDetailsButton.MouseClick();
            }
            catch (Exception e)
            {
                throw new Exception("Unable to submit the button.." + e.Message);
            }

        }
    }
}
