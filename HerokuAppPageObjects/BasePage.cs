using OpenQA.Selenium;

namespace HerokuAppWebImplementation
{
    public class BasePage
    {
        public BasePage()
        {
                
        }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected IWebDriver _driver;
        private IWebDriver driver;

        public void CloseBrowser()
        {
            this._driver.Close();
        }
    }
}