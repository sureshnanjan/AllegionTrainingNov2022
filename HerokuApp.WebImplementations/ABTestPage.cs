﻿using OpenQA.Selenium.DevTools.V106.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heroku.Operations;

namespace HerokuApp.WebImplementations
{
    public class ABTestPage : IABTesting
    {
        private Byte heading;
        public ABTestPage()
        {

        }

        public string paragraph => throw new NotImplementedException();

        public void verifyHeading()
        {
            throw new NotImplementedException();
        }

        public void verifyParagraph()
        {
            throw new NotImplementedException();
        }
    }
}
