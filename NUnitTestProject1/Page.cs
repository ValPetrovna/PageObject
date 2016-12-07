using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject1
{
    class Page
    {
        protected IWebDriver driver;

        [FindsBy(How = How.Id, Using = "signIn")]
        protected IWebElement signIn;

        public Page(IWebDriver driver_)
        {
            driver = driver_;
            PageFactory.InitElements(driver, this);
        }

        // Используется в двух классах, поэтому выносим его в класс предка
        public Boolean SignInExists()
        {
            waitElement(By.Id("signIn"));
            return signIn.GetAttribute("name").Contains("signIn");
        }

        protected void waitElement(By locator)
        {
            IWebElement signOutLink = (new WebDriverWait(driver, new TimeSpan(0, 0, 5)))
            .Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
