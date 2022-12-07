using Heruko.Operations;
using OpenQA.Selenium;

namespace HerukoAppWebImplementations
{
    public class HomePage
    {
        public HomePage() { }

        private By heading = By.TagName("h1");
        private By subHeading = By.TagName("h2");
        private By logo;

        public ABTestPage NavigateToPage(string pageName)
        {
            switch (pageName)
            {
                case "AB Test Page": return new ABTestPage(); break;
                default: break;
            }
            return new ABTestPage();
        }

        public string Heading { get => Heading; }
        public By SubHeading { get => SubHeading; set => subHeading = value; }


    }
}