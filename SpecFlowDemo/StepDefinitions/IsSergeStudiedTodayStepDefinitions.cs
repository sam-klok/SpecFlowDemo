using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.StepDefinitions
{
    [Binding]
    public class IsSergeStudiedTodayStepDefinitions
    {
        [Given(@"Serge have computer")]
        public void GivenSergeHaveComputer()
        {
            
        }

        [When(@"Task arrive")]
        public void WhenTaskArrive()
        {
            throw new PendingStepException();
        }

        [Then(@"Read study task")]
        public void ThenReadStudyTask()
        {
            throw new PendingStepException();
        }

        [Then(@"at least for (.*) hour")]
        public void ThenAtLeastForHour(int p0)
        {
            throw new PendingStepException();
        }
    }
}
