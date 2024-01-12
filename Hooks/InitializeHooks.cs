using AppiumProjectApp.Drivers;

namespace AppiumProjectApp.Hooks
{

    [Binding]
    class InitializeHook
    {
        private readonly ScenarioContext _scenarioContext;

        public InitializeHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Initialize() 
        {
            MobileAppDriver appiumDriver = new MobileAppDriver();
            
            _scenarioContext.Set(appiumDriver.InitializeAppium());
        }
    }
}
