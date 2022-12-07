using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using System.Linq;

namespace HerokuAppTests
{
    /// <summary>
    /// Class <c>HerokuAppTests</c> models a tests cases for HerokuApp https://the-internet.herokuapp.com.
    /// </summary>
    [TestClass]
    public class HerokuAppTests
    {
        /// <summary>
        /// Method <c>AddRemoveElemetsFunctionsCorrectlyforOneItem</c> 
        /// in this webpage https://the-internet.herokuapp.com/add_remove_elements/ to check whether the add removal is working or not
        /// <example>
        /// For example:
        /// <code>
        ///  
        /// </code>
        /// results in <c> </c> having the value 
        /// </example>
        /// </summary>
        [TestMethod]
        public void AddElemetsFunctionsCorrectlyforOneItem()
        {
            //AAA
            //Arrange
            ChromeDriver _browser = new ChromeDriver();
            _browser.Url = "https://the-internet.herokuapp.com/";
            IWebElement buttonAB = _browser.FindElement(By.LinkText("Add/Remove Elements"));
            buttonAB.Click();


            //Act
            IWebElement buttonElement = _browser.FindElement(By.TagName("button"));
            buttonElement.Click();
           ReadOnlyCollection<IWebElement> buttonDelete = _browser.FindElements(By.ClassName("added-manually"));


            //Assert
           Assert.AreEqual(1, buttonDelete.Count());


        }
        [TestMethod]
        public void RemoveElemetsFunctionsCorrectlyforOneItem()
        {
            //AAA
            //Arrange
            ChromeDriver _browser = new ChromeDriver();
            _browser.Url = "https://the-internet.herokuapp.com/";
            IWebElement buttonAB = _browser.FindElement(By.LinkText("Add/Remove Elements"));
            buttonAB.Click();
            IWebElement buttonElement = _browser.FindElement(By.TagName("button"));
            buttonElement.Click();


            //Act
            IWebElement buttonDelete = _browser.FindElement(By.ClassName("added-manually"));
            buttonDelete.Click();
            ReadOnlyCollection<IWebElement> buttonDeleteCount = _browser.FindElements(By.ClassName("added-manually"));



            //Assert
            Assert.AreEqual(0, buttonDeleteCount.Count());


        }
        [TestMethod]
        public void AddElemetsFunctionsCorrectlyforMultipleItem()
        {
            //AAA
            //Arrange
            ChromeDriver _browser = new ChromeDriver();
            _browser.Url = "https://the-internet.herokuapp.com/";
            IWebElement buttonAB = _browser.FindElement(By.LinkText("Add/Remove Elements"));
            buttonAB.Click();


            //Act
            IWebElement buttonElement = _browser.FindElement(By.TagName("button"));
            buttonElement.Click();
            buttonElement.Click();
            buttonElement.Click();
            buttonElement.Click();
            buttonElement.Click();
            ReadOnlyCollection<IWebElement> buttonDelete = _browser.FindElements(By.ClassName("added-manually"));


            //Assert
            Assert.AreEqual(6, buttonDelete.Count());


        }
        [TestMethod]
        public void RemoveElemetsFunctionsCorrectlyforMultipleItem()
        {
            //AAA
            //Arrange
            ChromeDriver _browser = new ChromeDriver();
            _browser.Url = "https://the-internet.herokuapp.com/";
            IWebElement buttonAB = _browser.FindElement(By.LinkText("Add/Remove Elements"));
            buttonAB.Click();
            IWebElement buttonElement = _browser.FindElement(By.TagName("button"));
            buttonElement.Click();
            buttonElement.Click();
            buttonElement.Click();
            buttonElement.Click();
            buttonElement.Click();


            //Act
            IWebElement buttonDelete = _browser.FindElement(By.ClassName("added-manually"));
            buttonDelete.Click();
       

            ReadOnlyCollection<IWebElement> buttonDeleteCount = _browser.FindElements(By.ClassName("added-manually"));



            //Assert
            Assert.AreEqual(4, buttonDeleteCount.Count());


        }



    }
}