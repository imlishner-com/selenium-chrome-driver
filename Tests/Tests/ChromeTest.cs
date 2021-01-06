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
            _temp.goToPage();
        }
    }
}
