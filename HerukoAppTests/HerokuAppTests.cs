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
    }
    
}
