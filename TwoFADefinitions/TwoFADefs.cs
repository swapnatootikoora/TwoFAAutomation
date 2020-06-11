using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TwoFA.ApplicationCommon;
using TwoFA.Utilities;

namespace BDD_TwoFA
{
    [Binding]

    public sealed class TwoFADefs
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        APIMethods apiMethods = new APIMethods();

        private readonly ScenarioContext scenarioContext;

        public TwoFADefs(ScenarioContext scenarioContext)

        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");
            this.scenarioContext = scenarioContext;
        }


        [Given(@"User has valid token for valid credentials")]
        public void GivenUserHasValidTokenForValidCredentials()
        {

            this.scenarioContext.Add("ApiToken", apiMethods.GetToken());
        }


        [When(@"User makes request with valid token and invalid user as ""(.*)""")]
        public void WhenUserMakesRequestWithValidTokenAndInvalidUserAs(String user)
        {
            this.scenarioContext.Add("SerialAPIResponse", apiMethods.VerifyErrorMsgWithInvalidUserName(this.scenarioContext.Get<string>("ApiToken"), user));
        }


        [Then(@"User should get error message")]
        public void ThenUserShouldGetErrorMessage()
        {
            var apiresponse = this.scenarioContext.Get<IRestResponse>("SerialAPIResponse");

            Assert.IsTrue(apiresponse.StatusCode.ToString().ToLower().Contains("badrequest"), "Wrong message received when user in invalid..");
        }



        [When(@"User makes request with valid token and for ""(.*)"" and ""(.*)""")]
        public void WhenUserMakesRequestWithValidTokenAndForAnd(string type, string typevalue)
        {
            this.scenarioContext.Add("APIserial", apiMethods.GetSerialviaType(this.scenarioContext.Get<string>("ApiToken"), type, typevalue));
        }


        [Then(@"User should get valid Code using valid serial")]
        public void ThenUserShouldGetValidCodeUsingValidSerial()
        {
            this.scenarioContext.Add("APICode", apiMethods.GetCodeusingToken(this.scenarioContext.Get<string>("APIserial"), this.scenarioContext.Get<string>("ApiToken")));
        }


        [Then(@"Verify the OTP received is correct or not")]
        public void WhenVerifyTheOTPReceivedIsCorrectOrNot()
        {

            this.scenarioContext.Add("APIOTP", "866046");
            string ValidateToken = apiMethods.ValidateOTP(this.scenarioContext.Get<string>("APIOTP"), this.scenarioContext.Get<string>("ApiToken"));

            Assert.IsTrue(ValidateToken.Contains("matching 1 tokens"), "OTPis incoreect..");
        }


        [Given(@"Launch TwoFA Application and verify homescreen")]
        public void GivenLaunchTwoFAApplicationAndVerifyHomescreen()
        {
            CleanUp.KillingChromeDriver();
            string UI_URL = ConfigurationManager.AppSettings["AppURL"];
            AUT.BrowserLaunch_sel(UI_URL);

        }


        [Then(@"Verify Login page")]
        public void ThenVerifyLoginPage()
        {
            TwoFAPages.loginPage.AssertLoginPage();
        }


        [Then(@"Login with ""(.*)""")]
        public void ThenLoginWithAnd(string user)
        {
            string psw = ConfigurationManager.AppSettings["TwoFAPassword"];
            TwoFAPages.loginPage.LoginintoApp(user, psw);
        }

        [Then(@"Enter Wrong password for ""(.*)"" user as ""(.*)""")]
        public void ThenEnterWrongPasswordForUserAs(string user, string psw)
        {
            TwoFAPages.loginPage.LoginintoApp(user, psw);
        }



        [Then(@"Click on Login")]
        public void ThenClickOnLogin()
        {
            TwoFAPages.loginPage.ClickSignin();
        }


        [Then(@"Verify the notification error in the login page")]
        public void ThenVerifyTheNotificationErrorInTheLoginPage()
        {
            TwoFAPages.loginPage.AssertLoginError();
        }


        [Then(@"Verify Two Factor Authentication screen")]
        public void ThenVerifyTwoFAAuthenticationScreen()
        {
            this.scenarioContext.Add("enrollcondition", "no");
            TwoFAPages.enrollPage.VerifyEnrollPage();

        }

        [Then(@"Verify Two Factor Authentication screen according to ""(.*)"" condition")]
        public void ThenVerifyTwoFactorAuthenticationScreenAccordingToCondition(string enrollcondition)
        {

           
            if (enrollcondition.ToLower().Contains("no"))
            {
                TwoFAPages.enrollPage.VerifyEnrollPage();
                this.scenarioContext.Add("enrollcondition", enrollcondition);
            }
            else
            {
                Console.WriteLine("User is already enrolled for SMS service ");
                this.scenarioContext.Add("enrollcondition", "yes");
            }
        }


        [Then(@"Select the TwoFA Authentication Option ""(.*)"" and enter ""(.*)"" if required")]
        public void ThenSelectTheTwoFAAuthenticationOptionAndEnterIfRequired(string option, string optionvalue)
        {
            string enrollcondition = this.scenarioContext.Get<string>("enrollcondition");


            if (enrollcondition.ToLower().Contains("no"))
            {
                TwoFAPages.enrollPage.SelectTwoFAVerificationOption(option, optionvalue);
            }
        }


        [Then(@"Click on ChangeMyPhoneNumber button")]
        public void ThenClickOnChangeMyPhoneNumberButton()
        {
            TwoFAPages.enrollPage.ChangeMyPhoneNumberPage();
        }

        [Then(@"Verify the email notification message")]
        public void ThenVerifyTheEmailNotificationMessage()
        {
            TwoFAPages.enrollPage.AssertEmailMessage();
        }

       


        [Then(@"Click Submit on Enrollment Page")]
        public void ThenClickSubmitOnEnrollmentPage()
        {
           
            string enrollcondition = this.scenarioContext.Get<string>("enrollcondition");


            if (enrollcondition.ToLower().Contains("no"))
            {
                TwoFAPages.enrollPage.SubmitToken();
            }
        }


        [Then(@"Verify the notification error in the enrollment Page for ""(.*)""")]
        public void ThenVerifyThenNotificationErrorInTheEnrollmentPage(string value)
        {
            TwoFAPages.enrollPage.AssertSmsError(value);
        }


        [Then(@"Verify Token Page")]
        public void ThenVerifyTokenPage()
        {
            TwoFAPages.tokenPage.VerifyTokenPage();
        }
        [Then(@"Click on ResendToken button to receive another token")]
        public void ThenClickOnResendTokenButtonToReceiveAnotherToken()
        {
            TwoFAPages.tokenPage.ClickResendToken();
        }


        [Then(@"Click on ChangePhoneNumber button")]
        public void ThenClickOnChangePhoneNumberButton()
        {
            TwoFAPages.tokenPage.ChangePhoneNumberPage();    
        }

        [Then(@"Verify the email message")]
        public void ThenVerifyTheEmailMessage()
        {
            TwoFAPages.tokenPage.VerifyNotificationMessage();
        }

        [Then(@"Verify the Secret Question Page")]
        public void ThenVerifyTheSecretQuestionPage()
        {
           // TwoFAPages.tokenPage.AssertSecretAnswerPage();     
        }

        [Then(@"Enter the Security Answer with ""(.*)""")]
        public void ThenEnterTheSecurityAnswerWith(string SecurityAnswer)
        {
            TwoFAPages.tokenPage.EnterSecurrityAnswerPage(SecurityAnswer);
        }

        [Then(@"Enter the phone phone number with ""(.*)""")]
        public void ThenEnterThePhonePhoneNumberWith(string MobileNumber)
        {
            TwoFAPages.tokenPage.EnterUpdatedPhoneNumber(MobileNumber);
        }

        [Then(@"Click on Save button")]
        public void ThenClickOnSaveButton()
        {
            TwoFAPages.tokenPage.ClickSaveButton();
        }

        [Then(@"Verify the update phone number page")]
        public void ThenVerifyTheUpdatePhoneNumberPage()
        {
            TwoFAPages.tokenPage.SaveUpdatedPhoneDetails();
        }



        [Then(@"Enter received OTP ")]
        public void ThenEnterReceivedOTPOnPhNum()
        {
            TwoFAPages.tokenPage.EnterTokenNum();
        }

        [Then(@"Verify the token notification error in the login page")]
        public void ThenVerifyTheTokenNotificationErrorInTheLoginPage()
        {
            TwoFAPages.tokenPage.AssertTokenError();

        }

        

        [Then(@"Enter received OTP")]
        public void ThenEnterReceivedOTP()
        {
            TwoFAPages.tokenPage.EnterTokenNum();
        }
        [Then(@"Enter wrong OTP")]
        public void ThenEnterwrongOTP()
        {
            TwoFAPages.tokenPage.EnterWrongToken();
        }

        [Then(@"Click on Submit")]
        public void ThenClickOnSubmit()
        {
            TwoFAPages.tokenPage.SubmitTokenPage();
        }


     
        [Then(@"Verify Revised SyOPs signup screen and click SyOPs and JSP(.*) Checkbox as true")]
        public void ThenVerifyRevisedSyOPsSignupScreenAndClickSyOPsAndJSPCheckboxAsTrue(int p0)
        {
            TwoFAPages.syopsSignUpPage.SaveRenewAccountDetails();
        }


        [Then(@"Click Save Details on Syops signup page")]
        public void ThenClickSaveDetailsOnSyopsSignupPage()
        {
            TwoFAPages.syopsSignUpPage.SubmitAccountDetails();
        }

        [Then(@"Verify the updated account renewal page")]
        public void ThenVerifyTheUpdatedAccountRenewalPage()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Click on Continue")]
        public void ThenClickOnContinue()
        {
            TwoFAPages.accountRenewalPage.UpdateFinish();
        }


        [Then(@"Verify user should reach to Dashboard Page")]
        public void ThenVerifyUserShouldReachToDashboardPage()
        {
           TwoFAPages.dashboardPage.AzurePageAction();
            TwoFAPages.dashboardPage.VerifyDashboardPage();
            AUT.Current_Driver.Quit();
        }


    }
}





