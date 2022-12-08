using Heruko.Operations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerukoAppPageObjects
{
   public class BasicAuthTestPage : IBasicAuth
    {
        private IWebDriver _driver;
        private By heading = By.TagName("h3");

        public BasicAuthTestPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string VerifyAuthenticationWithCorrectPassword(string username, string password)
        {
          _driver.Navigate().GoToUrl($"https://{username}:{password}@the-internet.herokuapp.com/basic_auth");
            return _driver.FindElement(heading).Text;

        }

        public string VerifyAuthenticationWithCorrectPassword()
        {
            throw new NotImplementedException();
        }

        public string VerifyAuthenticationWithIncorrectPassword(string username,string password)
        {
            _driver.Navigate().GoToUrl($"https://{username}:{password}@the-internet.herokuapp.com/basic_auth");
            return _driver.FindElement(heading).Text;
        }

        public void VerifyAuthenticationWithIncorrectPassword()
        {
            throw new NotImplementedException();
        }
    }
}
