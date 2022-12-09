using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroKuApp.Operations;
using OpenQA.Selenium;

namespace HeroKuApp.WebImplementation
{
    public class BasicAuth : IBasicAuth
    {
        private IWebDriver remotedriver;
        private By heading = By.TagName("h3");

        public BasicAuth(IWebDriver remotedriver)
        {
            this.remotedriver = remotedriver;
        }

        public string VerifyBasicAuthHeading()
        {
            return remotedriver.FindElement(heading).Text;
        }
    }
}
