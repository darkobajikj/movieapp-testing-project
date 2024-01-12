using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace AppiumProjectApp.Drivers
{
    public class MobileAppDriver
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set; }


        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            // Set the desired capabilities for Appium
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11");
            

            
            // Initialize AppiumDriver with AndroidDriver
            return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), driverOptions);


        }
    }
}