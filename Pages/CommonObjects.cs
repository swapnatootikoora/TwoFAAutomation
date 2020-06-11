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
    public class CommonObjects
    {
        [FindsBy(How = How.XPath, Using = ".//img[@alt='Defence Gateway Logo']")]
        private IWebElement TwoFALogo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[@id='logo']")]
        private IWebElement TwoFAHeadingLabel { get; set; }


        [FindsBy(How = How.XPath, Using = ".//div[@id='maincontent_TwoFAEnroll']/h2")]
        private IWebElement TwoFAPageHeading { get; set; }

        

        public void TwoFACommonPageValidations(string pageHeading)
        {

            try
            {
                //Verify Logo,header and Heading 
                Assert.IsTrue(TwoFALogo.Displayed, "Page logo is not showing correctly..page--" + pageHeading);
                Assert.IsTrue(TwoFAHeadingLabel.Displayed, "Header is not present on thepage--" + pageHeading);
                // Assert.IsTrue(TwoFAPageHeading.Text.Contains(pageHeading), "Heading text is not correct..page--" + pageHeading);


            }
            catch (Exception e)
            {

                throw new Exception("Issue with page control , please check the errors..Page Name--" + pageHeading + "Error--" + e.Message);
            }


        }





    }
}
