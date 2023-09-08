using BoDi;
using Automation_exercise_com.Hooks;

namespace Automation_exercise_com.StepDefinitions
{
    [Binding]
    public class Register_UserStepDefinitions
    {

         //BaseHooks baseHooks;
        //CustomerPage customerpage;
        //ShippingPage shippingPage;
        //PaymentPage paymentPage;
        //ConfirmationPage confirmationPage;
        IWebDriver driver;
        ReadJsonData jsonData;
        string userName, email;
        public Register_UserStepDefinitions(IObjectContainer container)
        {
            //driver = container.Resolve<IWebDriver>();
            //jsonData = container.Resolve<ReadJsonData>();
            //baseHooks = container.Resolve<BaseHooks>();
            //homepage = container.Resolve<HomePage>();
            //customerpage = container.Resolve<CustomerPage>();
            //shippingPage = container.Resolve<ShippingPage>();
            //paymentPage = container.Resolve<PaymentPage>();
            //confirmationPage = container.Resolve<ConfirmationPage>();
        }


        [Given(@"Launch browser")]
        public void GivenLaunchBrowser()
        {
           
        }

        [When(@"Navigate to url '(.*)'")]
        public void WhenNavigateToUrl(string p0)
        {
            userName = "QaUser".AddRandomDigits();
            email = "abc".AddRandomDigits3();
        }

        [Then(@"Verify that home page is visible successfully")]
        public void ThenVerifyThatHomePageIsVisibleSuccessfully()
        {
            
        }

        [Then(@"Click on '(.*)' button")]
        public void ThenClickOnButton(string p0)
        {
            
        }

        [Then(@"Verify '(.*)' is visible")]
        public void ThenVerifyIsVisible(string p0)
        {
           
        }

        [When(@"Enter name and email address")]
        public void WhenEnterNameAndEmailAddress()
        {
            
        }

        [When(@"Click '(.*)' button")]
        public void WhenClickButton(string signup)
        {
            
        }

        [Then(@"Verify that '(.*)' is visible")]
        public void ThenVerifyThatIsVisible(string p0)
        {
           
        }

        [Then(@"Fill details: Title, Name, Email, Password, Date of birth")]
        public void ThenFillDetailsTitleNameEmailPasswordDateOfBirth()
        {
            
        }

        [Then(@"Select checkbox '(.*)'")]
        public void ThenSelectCheckbox(string p0)
        {
          
        }

        [Then(@"Fill details: First name, Last name, Company, Address, Address(.*), Country, State, City, Zipcode, Mobile Number")]
        public void ThenFillDetailsFirstNameLastNameCompanyAddressAddressCountryStateCityZipcodeMobileNumber(int p0)
        {
            
        }

        [When(@"Click '(.*)'")]
        public void WhenClick(string p0)
        {
            
        }

        [Then(@"Click '(.*)' button")]
        public void ThenClickButton(string p0)
        {
            
        }

        [Then(@"Verify that '(.*)' is visible and click '(.*)' button")]
        public void ThenVerifyThatIsVisibleAndClickButton(string accoutDELETED, string @continue)
        {
           
        }
    }
}
