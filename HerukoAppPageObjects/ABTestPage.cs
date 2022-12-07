using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using Heruko.Operations;
using System.ComponentModel.Design;

namespace HerukoAppWebImplementations
{
    public class ABTestPage : IABTesting
    {
        public ABTestPage()
        {

        }
        public string paragraph => throw new NotImplementedException();

        public void verifyHeading()
        {
            
        }

        public void verifyParagraph()
        {
            throw new NotImplementedException();
        }
    }
}
