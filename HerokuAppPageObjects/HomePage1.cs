using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using HerokuApp.Operations;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;

namespace HerokuAppWebImplementation
{
    public class HomePage1 : BasePage, IHomePage
    {
        private By heading = By.TagName("H1");
        private static By abtestlink = By.LinkText("A/B Testing");
        private static By alertslink = By.LinkText("JavaScript Alerts");
        private static By dragdroplink = By.LinkText("Drag And Drop");
       ;

        public HomePage1()
        {
            switch(readConfig("browser"))
            {
                case "chrome":
                    _driver = new RemoteWebDriver(new Uri("http://localhost:8085"), new ChromeOptions());
                    break;
                case "firefox":
                    _driver = new RemoteWebDriver(new Uri("http://localhost:8086"), new FirefoxOptions());
                    break;
                default:
                    _driver = new ChromeDriver();
                    break;

            }
            _driver.Navigate().GoToUrl(readServerURL());

        }
        public ABTestPage navigateToABTest()
        {
            _driver.FindElement(abtestlink).Click();
            return new ABTestPage(_driver);
        }

        private string readServerURL()
        {
            return "https://the-internet.herokuapp.com/";
        }

        private string readConfig(string item)
        {
            return "chrome1";
        }

        public string verifyHeadder()
        {
            IWebElement headertext = _driver.FindElement(By.TagName("h1"));
            return headertext.Text;
        }

            public void verifySubheading()
            {
                throw new NotImplementedException();
            }
        public void DisableABTesting()
        {
            this._driver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut", "true"));
            this._driver.Navigate().Refresh();
        }
        public BasicAuth navigateToBasicAuth(string uname,string pass)
        {
            _driver.Navigate().GoToUrl($"https://{uname}:{pass}@the-internet.herokuapp.com/basic_auth");
            return new BasicAuth(_driver);
        }

        public AlertsPage navigateToAlerts()
        {
            this._driver.FindElement(alertslink).Click();
            return new AlertsPage(this._driver);

        }
        public DragDropPage navigateToDragDrop()
        {
            this._driver.FindElement(dragdroplink).Click();
            return new DragDropPage(this._driver);
        }

        string IHomePage.verifyHeadder()
        {
            throw new NotImplementedException();
        }
    }
    
}