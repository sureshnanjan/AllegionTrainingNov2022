using OpenQA.Selenium;

namespace HerokuAppWebImplementation
{
    public class BasePage
    {
        public BasePage()
        {
                
        }

        protected IWebDriver _driver;
        public void CloseBrowser()
        {
            this._driver.Close();
        }
    }
}