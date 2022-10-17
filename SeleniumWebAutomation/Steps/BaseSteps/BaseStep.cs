using SeleniumWebAutomation.WebDriver;
using TechTalk.SpecFlow;

namespace SeleniumWebAutomation.Steps.BaseSteps
{
    public class BaseStep
    {
        [Before]
        public void DriverStart()
        {
            Driver.DriverStart();
        }

        [After]
        public void DriverQuit()
        {
            Driver.DriverQuit();
        }
    }
}
