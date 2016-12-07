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
    class LoginPage : Page
    {
        [FindsBy(How = How.Id, Using = "gb_70")]
        private IWebElement toLoginPageButton;

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement emailText;

        [FindsBy(How = How.Id, Using = "Passwd")]
        private IWebElement passwordText;

        [FindsBy(How = How.XPath, Using = ".//*[@id='link-signup']")]
        public IWebElement linkSignUp;

        [FindsBy(How = How.Id, Using = "next")]
        private IWebElement nexttButton;

        [FindsBy(How = How.Id, Using = "hplogo")]
        private IWebElement logotip;

        public LoginPage(IWebDriver driver_) : base(driver_)
        {
        }

        public LoginPage EnterToLoginPage()
        {
            toLoginPageButton.Click();
            return this;
        }

        public LoginPage SetLogin(string text)
        {
            new Actions(driver).SendKeys(emailText, text).Build().Perform();
            return this;
        }

        public LoginPage ClickNext()
        {
            new Actions(driver).Click(nexttButton).Build().Perform();
            return this;
        }

        public Boolean SignUpExists()
        {
            return linkSignUp.Text.Contains("Создать аккаунт");
        }

        public Boolean LogotipExists()
        {
            return logotip.GetAttribute("title").Equals("Google");
        }

        public LoginPage SetPassword(string password)
        {
            waitElement(By.Id("Passwd"));
            passwordText.SendKeys("vfhl.rtdbx32/");
            return this;
        }

        public LoginPage SigInClick()
        {
            signIn.Click();
            return this;
        }
    }
}
