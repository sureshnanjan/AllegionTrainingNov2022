using FluentAssertions;
using HeroKuApp.WebImplementation;
using System;
using TechTalk.SpecFlow;

namespace HeroKuApp.EndToEndImplementation.StepDefinitions
{
    [Binding]
    public class VerifyHeroKuAppHomePageHeading
    {
        private HomePage _page;
        private string actual;

        [Given(@"Webpage is launched")]
        public void GivenWebpageIsLaunched()
        {
            _page = new HomePage("chrome");
        }

        [When(@"Homepage heading is selected")]
        public void WhenHomepageHeadingIsSelected()
        {
            actual = _page.VerifyHomePageHeading();
        }

        [Then(@"Verifing homepage heading")]
        public void WhenVerifingHomepageHeading()
        {
            actual.Should().Be("Welcome to the-internet");
        }

        [Then(@"Close the browser")]
        public void ThenCloseTheBrowser()
        {
            _page.BrowserClose();
        }
    }
}
