using Heruko.Operations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.WebImplementations
{
    public class BasicAuth : IBasicAuth
    {

        private IWebDriver driver;
        private By heading = By.TagName("h3");

        public BasicAuth(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string verifyHeading()
        {
            string actual = driver.FindElement(heading).Text;
            return actual;
        }
    }
}
