using HeroKuApp.Operations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKuApp.WebImplementation
{
    public class Checkboxes : ICheckboxes
    {
        private IWebDriver remotedriver;
        private By checkbox1 = By.XPath("//input[1]");

        public Checkboxes(IWebDriver remotedriver)
        {
            this.remotedriver = remotedriver;
        }

        public void VerifyCheckBox() 
        {

        }
    }
}
