namespace Automation_exercise_com.Pages
{
    public class LoginPage
    {

        private readonly IWebDriver driver;
        public LoginPage(IWebDriver _driver)
        {
          this.driver = _driver;
        }



        IWebElement signUpName => driver.FindElement(By.XPath("//input[@name='name']"));
        IWebElement signUpEmail => driver.FindElement(By.XPath("//input[@data-qa='signup-email']"));
        IWebElement submitButton => driver.FindElement(By.CssSelector("button[data-qa='signup-button']"));

        public void LoginInformation(string _name, string _email)
        {
            signUpName.SendKeys(_name);
            signUpEmail.SendKeys(_email);
            submitButton.Click();
        }
    }
}
