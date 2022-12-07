using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Her;

namespace HerokuAppTests
{
    [TestClass]
    public class HerokuAppTests
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void AddRemoveElementsFunctionsCorrectlyforOneItem()
        {
            HomePage page = new HomePage();
            page.NavigateToPage("AB Testing").validateTextMessage();
        }
    }
}
