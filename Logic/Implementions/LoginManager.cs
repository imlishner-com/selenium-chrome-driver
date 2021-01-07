using OpenQA.Selenium;
using Pages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Implementions
{
    public class LoginManager
    {
        private readonly LoginPage _examplePage;
        private readonly string _title = "Munters Sign in";
        public LoginManager(IWebDriver webDriver)
        {
            _examplePage = new LoginPage(webDriver);
        }
        public bool IsAtPage()
        {
            return _examplePage.GetPageTitle().Contains(_title);
        }
        public void GoToPage()
        {
            _examplePage.GoToPage();
        }
        public void SignIn(string name ,string password)
        {
            _examplePage.SendKeysSignInName(name);
            _examplePage.SendKeysSignInPassword(password);
            _examplePage.ClickSignIn();
        }
    }
}
