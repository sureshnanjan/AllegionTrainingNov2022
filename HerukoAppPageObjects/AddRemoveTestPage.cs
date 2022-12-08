using Heruko.Operations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerukoAppPageObjects
{
    public class AddRemoveTestPage : IAddRemoveElements
    {
        private static IWebDriver _driver;
        public AddRemoveTestPage()
        {
            _driver = new ChromeDriver();
        }

        public AddRemoveTestPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void AddElementForOneItem()
        {

            Console.WriteLine("Elements are Added for one item");   
        }

        public void RemoveElementForOneItem()
        {
            Console.WriteLine("Elements are remove for one item");
        }

        public static void DisableAddRemoveTesting()
        {
            _driver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut","True"));
            _driver.Navigate().Refresh();
        }

        public void GetLogs()
        {
            ReadOnlyCollection<string> logtypes =  _driver.Manage().Logs.AvailableLogTypes;
            Console.WriteLine(_driver.Manage().Logs.GetLog(logtypes[0])); 

            
        }
    }
}
