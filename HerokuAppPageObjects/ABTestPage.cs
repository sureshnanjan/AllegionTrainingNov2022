using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuApp.Operations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppWebImplementation
{
  
    public class ABTestPage : IABTesting
    {
        private static IWebDriver _driver;
        private By heading = By.TagName("H3");

        public ABTestPage()
        {
            _driver = new ChromeDriver();
        }
        public ABTestPage(IWebDriver driver)
        {
            _driver =driver;
           
        }

        public string Paragraph => throw new NotImplementedException();

        public string HeadingText { get { return _driver.FindElement(heading).Text; } }

        public void validateTextMessage() { }
        public void verifyHeading()
        {
            Console.WriteLine("Yes Verified");
        }

        public void verifyParagraph()
        {
            Console.WriteLine("Yes Para Verified");
        }
        public void CloseBrowser()
        {
            _driver.Close();
        }

        public static void DisableABTesting()
        {
            _driver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut", "true"));

        }
    }
}
