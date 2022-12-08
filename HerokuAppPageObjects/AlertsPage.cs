using OpenQA.Selenium;
using System;

namespace HerokuAppWebImplementation
{
    public class AlertsPage:BasePage
    {
        private static By content = By.Id("content");
        private IWebElement JsAlert { get { return this._driver.FindElement(content).FindElement(By.CssSelector("div >ul> li:nth-child(1)>button")); } }

        public AlertsPage(IWebDriver driver) : base(driver) { }
        

        public void Accept()
        {
            this._driver.SwitchTo().Alert().Accept();

        }
        public string getText()
        {
            return this._driver.SwitchTo().Alert().Text;
        }

        public void InvokeJsAlert()
        {
            JsAlert.Click();
        }
    }
}