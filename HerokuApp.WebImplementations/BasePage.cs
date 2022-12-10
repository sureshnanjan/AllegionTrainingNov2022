using OpenQA.Selenium;





namespace HerokuAppWebImplementation
{
    public class BasePage
    {





        protected IWebDriver _driver;
        public void CloseBrowser()
        {
            this._driver.Close();
        }
    }
}