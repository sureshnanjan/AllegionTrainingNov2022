using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HerokuApp.WebImplementation;
using HerokuAppPageObjects;

namespace HerokuAppTests
{
    [TestClass]
    public class HerokuAppTests
    {
        private HomePage1 _page; // = new HomePage1

        [TestInitialize] 
        public void Init() {
            _page = new HomePage1();
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void AccessingABTestingWorks()
        {
            ABTestPage testPage = _page.navigateToABTest();
            testPage.verifyParagraph();
        }
        [TestCleanupAttribute]
        public void CleanUp() {
            _page.CloseBrowser();
        }
    }
}
