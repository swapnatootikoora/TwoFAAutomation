using BDD_TwoFA.Pages;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFA.Pages;
using TwoFA.Utilities;

namespace TwoFA.ApplicationCommon
{
   public class TwoFAPages
    {

        private static T getPages<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(AUT.Current_Driver, page);
            return page;
        }
        public static LoginPage loginPage
        {
            get { return getPages<LoginPage>(); }
        }

        public static EnrollPage enrollPage
        {
            get { return getPages<EnrollPage>(); }
        }


        public static TokenPage tokenPage
        {
            get { return getPages<TokenPage>(); }
        }

        public static CommonObjects CommonObjects
        {
            get { return getPages<CommonObjects>(); }
        }

        public static SyOPSSignUpPage syopsSignUpPage
        {
            get { return getPages<SyOPSSignUpPage>(); }
        }

        public static AccountRenewalPage accountRenewalPage
        {
            get { return getPages<AccountRenewalPage>(); }
        }

        public static DashboardPage dashboardPage
        {
            get { return getPages<DashboardPage>(); }
        }
    }
}
