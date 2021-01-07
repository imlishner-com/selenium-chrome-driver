using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Helper
{
    public static class DriverExtensions
    {
        public static Func<IWebDriver, bool> ElementIsVisible(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception ex)
                {
                    throw  ex;
                }
            };
        }
        public static void WaitForElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
         
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            ElementIsVisible( wait.Until(drv => drv.FindElement(by)));

       
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {

            if (timeoutInSeconds > 0)

            {

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

                return wait.Until(drv => drv.FindElement(by));

            }

            return driver.FindElement(by);

        }
    }
}
