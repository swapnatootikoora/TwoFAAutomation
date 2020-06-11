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
    public class TokenPage : CommonObjects
    {



        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_txtToken']")]
        private IWebElement TokenNumText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_butSubmit']")]
        private IWebElement SubmitButton { get; set; }

        //maincontent_resendToken

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_resendToken']")]
        private IWebElement ResendToken { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_butChangePhone']")]
        private IWebElement ChangePhoneNumber { get; set; }

        //class="form-login-heading"
        //divid="maincontent_pnlError" #maincontent_pnlError > div > div  id="maincontent_butChangePhoneNumber"
        //class="notification error" id="maincontent_pnlError"

        [FindsBy(How = How.XPath, Using = ".//div[@id='maincontent_pnlError']")]
        private IWebElement AssertEmailMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h2[@class='Enter Secret Answer']")]
        private IWebElement AssertSecretAnswerMessage { get; set; }


        //FindsBy(How = How.Id, Using = "maincontent_txtUsername")]
        //private IWebElement LoginUserText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_txtAnswer']")]
        private IWebElement SecretAnswerText { get; set; }

        //maincontent_butSubmit

        // <h2 class="form-login-heading">Update Phone Number</h2>
        [FindsBy(How = How.XPath, Using = ".//h2[@class='Update Phone Number']")]
        private IWebElement UpdatePhoneNumberMessage { get; set; }

        //Your security answer was incorrect, please try again.


        //id="maincontent_txtNumber"

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_txtNumber']")]
        private IWebElement UpdatePhoneNumber { get; set; }

        // <input type = "submit" name="ctl00$maincontent$butSavePhoneNumber" value="Save" id="maincontent_butSavePhoneNumber" class="btn btn-lg btn-primary btn-block">

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_butSavePhoneNumber']")]
        private IWebElement SaveButton { get; set; }

        //<div class="notification success">You have successfully changed your phone number.</div>

        [FindsBy(How = How.XPath, Using = ".//div[@class='notification success']")]
        private IWebElement NotificationSuccessMessage { get; set; }

        //<input type="submit" name="ctl00$maincontent$butSuccessSubmit" value="Continue to login" id="maincontent_butSuccessSubmit" class="btn btn-lg btn-primary btn-block">

        [FindsBy(How = How.XPath, Using = ".//input[@id='maincontent_butSuccessSubmit']")]
        private IWebElement SuccessSubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='notification error']")]
        private IWebElement SmsTokenError { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='notification error']/ul/li")]
        private IWebElement SmsTokenErrorMessage { get; set; }

        public void VerifyTokenPage()
        {
            try
            {

                TwoFACommonPageValidations("Enter Token");

            }
            catch (Exception e)
            {
                throw new Exception("Error at Token page verification..." + e.Message);
            }
        }

        public void ClickResendToken()
        {
            try
            {

                ResendToken.MouseClick();
                System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to enter the text in phnum .." + e.Message);
            }


        }

        public void EnterTokenNum()
        {
            try
            {
                string OTP = "968576";
                TokenNumText.EnterText(OTP);
                System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to enter the text in phnum .." + e.Message);
            }


        }

        public void EnterWrongToken()
        {
            try
            {
                string OTP = "42150";
                TokenNumText.EnterText(OTP);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to enter the text in phnum .." + e.Message);
            }


        }

        public void SubmitTokenPage()
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
        //id="maincontent_chkSyOps"


        

        public void ResendTokenPage()
        {
            try
            {
                ResendToken.MouseClick();
            }
            catch (Exception e)
            {
                throw new Exception("Unable to submit the button.." + e.Message);
            }

        }

        public void ChangePhoneNumberPage()
        {
            try
            {
                ChangePhoneNumber.MouseClick();
            }
            catch (Exception e)
            {
                throw new Exception("Unable to submit the button.." + e.Message);
            }

        }

        

        public void VerifyNotificationMessage()
        {
            try
            {
                
                Assert.IsTrue(AssertEmailMessage.Displayed, "Message is not showing correctly..");
                

            }
            catch (Exception e)
            {
                throw new Exception("Login page controls are not correct , please check the errors..");
            }

        }


        public void AssertSecretAnswerPage()
        {
            try
            {

                Assert.IsTrue(AssertSecretAnswerMessage.Displayed, "Message is not showing correctly..");


            }
            catch (Exception e)
            {
                throw new Exception("Login page controls are not correct , please check the errors..");
            }

        }

        public void EnterSecurrityAnswerPage(string SecurityAnswer)
        {
            try
            {
                SecretAnswerText.SendKeys(SecurityAnswer);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to enter the security answer.." + e.Message);
                
            }

        }

        public void EnterUpdatedPhoneNumber(string MobileNumber)
        {
            try
            {
                UpdatePhoneNumber.SendKeys(MobileNumber);
            }

            catch (Exception e)
            {
                throw new Exception("Unable to update the mobile number.." + e.Message);

            }
        }

        public void ClickSaveButton()
        {
            try
            {

                SaveButton.MouseClick();
                System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to enter the text in phnum .." + e.Message);
            }


        }

        public void SaveUpdatedPhoneDetails()
        {
            try
            {
                Assert.IsTrue(NotificationSuccessMessage.Enabled, "Header is incorrect");
                SuccessSubmitButton.MouseClick();
                
            }
            catch (Exception e)
            {
                throw new Exception("Unable to submit  .." + e.Message);
            }

        }

        public void AssertTokenError()
        {
            try
            {

                Assert.IsTrue(SmsTokenError.Enabled, "OTP Number is Invalid..");

                //Assert.IsTrue(SmsTokenErrorMessage.Text.Contains("Your token is incorrect."), "Wrong error message when user enters invalid OTP number...");

                Assert.IsTrue(SmsTokenErrorMessage.Text.Contains("Token must be six digits."), "OTPis incoreect..");

            }
            catch (Exception e)
            {
                throw new Exception("Entered OTP number is incorrect ,please check the errors.." + e.Message);

            }

        }


    }
}
