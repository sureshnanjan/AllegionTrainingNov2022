using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace HerukoAppTests
{
    /// <summary>
    /// To Test the website https://the-internet.herokuapp.com/ , Whether it is working correctly or not
    /// </summary>
    [TestClass]
    public class HerokuAppTests
    {
        /// <summary>
        /// This method will check whether the function add and remove elements correctly or not
        /// </summary>
        [TestMethod]
        public void AddElementsFunctionsCorrectlyForOneItem()
        {
            ///Arrange
            ChromeDriver _browser = new ChromeDriver();
            _browser.Url = "https://the-internet.herokuapp.com";

            IWebElement AddButtonClick = _browser.FindElement(By.XPath("//a[text()='Add/Remove Elements']"));
            AddButtonClick.Click();
///act
            IWebElement buttonFirst =_browser.FindElement(By.XPath("//button[text()='Add Element']"));
            buttonFirst.Click();
           
            ReadOnlyCollection<IWebElement> countButton = _browser.FindElements(By.XPath("//button[@class='added-manually']"));

            Assert.AreEqual(1, countButton.Count);
           
        }

        [TestMethod]
        public void RemoveElementsFunctionsCorrectlyForOneItem()
        {
            ///Arrange
            ChromeDriver _browser = new ChromeDriver();
            _browser.Url = "https://the-internet.herokuapp.com";

            IWebElement AddRemoveButtonClick = _browser.FindElement(By.XPath("//a[text()='Add/Remove Elements']"));
            AddRemoveButtonClick.Click();

            IWebElement buttonAdd = _browser.FindElement(By.XPath("//button[text()='Add Element']"));
            buttonAdd.Click();

            ///Act
            IWebElement buttonDelete = _browser.FindElement(By.XPath("//button[@class='added-manually']"));
            buttonDelete.Click();

            ReadOnlyCollection<IWebElement> countButton = _browser.FindElements(By.XPath("//button[@class='added-manually']"));

            Assert.AreEqual(0, countButton.Count);
        }
    }
}
