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
    public class HomePage : IHomePage
    {
        
        public void RouteTopage(string pageName)
        {
            throw new NotImplementedException();
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
            RemoteWebDriver _remotebrowser = new RemoteWebDriver(new Uri("http://localhost:9515"), new ChromeOptions());
            _remotebrowser.Url = "https://the-internet.herokuapp.com/";
            IWebElement selectHeading = _remotebrowser.FindElementByXPath("//h1[@class='heading']");
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
    }
}
