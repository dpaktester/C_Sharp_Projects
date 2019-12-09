using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using VeevaCRMAutomationPOM.Base;
using VeevaCRMAutomationPOM.Extensions;

namespace VeevaCRMMSTestProject.Pages
{
    public class LoginPage : VeevaCRMAutomationPOM.Base.HookInitialize
    {
        //initialoze page

        //objects for login Page veeva
        IWebElement LnkUserName => _driver.FindElement(By.XPath("//input[@id='username']"));
        IWebElement Lnkpassword => _driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement LnklogInBtn => _driver.FindElement(By.XPath("//input[@id='Login']"));


        //[TestMethod]
        public void loginVeeva(string username, string password)
        {
            LnkUserName.SendKeys(username);
            Lnkpassword.SendKeys(password);
            DriverContext.Driver.WaitForPageLoaded();
            LnklogInBtn.Click();

        }
        // [TestMethod]
        internal void CheckIfLoginExists()
        {
            LnkUserName.AssertElementPresent();

        }
        // [TestMethod]
        public void closeBrowser()
        {
            terminateBrowser();
        }
    }
}
