using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject1
{
    class MailListPage : Page
    {
        [FindsBy(How = How.XPath, Using = ".//*[starts-with(@href,'https://accounts.google.com/SignOutOptions')]")]
        public IWebElement linkSignOutOptions;

        [FindsBy(How = How.XPath, Using = ".//*[@id='gb_71']")]
        public IWebElement outButton;

        public MailListPage GoToMailPage()
        {
            driver.Url = "https://mail.google.com";
            return this;
        }

        public Boolean SignOutExists()
        {
            waitElement(By.XPath(".//*[starts-with(@href,'https://accounts.google.com/SignOutOptions')]"));
            return linkSignOutOptions.GetAttribute("title").Contains("Аккаунт");
        }

        public MailListPage(IWebDriver driver_) : base(driver_)
        {
        }
    }
}
