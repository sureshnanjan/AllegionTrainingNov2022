using OpenQA.Selenium;
namespace HerokuApp.WebImplementation
{
    public class BasicAuthPage
    {
        private IWebDriver _driver;
        public BasicAuthPage(IWebDriver driver)
        {
            this._driver = driver;
        }
        private By heading;
        private By welcome_text;

        public string Heading => "Basic Auth";
    }
}