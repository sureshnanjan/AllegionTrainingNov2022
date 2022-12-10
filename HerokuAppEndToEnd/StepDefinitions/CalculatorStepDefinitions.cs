using System;
using TechTalk.SpecFlow;

namespace HerokuAppEndToEnd.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private int number1;
        private int number2;
        private int actualResult;
        [Given(@"there are (.*) cucumbers")]
        public void GivenThereAreCucumbers(int p0)
        {
            number1=p0;
        }

        [When(@"I eat (.*) cucumbers")]
        public void WhenIEatCucumbers(int p0)
        {
            number2= p0;
            actualResult=number1-number2;
        }

        [Then(@"I should have (.*) cucumbers")]
        public void ThenIShouldHaveCucumbers(int p0)
        {
            actualResult.Should().Be("The Internet");
        }
    }
}
