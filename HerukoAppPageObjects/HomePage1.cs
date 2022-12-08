using Heruko.Operations;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium;
using HerukoAppPageObjects;

namespace HerukoAppWebImplementations
{
    public class HomePage1 : IHomePage
    {
        private IWebDriver _driver;
        private static By addRemoveTestLink = By.LinkText("Add/Remove Elements");
        public HomePage1()
        {
            switch (readConfig("browser"))
            {
                case "chrome": _driver = new RemoteWebDriver(new Uri("http://localhost:9515"), new ChromeOptions());
                    break;
                case "firefox": _driver = new RemoteWebDriver(new Uri("http://localhost:9515"), new FirefoxOptions()); break;
                default:
                    _driver = new ChromeDriver(); break;
            }
            _driver.Navigate().GoToUrl(readServerURL());
        }

        private string readServerURL()
        {
            return "https://the-internet.herokuapp.com/";
        }

        public AddRemoveTestPage navigateToAddRemoveTestPage()
        {
            _driver.FindElement(addRemoveTestLink).Click();
            return new AddRemoveTestPage(_driver);
        }
        public void verifyFooter()
        {
            throw new NotImplementedException();
        }

        public string verifyHeading()
        {
            throw new NotImplementedException();
        }

        public void verifyNumberOfFeatures()
        {
            throw new NotImplementedException();
        }

        public void verifySubHeading()
        {
            throw new NotImplementedException();
        }

        private string readConfig(string item)
        {
            return "chrome";
        }
        
    }
}