using Logic.WebApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests
{
  

    [TestClass]
    public class BaseTest
    {
        public readonly IWebDriver _chrome;
        public readonly IWebDriver _edge;
        public readonly IWebDriver _firefox;
        public TestUIApplication _application;
        protected readonly string _userName = "demo@munters.co.il";
        protected readonly string _password = "Demo123456";

        public BaseTest()
        {
            _chrome = new ChromeDriver();
            _chrome.Manage().Window.Maximize();
        }
        [TestInitialize]
        public void TestInitialize()
        {
            _application = new TestUIApplication (_chrome);
            _application._loginManager.GoToPage();
            if (! _application._loginManager.IsAtPage())//to do add wait
            {
                throw new Exception("Failed to load login page");
            }
            _application._loginManager.SignIn(_userName, _password);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            _chrome.Close();
        }

    }
}
