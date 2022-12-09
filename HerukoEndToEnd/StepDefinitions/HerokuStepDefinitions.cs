using System;
using TechTalk.SpecFlow;
using HerokuAppWebImplementation;
using HerukoAppWebImplementations;
using FluentAssertions;

namespace HerukoEndToEnd.StepDefinitions
{
    [Binding]
    public class HerokuStepDefinitions
    {
        HomePage1 _page;
        private string _title;

        [Given(@"The Heroku App is available")]
        public void GivenTheHerokuAppIsAvailable()
        {
            _page = new HomePage1();
        }

        [When(@"User Access Home Page")]
        public void WhenUserAccessHomePage()
        {
            _title = _page.verifyHeading();
        }

        [Then(@"Heading should be the Internet")]
        public void ThenHeadingShouldBeTheInternet()
        {
            _title.Should().Be("The internet");
        }
    }
}
