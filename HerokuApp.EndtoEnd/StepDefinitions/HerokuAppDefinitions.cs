using System;
using TechTalk.SpecFlow;
using HerokuAppWebImplementation;
using FluentAssertions;

namespace HerokuApp.EndtoEnd.StepDefinitions
{
    [Binding]
    public class HerokuAppDefinitions
    {
        HomePage1 _page;
        string _title;
        [Given(@"The Heroku App is available")]
       
        public void GivenTheHerokuAppIsAvailable()
        {
            _page = new HomePage1();
        }

        [When(@"User Access the HomePage")]
        public void WhenUserAccessTheHomePage()
        {

            _title = _page.verifyHeadder();
        }

        [Then(@"Heading should be The Internet")]
        public void ThenHeadingShouldBeTheInternet()
        {
            _title.Should().Be("Welcome to the-internet");
            _page.CloseBrowser();
        }
    }
}
