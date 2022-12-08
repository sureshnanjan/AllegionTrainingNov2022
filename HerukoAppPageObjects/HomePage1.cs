using Heruko.Operations;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium;
using HerukoAppPageObjects;
using System.Collections.ObjectModel;
using HerukoAppTests;
using System.Diagnostics;

namespace HerukoAppWebImplementations
{
    public class HomePage1 : IHomePage
    {
        private IWebDriver _driver;
        private static By addRemoveTestLink = By.LinkText("Add/Remove Elements");
        private static By basicAuthTestLink = By.LinkText("Basic Auth");
        private static By DragDropLink = By.LinkText("Drag and Drop");

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

        public BasicAuthTestPage navigateToBasicAuthPage()
        {
            
            return new BasicAuthTestPage(_driver);
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

        public void DisableAddRemoveTesting()
        {
            _driver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut", "True"));
            _driver.Navigate().Refresh();
        }

        public void GetLogs()
        {
            ReadOnlyCollection<string> logtypes = _driver.Manage().Logs.AvailableLogTypes;
            foreach (string logtype in logtypes)
            {
                Console.WriteLine(logtype);
            }
            Console.WriteLine(_driver.Manage().Logs.GetLog("browser"));
        }

        private static By alertslink = By.LinkText("JavaScript Alerts");
        public AlertTestPage navigateToAlerts()
        {
            this._driver.FindElement(alertslink).Click();
            return new AlertTestPage(this._driver);
        }

        //public DragDropPage navigateToDragDrop()
        //{
        //    this._driver.FindElement(DragDropLink).Click();
        //    return new DragDropPage(this._driver);
        //}

    }
}