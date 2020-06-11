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
    public class EnrollPage : CommonObjects
    {

        #region Objects of SMS page



        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_SMS2FA']")]
        private IWebElement SmsInput { get; set; }

        //maincontent_butChangePhoneNumber

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_butChangePhoneNumber']")]
        private IWebElement ChangeMyPhoneNumber { get; set; }

        //#maincontent_pnlError > div > div
        [FindsBy(How = How.XPath, Using = ".//div[@id='maincontent_pnlError']")]
        private IWebElement ChangedSMSError { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_App2FA']")]
        private IWebElement AuthAppInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_Email2FA']")]
        private IWebElement EmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_txtNumber']")]
        private IWebElement MobileNumText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='notification error']")]
        private IWebElement SmsemailError { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='notification error']/ul/li")]
        private IWebElement SmsemailErrorMessage { get; set; }

        //maincontent_butGenerateQR

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_butGenerateQR']")]
        private IWebElement GenerateQRCode { get; set; }

        [FindsBy(How = How.XPath, Using = ".//img[@id='maincontent_QRCode']")]
        private IWebElement AuthAppCode { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_txtEmail']")]
        private IWebElement EmailAddText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'maincontent_butSubmit')]")]
        private IWebElement SubmitButton { get; set; }




        #endregion

        #region Actions of SMS page


        public void VerifyEnrollPage()
        {

            try
            {
                BasePage.WaitForElementVisibilityByWebElement(By.XPath(".//h1[@id='logo']"));

                TwoFACommonPageValidations("Two Factor Authentication");


                //Verify links should be present
                Assert.IsTrue(SmsInput.Enabled, "SmsInput is present on the screen");

                Assert.IsTrue(AuthAppInput.Enabled, "AuthAppInput link is present on the screen");

                Assert.IsTrue(EmailInput.Enabled, "EmailInput is present on the screen");
            }
            catch (Exception e)
            {

                throw new Exception("Issue while verifying the  Enroll page, please check the error.." + e.Message);
            }

        }

        public void SelectTwoFAVerificationOption(string option, string value)
        {
            try
            {
                if (option.ToLower().Contains("sms"))
                {

                    //Assert.IsFalse(MobileNumText.GetAttribute("value").ToString().Contains(""), "Mobile number cant be blank for regitered user..");
                   // MobileNumText.Clear();
                    MobileNumText.EnterText(value);
                }
                else if (option.ToLower().Contains("authapp"))
                {
                    AuthAppInput.MouseClick();
                    GenerateQRCode.MouseClick();
                    System.Threading.Thread.Sleep(10000);

                }
                else if (option.ToLower().Contains("email"))
                {
                    EmailInput.MouseClick();
                    System.Threading.Thread.Sleep(5000);
                    EmailAddText.EnterText(value);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error while entering the text in .." + option + "Error received-" + e.Message);
            }


        }

        public void ChangeMyPhoneNumberPage()
        {
            try
            {
                ChangeMyPhoneNumber.Click();
            }
            catch (Exception e)
            {
                throw new Exception("Unable to submit the button.." + e.Message);
            }

        }

        public void AssertEmailMessage()
        {
            try
            {
                //Assert.IsTrue(ChangedSMSError.Text.Contains(" We have sent you an email. You need to click on the link in the email, this will allow you to alter your mobile phone number."), "Wrong error message when user enters invalid phone number...");
                Assert.IsTrue(ChangedSMSError.Enabled, "Email message is Invalid..");
            }
            catch (Exception e)
            {
                throw new Exception("Unable to submit the button.." + e.Message);
            }
        }



        public void SubmitToken()
        {
            try
            {
                SubmitButton.MouseClick();
            }
            catch (Exception e)
            {
                throw new Exception("Unable to submit the button.." + e.Message);
            }

        }


        public void AssertSmsError(string error)
        {
            try
            {
                if (error.ToLower().Contains("sms"))
                {

                    Assert.IsTrue(SmsemailError.Enabled, "Mobile Number is Invalid..");

                    Assert.IsTrue(SmsemailErrorMessage.Text.Contains("Mobile number invalid."), "Wrong error message when user enters invalid phone number...");
                }
                else if (error.ToLower().Contains("email"))
                {
                    Assert.IsTrue(SmsemailError.Enabled, "email is Invalid..");

                    Assert.IsTrue(SmsemailErrorMessage.Text.Contains("Email invalid."), "Wrong error message when user enters invalid email address...");
                }


            }
            catch (Exception e)
            {
                throw new Exception("Entered Mobile number or Email is incorrect format , please check the errors.." + "Entered value is .." + error + "--Error received.." + e.Message);
            }

        }

        #endregion


    }
}
