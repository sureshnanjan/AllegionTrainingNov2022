using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace HerokuAppTests
{
    [TestClass]
    public class HerokuAppTests
    {
        /// <summary>
        /// The test checks Add and Remove functions for one item
        /// when the Add button is clickde it must add a button for deleting an element
        /// When the delete button is clicked the existing delete button must be deleted.
        /// Check whether the redirected page id correct 
        /// </summary>
        [TestMethod]
        public void TestAddRemoveElementsFunctionsCorrectlyforOneItem()
        {
            //AAA
            EdgeDriver driver = new EdgeDriver();
            driver.Url = "https://the-internet.herokuapp.com/";
            IWebElement LinkButton = driver.FindElement(By.LinkText("Add/Remove Elements"));
            LinkButton.Click();

            IWebElement buttonadd = driver.FindElement(By.TagName("button"));
            buttonadd.Click();

            ReadOnlyCollection<IWebElement> buttondelete = driver.FindElements(By.ClassName("added-manually"));

            Assert.AreEqual(1, buttondelete.Count);



        }
        [TestMethod]

        public void TestRemoveElementsFunctionsCorrectlyForOneItem()
        {
            //AAA
            EdgeDriver driver = new EdgeDriver();
            driver.Url = "https://the-internet.herokuapp.com/";
            IWebElement LinkButton = driver.FindElement(By.LinkText("Add/Remove Elements"));
            LinkButton.Click();

            IWebElement buttonadd = driver.FindElement(By.TagName("button"));
            buttonadd.Click();

            IWebElement buttondelete = driver.FindElement(By.ClassName("added-manually"));
            buttondelete.Click();

            ReadOnlyCollection<IWebElement> buttondeleted = driver.FindElements(By.ClassName("added-manually"));

            Assert.AreEqual(0, buttondeleted.Count);
        }
    }
}
