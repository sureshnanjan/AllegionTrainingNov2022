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

        [TestMethod]
        public void BasicAuthWorkswithCorrectCredentials() {
            BasicAuthPage result = _page.navigateToBasicAuth("admin", "admin");
            Assert.AreEqual("Basic Auth", result.Heading);
        }

        [TestMethod]
        public void BasicAuthWorkswithInCorrectCredentials()
        {
            BasicAuthPage result = _page.navigateToBasicAuth("incorrect", "admin");
            Assert.AreEqual("Unauthorised", result.Heading);
        }

        [TestMethod]
        public void AlertsHandlingWorks() {
            AlertsPage result = _page.navigateToAlerts();
            result.InvokeJsAlert();
            string actualText =  result.getText();
            result.Accept();
            Assert.AreEqual("I am a JS Alert", actualText);
        }

        [TestMethod]
        public void DragAtoB() {
            DragDropPage result = _page.navigateToDragDrop();
            result.dragAtoB();
            Assert.AreEqual("B", result.FirstElement);
        }

        [TestCleanupAttribute]
        public void CleanUp() {
            _page.CloseBrowser();
        }
    }
}
