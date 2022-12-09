using HeroKuApp.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace HeroKuApp.WebImplementation
{
    public class ABTesting: IABTesting
    {
        private IWebDriver _driver;
        private By headingLink = By.TagName("h3");

        public ABTesting(IWebDriver driver)
        {
            this._driver = driver;
        }

        public string VerifyABTestingPageHeading()
        {
           return _driver.FindElement(headingLink).Text;
        }

        public void VerifyABTestingPageParagraph()
        {
            throw new NotImplementedException();
        }
    }
}
