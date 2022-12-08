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
        [TestMethod]
        public void AccessingABTestingShowsABTestPage()
        {
            ABTestPage testPage = _page.navigateToABTest();
            Assert.AreEqual("A/B Test Variation 1", testPage.HeadingText);
        }

        [TestMethod]
        public void AccessingABTestingShowsNoABTestPageWhenDisabled()
        {
            _page.DisableABTesting();
            ABTestPage testPage = _page.navigateToABTest();
            Assert.AreEqual("No A/B Test", testPage.HeadingText);
        }


        [TestCleanupAttribute]
        public void CleanUp() {
            _page.CloseBrowser();
        }
    }
}
