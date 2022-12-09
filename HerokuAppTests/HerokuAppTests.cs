﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Linq;
using HeroKuApp.WebImplementation;

namespace HerokuAppTests
{
    [TestClass]
    public class HerokuAppTests
    {
        private HomePage _page;

        [TestInitialize]
        public void Initialized()
        {
            _page = new HomePage("edge");   
        }
 //-----------------------------------------------------------------------------------------
        [TestMethod]
        public void ABTestingPageVerifyHeadingTC()
        {
            ABTesting test1 = _page.NavigateToABTesting(); 
            Assert.AreEqual("A/B Test Control", test1.VerifyABTestingPageHeading());
        }

        [TestMethod]
        public void BasicAuthPageVerifyAuthenticationTC() 
        {
            BasicAuth test1= _page.NavigateToBasicAuth("admin","admin");
            Assert.AreEqual("Basic Auth", test1.VerifyBasicAuthHeading());
        }

        [TestMethod]
        public void ABTestingPageCookiesDisabledTC() 
        {
            _page.DisableABTestingUsingCookies();
            ABTesting test1 = _page.NavigateToABTesting();
            Assert.AreEqual("No A/B Test", test1.VerifyABTestingPageHeading());
        }

        [DataTestMethod]
        [DataRow(1, "I am a JS Alert")]
        [DataRow(2, "I am a JS Confirm")]
        [DataRow(3, "I am a JS prompt")]
        public void VerifyJavaScriptAlertsPageTC2(int num, string expected)
        {
            JavaScriptAlert test1 = _page.NavigateToJavaScriptAlert();
            test1.ClickOnJSAlertItem(num);
            string actual = test1.GetJavaScriptText();
            test1.AcceptJavaScriptAlert();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DragAndDropPageTc()
        {
            DragAndDrop test = _page.NavigateToDragAndDrop();
            string actual = test.DragAndDropAction();
            Assert.AreEqual("B",actual);
        }
        //-----------------------------------------------------------------------------------------
        [TestCleanup]
        public void CleanupTest()
        {
            _page.BrowserClose();
        }
    }
}

