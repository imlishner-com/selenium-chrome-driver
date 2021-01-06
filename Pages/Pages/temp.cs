using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Pages
{
    public class temp:BasePage
    {
        public temp(IWebDriver driver) : base(driver)
        {

        }
        public void goToPage()
        {
           
           _driver.Navigate().GoToUrl("https://www.wikipedia.org/");
        }
    }
}
