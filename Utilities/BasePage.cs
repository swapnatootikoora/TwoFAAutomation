using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFA.Utilities;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace BDD_TwoFA.Utilities
{
    /// <summary>
    ///  This class stores common methods which will use all over the framework
    /// </summary>
    public static class BasePage
    {
        public static void WaitForElementVisibilityByWebElement(this By element)
        // public static void WaitforElemnentVisibilityByWebelemnet(this By element)
        {

            WebDriverWait wait = new WebDriverWait(AUT.Current_Driver, TimeSpan.FromMinutes(1));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));

        }


        public static void EnterText(this IWebElement element, string sendkeys)
        {

            element.SendKeys(sendkeys);


        }

        public static void MouseClick(this IWebElement element)
        {
            element.Click();
        }

    }
}
