using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using HerokuApp.Operations;
using OpenQA.Selenium.Chrome;
using System.Runtime.CompilerServices;

namespace HerokuAppPageObjects
{
    public  class ABTestPage: IABTesting
    {
        //private By heading;
        private static IWebDriver _driver;
        private By heading = By.TagName("H3");

        public ABTestPage()
        {
            _driver = new ChromeDriver();
        }

        public ABTestPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string Paragraph => throw new NotImplementedException();
        public string HeadingText { get { return _driver.FindElement(heading).Text; } }
        public void validateTextMessage() { }

        public void verifyHeading()
        {
            Console.WriteLine("Yes verified");
        }

        public void verifyParagraph()
        {
            //
            Console.WriteLine("Yes Para Verified");
        }

        
        
    }
}
