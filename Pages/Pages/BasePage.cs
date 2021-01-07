using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver _driver;
        protected readonly WebDriverWait _driverWait;
        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        public abstract void GoToPage();
        //public abstract void IsAtPage();
    }
}
