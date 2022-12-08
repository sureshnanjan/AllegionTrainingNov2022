using OpenQA.Selenium;

namespace HerokuApp.WebImplementation
{
    public class BasePage
    {
        protected IWebDriver _driver;
        public BasePage()
        {

        }
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void CloseBrowser()
        {
            this._driver.Close();
        }
    }
}