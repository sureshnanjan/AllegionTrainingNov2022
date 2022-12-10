using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllegionTrainingNov2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //ChromeDriver _browser = new ChromeDriver();
            EdgeDriver _browser = new EdgeDriver();
            // _browser.Url = "https://www.myntra.com/";

            //RemoteWebDriver _browser = new RemoteWebDriver(new Uri("http://localhost:8085"),new ChromeOptions());
            _browser.Url = "https://the-internet.herokuapp.com/";
            Console.WriteLine(_browser.Title);
            IWebElement headingElement = _browser.FindElement(By.TagName("H1"));
            string actualHeadingText = headingElement.Text;
            if (actualHeadingText.Equals("Welcome to the-internet"))
            {
                Console.WriteLine("Yes the text is a success");
            }
            else
            {
                Console.WriteLine("No text is failure");
            }
            //headingElement.Text;
            _browser.Close();




            //MyUtility.Greetings inst1 = new MyUtility.Greetings();
            //string ans1 = inst1.SayHelloQA();
            //if(ans1.Equals("Welcome to QA"))
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("Failure");
            //}



            //Console.WriteLine();
            ////Array.BinarySearch();
            //Greetings g = new Greetings();
            //g.SayHelloQA();
            //g.SayHelloDev();
            //g.SayHelloTimes(2, "Allegion");
            //g.SayHelloTimes(-2, "Allegion");
            //Console.ReadKey();
        }

    }
}
    
