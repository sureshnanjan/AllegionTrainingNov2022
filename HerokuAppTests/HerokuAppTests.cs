using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HerokuAppWebImplementation;
namespace HerokuAppTests
   
{
    [TestClass]
    public class HerokuAppTests
    {
        private HomePage1 _page;
        [TestInitialize]
        public void Init()
        {
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
            Assert.AreEqual("A/B Test Control",testPage.HeadingText);
        }

        [TestMethod]
        public void AccessingABTestingShowsNoABTestPageWhenDisabled()
        {
            _page.DisableABTesting();
            ABTestPage testPage = _page.navigateToABTest();
            Assert.AreEqual("No A/B Test", testPage.HeadingText);
        }

        [TestCleanupAttribute]
        public void CleanUp()
        {
            _page.CloseBrowser();
        }

        [TestMethod]
        public void BasicAuthWorksWithCorrectCredentials()
        {
            BasicAuth result = _page.navigateToBasicAuth("admin", "admin");
            Assert.AreEqual("Basic Auth", result.Heading);
        }
        [TestMethod]
        public void BasicAuthWorksWithInCorrectCredentials()
        {
            BasicAuth result = _page.navigateToBasicAuth("Incorrect", "admin");
            Assert.AreEqual("Unauthorized", result.Heading);
        }

        [TestMethod]
        public void AlertsHandlingWorks()
        {
           AlertsPage resut =_page.navigateToAlerts();
            resut.InvokeJsAlert();
            string actualText = resut.getText();
            resut.Accept();
            Assert.AreEqual("I am a JS Alert", actualText);

        }

        [TestMethod]
        public void DragDropPage()
        {
            DragDropPage result =_page.navigateToDragDrop();
            result.dragAtoB();
            //Assert.AreEqual("B", result.FirstElement);
        }

        
    }
}
