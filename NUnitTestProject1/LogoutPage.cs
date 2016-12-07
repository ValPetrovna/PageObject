using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject1
{
    class LogoutPage : Page
    {

        [FindsBy(How = How.XPath, Using = ".//*[starts-with(@href,'https://accounts.google.com/SignOutOptions')]")]
        public IWebElement linkSignOutOptions;

        [FindsBy(How = How.XPath, Using = ".//*[@id='gb_71']")]
        public IWebElement outButton;

        public Page Logout()
        {
            new Actions(driver).Click(linkSignOutOptions).Click(outButton).Build().Perform();
            return this;
        }

        public LogoutPage(IWebDriver driver_) : base(driver_)
        {
        }
    }
}
