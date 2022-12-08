using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Interactions;

namespace HerokuAppWebImplementation
{
    public class DragDropPage:BasePage
    {
        private static By first = By.CssSelector("#column-a");
        private static By second = By.CssSelector("#column-b");

        public DragDropPage(IWebDriver driver):base(driver){ }

        private string FirstElement { get { return this._driver.FindElement(first).FindElement(By.TagName("header")).Text.StartsWith("A") ? "A" : "B"; } }

        public void dragAtoB()
        {
            Actions dragdrop = new Actions(this._driver);
            dragdrop.DragAndDrop(this._driver.FindElement(first), this._driver.FindElement(second)).Build().Perform();     

        }
    }
}