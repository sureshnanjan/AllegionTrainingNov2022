using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            TestString One = new TestString("niku");
            TestString Two = new TestString("mama");

            TestString result = One + Two;
            result.display();
            Console.ReadKey();
            /*
            MyAllegionUtility.Geetings inst1 = new MyAllegionUtility.Geetings();
            string ans1 = inst1.SayHelloQA();
            if (ans1.Equals("Welcome to QA"))
            {
                Console.WriteLine("Success");
            }
            else { Console.WriteLine("Failure"); }
            ChromeDriver _browser= new ChromeDriver();
            _browser.Url = "https://the-internet.herokuapp.com";
            Console.WriteLine(_browser.Title);
            IWebElement headingElement = _browser.FindElement(By.TagName("H1"));
            string actulalHEadingText = headingElement.Text;
            if (actulalHEadingText.Equals("Welcome to the-internet"))
            {
                Console.WriteLine("Yes, Test is successed");
            }
            else
            {
                Console.WriteLine("No, Its a failure");
            }
            _browser.Close();
            // headingElement.Text
           // Console.WriteLine(headingElement.Text);
           // _browser.Close();

            */


        }
        public class TestString
        {
            private string mytext;

            public TestString(string text)
            {
                this.mytext = text;
            }

            public TestString()
            {

            }

            public static TestString operator +(TestString one, TestString two)
            {
                TestString three = new TestString();
                three.mytext = one.mytext + two.mytext;
                return three;
            }

            internal void display()
            {
                Console.WriteLine(mytext);
            }
        }
    }
}
