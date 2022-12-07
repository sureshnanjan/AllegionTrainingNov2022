using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace HerokuAppTest
{
    [TestClass]
    public class HerokuAppTest
    { /// <summary>
      ///  Here we are going to test the Add and Remove option in the web site
      ///  we are testing the add elements buttons and delete those buttons 
      ///  here we test the add button valadation the delete button 
      /// </summary>
        [TestMethod]
        public void AddRemoveElementsFunctionsCorrectlyForOneItem()
        {
            ///Arrange
            ChromeDriver _browser = new ChromeDriver();
            _browser.Url = "https://the-internet.herokuapp.com";



            IWebElement AddRemoveButtonClick = _browser.FindElement(By.XPath("//a[text()='Add/Remove Elements']"));
            AddRemoveButtonClick.Click();



            IWebElement buttonFirst = _browser.FindElement(By.XPath("//button[text()='Add Element']"));
            buttonFirst.Click();

            ReadOnlyCollection<IWebElement> deleteButton = _browser.FindElements(By.XPath("//button[@class='added-manually']"));



            Assert.AreEqual(1, deleteButton.Count);
        }

        [TestMethod]
        public void RemoveElementsFunctionsCorrectlyForOneItem()
        {
            
            ///Arrange
            ChromeDriver _browser = new ChromeDriver();
            _browser.Url = "https://the-internet.herokuapp.com";



            IWebElement AddRemoveButtonClick = _browser.FindElement(By.XPath("//a[text()='Add/Remove Elements']"));
            AddRemoveButtonClick.Click();

            IWebElement ButtonAdd = _browser.FindElement(By.XPath("//a[text()='Add Element']"));
            ButtonAdd.Click();

            IWebElement buttonDelete = _browser.FindElement(By.XPath("//button[text()='Delete']"));
            buttonDelete.Click();

            ReadOnlyCollection<IWebElement> deleteButton = _browser.FindElements(By.XPath("//button[@class='added-manually']"));



            Assert.AreEqual(0, deleteButton.Count);

        }
       
        //AAA

        //[TestMethod]
        //public void AddremoveElementsFuntionCorrectlyForOneItem()
        //{
        //    ChromeDriver browser = new ChromeDriver();
        //    browser.Url = "https://the-internet.herokuapp.com/add_remove_elements/";
        //    Console.WriteLine(browser.Title);
        //    IWebElement headElement = browser.FindElement(By.TagName("h3"));
        //    string actualHeadingText = headElement.Text;
        //    if (actualHeadingText.Equals("Add/Remove Elements"))

        //        {
        //            Console.WriteLine("yes the test is pass");

        //        }
        //        else
        //        {
        //            Console.WriteLine("no the test has failed ");
        //        }

        //IWebElement ButtonElement = browser.FindElement(By.TagName("button"));
        //string actualButtonClick = ButtonElement.Click;
        //if (actualButtonClick.Equals("Add"))

        //{
        //    Console.WriteLine("yes the test is pass");

        //}
        //else
        //{
        //    Console.WriteLine("no the test has failed ");
        //}
    }
    
}
