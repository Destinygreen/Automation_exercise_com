using BoDi;

namespace Automation_exercise_com.Pages
{
    public class LandingPage
    {
        private readonly IWebDriver driver;
        public LandingPage(IWebDriver _driver)
        {
            this.driver = _driver;
        }


        IWebElement contactUs => driver.FindElement(By.LinkText("Contact us"));
        IWebElement signupLkn => driver.FindElement(By.LinkText("Signup / Login"));


        public ContactUsPage ClickContactUs()
        {
            contactUs.Click();
            return new ContactUsPage(driver);
        }

        public void ClickSigUpLkn() => signupLkn.Click();


    }
}
