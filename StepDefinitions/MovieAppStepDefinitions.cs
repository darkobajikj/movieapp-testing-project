using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using Assert = NUnit.Framework.Assert;

namespace AppiumProject.StepDefinitions
{

    [Binding]

    public sealed class MovieAppStepDefinitions
    {
       
        private readonly ScenarioContext _scenarioContext;

        public MovieAppStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        

        [Given(@"I type in the search input")]
        public void GivenITypeInTheSearchInput()
        {
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementByXPath("//android.widget.TextView[@content-desc=\"Search\"]").Click();
            Thread.Sleep(2000);
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("mk.codeacademy.movieapp:id/search_edittext").SendKeys("Spider-Man");
            Thread.Sleep(2000);

        }

        [When(@"the result is shown")]
        public void WhenTheResultIsShown()
        {
            Thread.Sleep(2000);
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView[2]/android.widget.FrameLayout[3]/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.TextView[1]").Click();
        }
        [Then(@"I verify the Movie")]
        public void ThenIVerifyMovie()
        {
            Thread.Sleep(2000);
            Assert.AreEqual("Spider-Man", _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("mk.codeacademy.movieapp:id/detail_title").Text);
            Thread.Sleep(2000);
        }


    }
}