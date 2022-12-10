using HeroKuApp.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.CodeDom;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.Extensions;

namespace HeroKuApp.WebImplementation
{
    public class HomePage : IHomePage
    {
        private IWebDriver _remotedriver;
        private By headingLink = By.TagName("h1");
        private By descriptionLink = By.TagName("h2");
        private By abTestingLink = By.LinkText("A/B Testing");
        private By basicAuthLink = By.LinkText("Basic Auth");
        private By javaScriptAlert = By.LinkText("JavaScript Alerts");
        private By dragAndDrop = By.LinkText("Drag and Drop");
        private By checkboxes = By.LinkText("Checkboxes");


        public HomePage(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    _remotedriver = new ChromeDriver();
                    //_remotedriver.Url = "https://the-internet.herokuapp.com/";
                    break;
                case "edge":
                    _remotedriver = new EdgeDriver();
                    //_remotedriver.Url = "https://the-internet.herokuapp.com/";
                    break;
                case "remote":
                    _remotedriver = new RemoteWebDriver(new Uri("http://localhost:9515"), new ChromeOptions());
                    //_remotedriver.Url = "https://the-internet.herokuapp.com/";
                    break;
                default:
                    break;
            }
            _remotedriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
        

        public ABTesting NavigateToABTesting()
        {
            _remotedriver.FindElement(abTestingLink).Click();
            return new ABTesting(_remotedriver);        
        }
        public BasicAuth NavigateToBasicAuth(string username, string password)
        {
            _remotedriver.Navigate().GoToUrl($"https://{username}:{password}@the-internet.herokuapp.com/basic_auth");
            return new BasicAuth(_remotedriver);
        }
        public JavaScriptAlert NavigateToJavaScriptAlert()
        {
            _remotedriver.FindElement(javaScriptAlert).Click();
            return new JavaScriptAlert(_remotedriver);
        }
        public DragAndDrop NavigateToDragAndDrop()
        {
            _remotedriver.FindElement(dragAndDrop).Click();
            return new DragAndDrop(_remotedriver);
        }
        public Checkboxes NavigateToCheckboxes()
        {
            _remotedriver.FindElement(checkboxes).Click();
            return new Checkboxes(_remotedriver);
        }
        public void DisableABTestingUsingCookies() 
        {
            _remotedriver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut", "true") );
        }
        public void VerifyFooter()
        {
            throw new NotImplementedException();
        }

        public void VerifyFooterLinkIsWorking()
        {
            throw new NotImplementedException();
        }

        public string VerifyHomePageDescription()
        {
            throw new NotImplementedException();
        }

        public string VerifyHomePageHeading()
        {
            IWebElement selectHeading = _remotedriver.FindElement(headingLink);
            string actual = selectHeading.Text;
            Console.WriteLine(actual);
            return actual;
        }

        public void VerifyImageIsVisible()
        {
            throw new NotImplementedException();
        }

        public void VerifyImageLinkIsWorking()
        {
            throw new NotImplementedException();
        }

        public void TakeScreenshot(string name)
        {
            _remotedriver.TakeScreenshot().SaveAsFile(name, ScreenshotImageFormat.Jpeg);
        }

        public void BrowserClose()
        {
            _remotedriver.Close();
        }
    }
}
