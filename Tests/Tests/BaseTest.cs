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
        public static IWebDriver _chrome;
        public static IWebDriver _edge;
        public static IWebDriver _firefox;
        public temp _temp;

        public BaseTest()
        {
            _chrome = new ChromeDriver();
            _chrome.Manage().Window.Maximize();
        }
        [TestInitialize]
        public void TestInitialize()
        {
            _temp = new temp(_chrome);
        }
    }
}
