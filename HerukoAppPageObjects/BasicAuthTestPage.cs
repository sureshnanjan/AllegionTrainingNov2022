using Heruko.Operations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerukoAppPageObjects
{
   public class BasicAuthTestPage : IBasicAuth,ICommon
    {
        private IWebDriver _driver;
        private By paragraph = By.TagName("p");
        private By heading = By.TagName("h3");

        public BasicAuthTestPage(IWebDriver driver)
        {
            this._driver = driver;
        }
        public string VerifyHeading()
        {
           return _driver.FindElement(heading).Text;
        }
        public bool Verifyparagraph()
        {
            return _driver.FindElement(paragraph).Displayed;
        }

        public void WhetherForkMeOnGithubIsRouting()
        {
            throw new NotImplementedException();
        }

        public void VerifyTheFooterWorksOrnot()
        {
            throw new NotImplementedException();
        }

      
    }
}
