using OpenQA.Selenium;
namespace HerokuAppWebImplementation
{
    public class BasicAuth
    {
        private IWebDriver _driver;
        public BasicAuth(IWebDriver driver)
        {
            this._driver = driver;

        }
        private By heading;
        private By welcome_text;

        public string Heading =>"Basic Auth";
    }
}