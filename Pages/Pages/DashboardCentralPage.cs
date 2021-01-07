using Helpers.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Pages
{
    public class DashboardCentralPage : BasePage
    {
        private readonly By _menuButton = By.Id("treeview_active");
        private readonly By _climateBtn = By.Id("Climate");
        private readonly By _controlBtn = By.Id("Control");
        //private readonly By _roomsMenu = By.XPath("*//[@data-uid='trio']");
        private readonly By _roomsMenu = By.XPath($"//*[contains(@data-uid,'trio')]");
        //private readonly By _roomMenuBtn = By.XPath("//button[contains(@class, 'header-item') and contains(@class, 'header-button')]");
        private readonly By _roomMenuBtn = By.CssSelector("div[class='button-icon-24 icon-small icon-menu']");
        private readonly By _iframe = By.TagName("iframe");
        private readonly By _climateMenu = By.CssSelector("div[class='menu-table-list ng-star-inserted']");
        private readonly By _editBtn = By.CssSelector("div[class='toolbar-button icon-button icon-medium button-edit ng-star-inserted']");
      // private readonly By _daycell = By.XPath("//div[contains(@class,'grid-cell-container temp-curv-day')]");
        private readonly By _daycell = By.XPath($"//*[contains(@id,'cell_c1')]");

        public DashboardCentralPage(IWebDriver driver) : base(driver)
        {

        }
        public override void GoToPage() { }
        public void ClickOnMenu()
        {
            _driver.WaitForElement(_menuButton, 20);
            var btn = _driver.FindElement(_menuButton);
            btn.Click();
        }
        public List<IWebElement> GetRoomsMenu()
        {
            
            _driver.WaitForElement(_roomsMenu, 5);
            var rooms = _driver.FindElements(_roomsMenu);
            return rooms.ToList();
        }
        private void SwitchToIframe()
        {
            var i = _driver.FindElements(_iframe);
            _driver.SwitchTo().Frame(i.FirstOrDefault());
        }

        public void ClickRoomMenu()
        {
            SwitchToIframe();

            _driver.WaitForElement(_roomMenuBtn, 5);
            var menu = _driver.FindElements(_roomMenuBtn);
            menu.FirstOrDefault().Click();
        }
        public void ClickControl()
        {
            //SwitchToIframe();
            var btn = _driver.FindElement(_controlBtn,5);
            btn.Click();
        }
        public void ClickClimate()
        {
            var btn = _driver.FindElement(_climateBtn, 5);
            btn.Click();
        }
        public List<IWebElement> GetClimateMenu()
        {
           var menu = _driver.FindElements(_climateMenu);
            return menu.ToList();
        }
        public void ClickEditClimate()
        {
            var btn = _driver.FindElement(_editBtn , 5);
             btn.Click();
        }
        public List<IWebElement> GetAllDaySell()
        {
            var rnd = new Random();

            var list = _driver.FindElements(_daycell).ToList();
            list.ForEach(x =>
            {
                x.FindElement(By.TagName("span")).FindElement(By.TagName("input")).Clear();
                x.FindElement(By.TagName("span")).FindElement(By.TagName("input")).SendKeys(rnd.Next(1, 8).ToString());
            });
            return list.ToList();
        }
    }
}
