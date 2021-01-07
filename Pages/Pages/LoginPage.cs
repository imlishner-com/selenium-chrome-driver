using Helpers.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Pages
{
    public class LoginPage :BasePage
    {
      
        private readonly By _signInName = By.Id("signInName");
        private readonly By _signInPassword = By.CssSelector("input[type='password']");
        private readonly By _SignInBtn= By.Id("next");

        public LoginPage (IWebDriver driver) : base(driver)
        {

        }
        public void SendKeysSignInName(string name)
        {
            var element = _driver.FindElement(_signInName, 10);
           

            element.SendKeys(name);
        }
        public void SendKeysSignInPassword(string password)
        {
            var element = _driver.FindElement(_signInPassword);
            element.SendKeys(password);
        }
        public void ClickSignIn()
        {
            var btn = _driver.FindElement(_SignInBtn);
            btn.Click();
        }

        public override void GoToPage()
        {
            _driver.Navigate().GoToUrl("https://www.trioair.net");
        }

        public  String GetPageTitle()
        {
           return _driver.Title;
        }
    }
}
