using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using HerokuApp.Operations;
using System;
using OpenQA.Selenium.Firefox;
using HerokuAppPageObjects;

namespace HerokuApp.WebImplementation
{
    public class HomePage1: BasePage, IHomePage
    {
        private By heading = By.TagName("H1");
        private static By abtestLink = By.LinkText("A/B Testing");
        private static By alertsLink = By.LinkText("JavaScript Alerts");
        private static By dragDropLink = By.LinkText("Drag and Drop");
        //private By 
        public HomePage1()
        {
            // Reading Things from Config File
            switch (readConfig("browser"))
            {
                case "chrome": 
                    this._driver = new RemoteWebDriver(new Uri("http://localhost:8085"), new ChromeOptions());
                    break;
                case "firefox":
                    this._driver = new RemoteWebDriver(new Uri("http://localhost:8086"), new FirefoxOptions());
                    break;
                default:
                    this._driver = new ChromeDriver();
                    break;
            }

            this._driver.Navigate().GoToUrl(readServerURL());

           
        }

        public ABTestPage navigateToABTest() { 
            _driver.FindElement(abtestLink).Click();
            return new ABTestPage(_driver);
        }

        public BasicAuthPage navigateToBasicAuth(string uname, string pwd)
        {
            _driver.Navigate().GoToUrl($"https://{uname}:{pwd}@the-internet.herokuapp.com/basic_auth");
            return new BasicAuthPage(_driver);
        }

        private string readConfig(string item) {
            return "chrome";
        }

        private string readServerURL() {
            return "https://the-internet.herokuapp.com/";
        }

        public void DisableABTesting()
        {
            this._driver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut", "true"));
            this._driver.Navigate().Refresh();
        }

        public AlertsPage navigateToAlerts()
        {
            this._driver.FindElement(alertsLink).Click();
            return new AlertsPage(this._driver);
        }

        public DragDropPage navigateToDragDrop()
        {
            this._driver.FindElement(dragDropLink).Click();
            return new DragDropPage(this._driver);
        }
    }
}
