using TechTalk.SpecFlow;
using VeevaCRMAutomationPOM.Base;
using VeevaCRMAutomationPOM.Helpers;
using VeevaCRM.Pages;

namespace VeevaCRM.StepDefinations
{
    [Binding]
    public class LoginStepDefination : BaseStep
    {
        LoginPage login = new LoginPage();
        HomePage hp = new HomePage();
        //HookInitialize hook = new HookInitialize();

        [Given(@"user opens browser")]
        public void GivenUserOpensBrowser()
        {
            //CurrentPage.As<BaseStep>().NavigateSite();

            HookInitialize hook = new HookInitialize();
            LogHelpers.Write("The Veeva site is Navigated");
        }

        [Then(@"user entered into the application by using valid login credentials")]
        public void ThenUserEnteredIntoTheApplicationByUsingValidLoginCredentials()
        {
            //CurrentPage.As<LoginPage>().loginVeeva("dmahapatra@businessonetech.com.busone02", "Password@2020");
            login.loginVeeva("dmahapatra@businessonetech.com.busone02", "Password@2020");
            LogHelpers.Write("The user entered a valid Username and Password");

        }

        [Then(@"user is on home page")]
        public void ThenUserIsOnHomePage()
        {
            // CurrentPage.As<HomePage>().VerifyHomePageUrl();
            hp.VerifyHomePageUrl();
            LogHelpers.Write("The user is in Home Page");
        }

        [When(@"title of login page is Deepak Mahapatra at Veeva TechPartner 11")]
        public void WhenTitleOfLoginPageIsDeepakMahapatraAtVeevaTechPartner()
        {
            //CurrentPage.As<HomePage>().verifyUserTitle();
            hp.VerifyUserTitle();
            LogHelpers.Write("The Title of user is matching!!!!!!!!!!!!!!!");

        }

        [Then(@"close the browser")]
        public void ThenCloseTheBrowser()
        {
            //CurrentPage.As<LoginPage>().closeCurrentBrowser();
            login.closeCurrentBrowser();
        }

    }
 
}
