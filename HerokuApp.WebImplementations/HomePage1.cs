using Heroku.Operations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HerokuApp.WebImplementations
{
    public class HomePage1 :IHomePage
    {
        private IWebDriver _driver;
        private By heading = By.TagName("H1");
        private static By abtestLink = By.LinkText("A/B Testing");
        //private By 
        public HomePage1()
        {
            // Reading Things from Config File
            switch (readConfig("browser"))
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
            _driver.FindElement(abtestLink).Click();
            return new ABTestPage(_driver);
        }

        private string readConfig(string item)
        {
            return "chrome";
        }

        private string readServerURL()
        {
            return "https://the-internet.herokuapp.com/";
        }

        public void CloseBrowser()
        {
            this._driver.Close();
        }
        public void DisableABTesting()
        {
            this._driver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut", "true"));
            this._driver.Navigate().Refresh();
        }
        public BasicAuth navigateToBasicAuth(string uname, string pass)
        {
            _driver.Navigate().GoToUrl($"https://{uname}:{pass}@the-internet.herokuapp.com/basic_auth");
            return new BasicAuth(_driver);
        }



        }
    }
