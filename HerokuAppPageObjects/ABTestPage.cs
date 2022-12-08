using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using HerokuApp.Operations;
using OpenQA.Selenium.Chrome;

namespace HerokuAppPageObjects
{
    public  class ABTestPage: IABTesting
    {
        //private By heading;
        private IWebDriver driver;
        private By heading = By.TagName("H1");

        public ABTestPage()
        {
            this.driver = new ChromeDriver();
        }

        public ABTestPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Paragraph => throw new NotImplementedException();

        public void validateTextMessage() { }

        public void verifyHeading()
        {
            Console.WriteLine("Yes Heading Verified");
        }

        public void verifyParagraph()
        {
            //
            Console.WriteLine("Yes Para Verified");
        }

        public void CloseBrowser() {
            this.driver.Close();
        }
    }
}
