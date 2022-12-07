using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AllegionTrainingNov2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ChromeDriver _chbrowser = new ChromeDriver();
            //FirefoxDriver _browser = new FirefoxDriver();
            RemoteWebDriver _browser = new RemoteWebDriver(new Uri("http://localhost:8085"), new ChromeOptions());
            _browser.Url = "https://the-internet.herokuapp.com/";
            Console.WriteLine(_browser.Title);
            ChromeOptions opts= new ChromeOptions();
         
            IWebElement headingElement = _browser.FindElement(By.TagName("H1"));
            string actualHeadingText = headingElement.Text;
            if (actualHeadingText.Equals("Welcome to the-internet"))
            {
                Console.WriteLine("Yes The the test is success");
            }
            else
            {
                Console.WriteLine("No its a failure");
            }
            //headingElement.Text;
            _browser.Close();
            }

    }
}
