using OpenQA.Selenium;
using Pages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Implementions
{
   public  class DashboardCentralManager
    {
        private readonly DashboardCentralPage _dashboardCentralPage;
        private readonly string _title = "Munters Sign in";
        public DashboardCentralManager(IWebDriver webDriver)
        {
            _dashboardCentralPage = new DashboardCentralPage(webDriver);
        }
        public void ClickMenu()
        {
            _dashboardCentralPage.ClickOnMenu();
        }
        public void GoToFirstRoom()
        {
           var  rooms  = _dashboardCentralPage.GetRoomsMenu();
            rooms.FirstOrDefault().Click();
        }
        public void ClickOmRoomMenu()
        {
            _dashboardCentralPage.ClickRoomMenu();

        }
        public void ClickOnClimate()
        {
            _dashboardCentralPage.ClickClimate();
        }
        public void ClickOnControl()
        {
            _dashboardCentralPage.ClickControl();

        }
        public void ClickOnClimateMenuByIndex(int index)
        {
           var menu = _dashboardCentralPage.GetClimateMenu();
            menu[index].Click();
        }
        public void ClickEditClimate()
        {
            _dashboardCentralPage.ClickEditClimate();
        }
        public void EditAllDayCell()
        {
            var rnd = new Random();
            ClickEditClimate();
            var list = _dashboardCentralPage.GetAllDaySell();
            list.ForEach(x =>
            {
                x.SendKeys(rnd.Next(1, 8).ToString());
            });
        }

    }
}
