using SpecFlowDemo.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace SpecFlowDemo.Pages
{
    public class BasePage
    {
        protected readonly AppiumDriver<IWebElement> Driver;
        protected readonly string PlatformName;

        public BasePage(DriverProvider driverProvider, ConfigurationProvider configurationProvider)
        {
            Driver = driverProvider.GetDriver();
            PlatformName = configurationProvider.GetSettings().PlatformName;
        }
    }
}