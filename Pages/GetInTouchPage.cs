namespace Automation_exercise_com.Pages
{
    public class GetInTouchPage
    {

        private readonly IWebDriver driver;
        public GetInTouchPage(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        IWebElement successMessage => driver.FindElement(By.CssSelector(".status"));

        public bool IsSuccessMsgVisible() => successMessage.Displayed;
        public string IsSuccessMsgtextVisible() => successMessage.Text;


    }
}
