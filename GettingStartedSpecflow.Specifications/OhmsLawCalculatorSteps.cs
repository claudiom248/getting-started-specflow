using System;
using TechTalk.SpecFlow;
using Xunit;

namespace GettingStartedSpecflow.Specifications
{
    [Binding]
    public class OhmsLawCalculatorSteps
    {
        private ScenarioContext _scenarioContext;
        private OhmsLawCalculator _ohmsLawCalculator = new OhmsLawCalculator();
        private double _result = 0;

        public OhmsLawCalculatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have entered (.*) into the calculator as value for current")]
        public void GivenIHaveEnteredIntoTheCalculatorAsValueForCurrent(int p0)
        {
            _ohmsLawCalculator.Current = p0;
        }
        
        [Given(@"I have entered (.*) into the calculator as value for resistance")]
        public void GivenIHaveEnteredIntoTheCalculatorAsValueForResistance(int p0)
        {
            _ohmsLawCalculator.Resistance = p0;
        }

        [Given(@"I have entered (.*) into the calculator as value for voltage")]
        public void GivenIHaveEnteredIntoTheCalculatorAsValueForVoltage(int p0)
        {
            _ohmsLawCalculator.Voltage = p0;
        }

        [When(@"I press calculate")]
        public void WhenIPressCalculate()
        {
            _result = _scenarioContext.ScenarioInfo.Title switch
            {
                "Calculate voltage" => _ohmsLawCalculator.CalculateVoltage(),
                "Calculate current" => _ohmsLawCalculator.CalculateCurrent(),
                "Calculate resistance" => _ohmsLawCalculator.CalculateResistance(),
                _ => throw new Exception("Invalid scenario title")
            };
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.Equal(p0, _result);
        }
    }
}
