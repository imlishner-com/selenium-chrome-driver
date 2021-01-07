using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests
{
    [TestClass]
    public class ChromeTest: BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            _application._dashboardCentralManager.ClickMenu();
            _application._dashboardCentralManager.GoToFirstRoom();
            _application._dashboardCentralManager.ClickOmRoomMenu();
            //for some reason "Control" is empty not as expected from task
            //_application._dashboardCentralManager.ClickOnControl();
            _application._dashboardCentralManager.ClickOnClimate();
            _application._dashboardCentralManager.ClickOnClimateMenuByIndex(0);
            _application._dashboardCentralManager.EditAllDayCell();

        }
    }
}
