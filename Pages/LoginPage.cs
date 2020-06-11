using BDD_TwoFA.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFA.Pages
{
    public class LoginPage : CommonObjects
    {

        #region LoginPage 

        [FindsBy(How = How.Id, Using = "maincontent_txtUsername")]
        private IWebElement LoginUserText { get; set; }

        [FindsBy(How = How.Id, Using = "maincontent_txtPassword")]
        private IWebElement LoginPswText { get; set; }

        [FindsBy(How = How.Id, Using = "maincontent_butLogin")]
        private IWebElement LogiButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='notification error']")]
        private IWebElement LoginError { get; set; }

        [FindsBy(How = How.LinkText, Using = "Password Reset")]
        private IWebElement LoginErrorPswReset { get; set; }

        [FindsBy(How = How.LinkText, Using = "Username Reminder")]
        private IWebElement LoginErrorReminder { get; set; }

        [FindsBy(How = How.LinkText, Using = "Other Common Issues")]
        private IWebElement LoginErrorCommonIssue { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='maincontent_pnlLogin']/div")]
        private IWebElement LoginPageHeader { get; set; }

        [FindsBy(How = How.LinkText, Using = "Can't log in?")]
        private IWebElement CantLoginLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Create an Account")]
        private IWebElement CreateAccountLink { get; set; }



        #endregion


        #region LoginPage Actions


        public void AssertLoginPage()
        {
            try
            {
                Assert.IsTrue(LoginPageHeader.Text.Contains("Be security savvy."), "Login page header");
                Assert.IsTrue(CantLoginLink.Displayed, "Page logo is not showing correctly..");
                Assert.IsTrue(CreateAccountLink.Displayed, "Header is not present on the page..");

            }
            catch (Exception e)
            {
                throw new Exception("Login page controls are not correct , please check the errors..");
            }

        }
        public void AssertLoginError()
        {
            try
            {
                System.Threading.Thread.Sleep(5000);
                Assert.IsTrue(LoginError.Enabled, "Page logo is not showing correctly..");
                Assert.IsTrue(LoginError.Text.Contains("Your username or password is wrong. Self-help links: "), "Issue with error message..");

                Assert.IsTrue(LoginErrorPswReset.Displayed, "Psw reset link is not present ");

                Assert.IsTrue(LoginErrorReminder.Displayed, "Login error Reminder link is not present , please check the error...");

                Assert.IsTrue(LoginErrorCommonIssue.Displayed, "Common issue link is not present...");


            }
            catch (Exception e)
            {
                throw new Exception("Login page controls are not correct , please check the errors..");
            }

        }


        public void LoginintoApp(string user, string psw)
        {
            try
            {

                LoginUserText.SendKeys(user);

                LoginPswText.SendKeys(psw);



            }

            catch (Exception e)
            {
                throw new Exception("Unable to login.." + e.Message);
            }

        }


        public void ClickSignin()
        {
            try
            {
                LogiButton.Click();



            }

            catch (Exception e)
            {
                throw new Exception("Unable to login.." + e.Message);
            }

        }


        //public void ClickDefenceGateway()
        //{
        //    try
        //    {
        //        System.Threading.Thread.Sleep(3000);
        //        ClickDefgateway.Click();
        //        System.Threading.Thread.Sleep(3000);


        //    }

        //    catch (Exception e)
        //    {
        //        throw new Exception("Unable to login.." + e.Message);
        //    }

        //}

        #endregion

    }
}
