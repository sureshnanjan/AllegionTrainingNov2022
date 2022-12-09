using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using HerukoAppWebImplementations;
using HerukoAppPageObjects;

namespace HerukoAppTests
{
    [TestClass]
    public class HerukoAppTests
    {
        private HomePage1 _page;

        [TestInitialize]
        public void init()
        {
            _page = new HomePage1();
        }

        [TestMethod]
        public void AddElementForOneItemWorks()
        {
            AddRemoveTestPage testAdd = _page.navigateToAddRemoveTestPage();
            testAdd.AddElementForOneItem();           
        }

        [TestMethod]
        public void Getlogs()
        {
            _page.GetLogs();
        }

        [TestMethod]
        public void VerifyBasicAuthForCorrectCredentials()
        {
            BasicAuthTestPage check = _page.navigateToBasicAuthPage("admin","admin");
            Assert.AreEqual("Basic Auth", check.VerifyHeading());

        }

        [TestMethod]
        public void VerifyBasicAuthForIncorrectCredentials()
        {
            BasicAuthTestPage result = _page.navigateToBasicAuthPage("a","an");
            Assert.AreNotEqual("Basic Auth",result.VerifyHeading());
        }

        [TestMethod]
        public void AlertsHandlingWorks()
        {
            AlertTestPage resut = _page.navigateToAlerts();
            resut.InvokeJsAlert();
            string actualText = resut.getText();
            resut.Accept();
            Assert.AreEqual("I  am a JS Alert", actualText);
        }

        [TestMethod]
        public void DragAtoB()
        {
            //DragDropPage restult = _page.navigateToDragDrop();
        }

    }
    
}
