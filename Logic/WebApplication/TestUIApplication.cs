using Logic.Implementions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WebApplication
{
    public class TestUIApplication
    {
        public IWebDriver _driver;
        public TestUIApplication(IWebDriver driver)
        {
            _driver = driver;
        }
        public LoginManager _loginManager => new LoginManager(_driver);
        public DashboardCentralManager  _dashboardCentralManager => new DashboardCentralManager(_driver);
    }
}
