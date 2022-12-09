using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroKuApp.Operations;
using OpenQA.Selenium;

namespace HeroKuApp.WebImplementation
{
    public class JavaScriptAlert : IJavaScriptAlert
    {
        private IWebDriver remotedriver;
        private By heading1 = By.XPath("//button[text()='Click for JS Alert']");
        private By heading2 = By.XPath("//button[text()='Click for JS Confirm']");
        private By heading3 = By.XPath("//button[text()='Click for JS Prompt']");
        public JavaScriptAlert(IWebDriver remotedriver)
        {
            this.remotedriver = remotedriver;
        }

        public void ClickOnJSAlertItem(int item)
        {
            switch (item) 
            {
                case 1:
                    remotedriver.FindElement(heading1).Click();
                    break;
                case 2:
                    remotedriver.FindElement(heading2).Click();
                    break;
                case 3:
                    remotedriver.FindElement(heading3).Click();
                    break;
                default:
                    break;
            }
        }
        public string GetJavaScriptText()
        {
            string actual = remotedriver.SwitchTo().Alert().Text;
            return actual;
        }
        public void AcceptJavaScriptAlert()
        {
            remotedriver.SwitchTo().Alert().Accept();
        }
    }
}
