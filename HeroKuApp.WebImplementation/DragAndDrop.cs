using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace HeroKuApp.WebImplementation
{
    public class DragAndDrop
    {
        private IWebDriver remotedriver;
        private IWebElement draggable { get { return remotedriver.FindElement(By.Id("column-b")); } }
        private IWebElement droppable { get { return remotedriver.FindElement(By.Id("column-a")); } }
        public DragAndDrop(IWebDriver remotedriver)
        {
            this.remotedriver = remotedriver;
        }
        public string DragAndDropAction()
        {
            Actions builder = new Actions(remotedriver);
            builder.DragAndDrop(draggable, droppable).Perform();
            string actual = remotedriver.FindElement(By.XPath("//header[text()='B']")).Text;
            return actual;
        }
    }
}
