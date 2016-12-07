using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace NUnitTestProject1
{
    

    public class TestMyMail
    {
        private IWebDriver driver = new ChromeDriver();

        [Test, Order(1)]
        public void EnterToLoginPageTest()
        {
            driver.Url = "https://google.com";
            LoginPage page = new LoginPage(driver);
            Assert.IsTrue(page.EnterToLoginPage().SignUpExists());
        }

        [Test, Order(2)]
        public void LoginTest()
        {
            LoginPage page = new LoginPage(driver);
            Assert.IsTrue(page.SetLogin("valpetrovnatwo").ClickNext().SignInExists());
        }

        [Test, Order(3)]
        public void PasswordTest()
        {
            LoginPage page = new LoginPage(driver);
            Assert.IsTrue(page.SetPassword("vfhl.rtdbx32/").SigInClick().LogotipExists());
        }

        [Test, Order(4)]
        public void EnterToMailLstPageTest()
        {
            MailListPage page = new MailListPage(driver);
            Assert.IsTrue(page.GoToMailPage().SignOutExists());
        }

        [Test, Order(5)]
        public void LogoutTest()
        {
            LogoutPage page = new LogoutPage(driver);
            Assert.IsTrue(page.Logout().SignInExists());
            driver.Close();
        }

    }
    }

