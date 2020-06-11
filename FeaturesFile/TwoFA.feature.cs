// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDD_TwoFA.FeaturesFile
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TwoFA Feature Testing")]
    public partial class TwoFAFeatureTestingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TwoFA.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TwoFA Feature Testing", "\tIn order to access my MOD account\r\n\tAs a user of the MOD website\r\n\tI want to log" +
                    " into the website using TwoFA OTP authentications ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify TWoFA API OTP Authentications")]
        [NUnit.Framework.CategoryAttribute("TwoFAAPIValidateSerials")]
        [NUnit.Framework.TestCaseAttribute("sms", "+447508155256", null)]
        [NUnit.Framework.TestCaseAttribute("email", "swapna.tootikoora@netcompany.com", null)]
        [NUnit.Framework.TestCaseAttribute("hotp", "hotp", null)]
        public virtual void VerifyTWoFAAPIOTPAuthentications(string type, string typeValue, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAAPIValidateSerials"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify TWoFA API OTP Authentications", null, @__tags);
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
 testRunner.Given("User has valid token for valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When(string.Format("User makes request with valid token and for \"{0}\" and \"{1}\"", type, typeValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("User should get valid Code using valid serial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify the OTP received is correct or not")]
        [NUnit.Framework.CategoryAttribute("TwoFAAPIValidateOTP")]
        [NUnit.Framework.TestCaseAttribute("sms", "+447508155256", null)]
        [NUnit.Framework.TestCaseAttribute("email", "swapna.tootikoora@netcompany.com", null)]
        public virtual void VerifyTheOTPReceivedIsCorrectOrNot(string type, string typeValue, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAAPIValidateOTP"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the OTP received is correct or not", null, @__tags);
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
 testRunner.Given("User has valid token for valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.When(string.Format("User makes request with valid token and for \"{0}\" and \"{1}\"", type, typeValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("User should get valid Code using valid serial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.Then("Verify the OTP received is correct or not", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify TwoFA authentication pages with Authapp")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidAuthAppOptionPages")]
        [NUnit.Framework.TestCaseAttribute("2FATest6", null)]
        public virtual void VerifyTwoFAAuthenticationPagesWithAuthapp(string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidAuthAppOptionPages"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify TwoFA authentication pages with Authapp", null, @__tags);
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 33
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify TwoFA authentication pages with SMS option")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidateSMSOptionPages")]
        [NUnit.Framework.TestCaseAttribute("2FATest2", null)]
        public virtual void VerifyTwoFAAuthenticationPagesWithSMSOption(string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidateSMSOptionPages"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify TwoFA authentication pages with SMS option", null, @__tags);
#line 45
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 46
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify TwoFA authentication pages with Email option")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidateEmailOptionPages")]
        [NUnit.Framework.TestCaseAttribute("2FATest5", null)]
        public virtual void VerifyTwoFAAuthenticationPagesWithEmailOption(string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidateEmailOptionPages"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify TwoFA authentication pages with Email option", null, @__tags);
#line 59
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 60
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OTP on SMS app authentication for login in to the application")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidateLogin_viaSMSApp_AlreadyEnrolled")]
        [NUnit.Framework.TestCaseAttribute("2FATest2", null)]
        public virtual void OTPOnSMSAppAuthenticationForLoginInToTheApplication(string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidateLogin_viaSMSApp_AlreadyEnrolled"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OTP on SMS app authentication for login in to the application", null, @__tags);
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 74
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.Then("Enter received OTP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
 testRunner.Then("Click on Submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.Then("Verify user should reach to Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OTP on Email app authentication for login in to the application")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidateLogin_viaEmailApp_AlreadyEnrolled")]
        [NUnit.Framework.TestCaseAttribute("2FATest5", null)]
        public virtual void OTPOnEmailAppAuthenticationForLoginInToTheApplication(string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidateLogin_viaEmailApp_AlreadyEnrolled"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OTP on Email app authentication for login in to the application", null, @__tags);
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 90
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.Then("Enter received OTP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.Then("Click on Submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.Then("Verify user should reach to Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OTP on auth app authentication for login in to the application")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidateLogin_viaAuthApp_AlreadyEnrolled")]
        [NUnit.Framework.TestCaseAttribute("2FATest5", null)]
        public virtual void OTPOnAuthAppAuthenticationForLoginInToTheApplication(string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidateLogin_viaAuthApp_AlreadyEnrolled"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OTP on auth app authentication for login in to the application", null, @__tags);
#line 104
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 105
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.Then("Enter received OTP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.Then("Click on Submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.Then("Verify user should reach to Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OTP on different  authentication options for login in to the application")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidateLogin_OTP_Newuser_SYOPS")]
        [NUnit.Framework.TestCaseAttribute("2FATest10", "SMS", "+447508155256", "No", null)]
        [NUnit.Framework.TestCaseAttribute("2FATest9", "Email", "swapna.tootikoora@netcompany.com", "No", null)]
        [NUnit.Framework.TestCaseAttribute("2FATest8", "authapp", "novalue", "No", null)]
        public virtual void OTPOnDifferentAuthenticationOptionsForLoginInToTheApplication(string user, string option, string optionValue, string alreadyEnrolled, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidateLogin_OTP_Newuser_SYOPS"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OTP on different  authentication options for login in to the application", null, @__tags);
#line 120
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 121
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 122
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.Then(string.Format("Verify Two Factor Authentication screen according to \"{0}\" condition", alreadyEnrolled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 126
 testRunner.Then(string.Format("Select the TwoFA Authentication Option \"{0}\" and enter \"{1}\" if required", option, optionValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
 testRunner.Then("Click Submit on Enrollment Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.Then("Enter received OTP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.Then("Click on Submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.Then("Verify Revised SyOPs signup screen and click SyOPs and JSP740 Checkbox as true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.Then("Click Save Details on Syops signup page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.Then("Verify the updated account renewal page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.Then("Click on Continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.Then("Verify user should reach to Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Re-Send OTP on different options authentication for login in to the application")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidateLogin_ResendOTP_EnrolledUser")]
        [NUnit.Framework.TestCaseAttribute("2FATest5", "email", null)]
        [NUnit.Framework.TestCaseAttribute("2FATest3", "sms", null)]
        [NUnit.Framework.TestCaseAttribute("2FATest4", "AuthApp", null)]
        public virtual void Re_SendOTPOnDifferentOptionsAuthenticationForLoginInToTheApplication(string user, string option, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidateLogin_ResendOTP_EnrolledUser"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Re-Send OTP on different options authentication for login in to the application", null, @__tags);
#line 146
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 147
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 148
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 149
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 152
 testRunner.Then("Click on ResendToken button to receive another token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
 testRunner.Then("Enter received OTP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 154
 testRunner.Then("Click on Submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.Then("Verify user should reach to Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Re-Send OTP on New User authentication for login in to the application")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidateLogin_NewUser_SyOPS_ResendOTP")]
        [NUnit.Framework.TestCaseAttribute("2FATest2", "SMS", "+447508155256", "No", null)]
        [NUnit.Framework.TestCaseAttribute("2FATest6", "Email", "swapna.tootikoora@netcompany.com", "No", null)]
        [NUnit.Framework.TestCaseAttribute("2FATest8", "authapp", "novalue", "No", null)]
        public virtual void Re_SendOTPOnNewUserAuthenticationForLoginInToTheApplication(string user, string option, string optionValue, string alreadyEnrolled, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidateLogin_NewUser_SyOPS_ResendOTP"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Re-Send OTP on New User authentication for login in to the application", null, @__tags);
#line 165
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 166
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 167
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 168
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 169
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 170
 testRunner.Then(string.Format("Verify Two Factor Authentication screen according to \"{0}\" condition", alreadyEnrolled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 171
 testRunner.Then(string.Format("Select the TwoFA Authentication Option \"{0}\" and enter \"{1}\" if required", option, optionValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 172
 testRunner.Then("Click Submit on Enrollment Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 173
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 174
 testRunner.Then("Click on ResendToken button to receive another token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.Then("Enter received OTP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 176
 testRunner.Then("Click on Submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 177
 testRunner.Then("Verify Revised SyOPs signup screen and click SyOPs and JSP740 Checkbox as true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 178
 testRunner.Then("Click Save Details on Syops signup page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 179
 testRunner.Then("Verify the updated account renewal page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 180
 testRunner.Then("Click on Continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 181
 testRunner.Then("Verify user should reach to Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify TwoFA authentication pages with updated phone number")]
        [NUnit.Framework.CategoryAttribute("TwoFAUIValidateSMSOptionPages_Change_the_phone_number")]
        [NUnit.Framework.TestCaseAttribute("2FATest2", "test", "+447979861841", null)]
        public virtual void VerifyTwoFAAuthenticationPagesWithUpdatedPhoneNumber(string user, string securityAnswer, string mobileNumber, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUIValidateSMSOptionPages_Change_the_phone_number"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify TwoFA authentication pages with updated phone number", null, @__tags);
#line 192
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 193
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 194
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 195
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 196
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 197
 testRunner.Then("Verify Token Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 198
 testRunner.Then("Click on ChangePhoneNumber button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
 testRunner.Then("Verify the email message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify TwoFA authentication pages with change phone number")]
        [NUnit.Framework.CategoryAttribute("TwoFAUISMSOptionPage_Change_the_phone_number")]
        [NUnit.Framework.TestCaseAttribute("twofatest4", "No", null)]
        public virtual void VerifyTwoFAAuthenticationPagesWithChangePhoneNumber(string user, string alreadyEnrolled, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TwoFAUISMSOptionPage_Change_the_phone_number"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify TwoFA authentication pages with change phone number", null, @__tags);
#line 213
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 214
 testRunner.Given("Launch TwoFA Application and verify homescreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 215
 testRunner.Then("Verify Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 216
 testRunner.Then(string.Format("Login with \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 217
 testRunner.Then("Click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 218
 testRunner.Then(string.Format("Verify Two Factor Authentication screen according to \"{0}\" condition", alreadyEnrolled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 219
 testRunner.Then("Click on ChangeMyPhoneNumber button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
