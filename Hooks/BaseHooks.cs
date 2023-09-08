namespace Automation_exercise_com.Hooks
{
    [Binding]
    public sealed class BaseHooks : DriverHelper
    {
        public BaseHooks(IObjectContainer container)
        {
            _container = container;
        }

        private IWebDriver SetupWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.Latest);
            var options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArguments("start-maximized", "incognito");
            options.AddArgument("--disable-notifications");
            options.AddExcludedArgument("enable-automation");
            return driver = new ChromeDriver(options);
        }

        [BeforeScenario]
        public void SetUp()
        {
            SetupWebDriver();
            _container.RegisterInstanceAs(driver);
        }


        [AfterScenario]
        public void Teardown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null!;
            }
        }
    }
}