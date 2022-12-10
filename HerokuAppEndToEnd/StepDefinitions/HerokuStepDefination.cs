using System;
using TechTalk.SpecFlow;
using HerokuApp.WebImplementations;
using FluentAssertions;

namespace HerokuAppEndToEnd.StepDefinitions
{
    [Binding]
    public class HerokuStepDefination
    {
        HomePage1 _page;
        private object _title;

        [Given(@"The Heroku App is available")]
        public void GivenTheHerokuAppIsAvailable()
        {
            _page= new HomePage1();
        }

        [When(@"User Access Home Page")]
        public void WhenUserAccessHomePage()
        {
            _title = _page.verifyHeading();
        }

        [Then(@"Heading should be The Internet")]
        public void ThenHeadingShouldBeTheInternet()
        {
            _title.Should().Be("The Internet");
            _page.CloseBrowser();
        }
    }
}
