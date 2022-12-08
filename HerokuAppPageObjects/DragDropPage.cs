using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace HerokuApp.WebImplementation
{
    public class DragDropPage : BasePage
    {
        private static By first = By.CssSelector("#column-a"); 
        private static By second = By.CssSelector("#column-b"); 
        public DragDropPage(IWebDriver driver) : base(driver) { }

        public string FirstElement { get { return this._driver.FindElement(first)
                    .FindElement(By.TagName("header"))
                    .Text.Trim().StartsWith("A")? "A" : "B";
            } }

        public void dragAtoB()
        {
            Actions dragDrop = new Actions(this._driver);
            dragDrop.DragAndDrop(this._driver.FindElement(first), this._driver.FindElement(second)).Build().Perform();
        }
    }
}
