using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using VeevaCRMAutomationPOM.Base;
using VeevaCRMAutomationPOM.Extensions;

namespace VeevaCRM.Pages
{
    public class LoginPage : VeevaCRMAutomationPOM.Base.HookInitialize
    {
        //initialoze page
        //_driver = DriverContext.Driver;
        //objects for login Page veeva
       
         IWebElement LnkUserName => DriverContext.Driver.FindElement(By.XPath("//input[@id='username']"));
        IWebElement Lnkpassword => DriverContext.Driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement LnklogInBtn => DriverContext.Driver.FindElement(By.XPath("//input[@id='Login']"));

        IWebElement LogOut_drop_down => DriverContext.Driver.FindElement(By.XPath("//span[@id='userNavLabel']"));

        IWebElement Logout_btn => DriverContext.Driver.FindElement(By.XPath("//div[@class='mbrMenuItems']/a[2]"));



        //[TestMethod]
        public void loginVeeva(string username, string password)
        {
          

            LnkUserName.SendKeys(username);
            DriverContext.Driver.WaitForPageLoaded();
            Lnkpassword.SendKeys(password);
            DriverContext.Driver.WaitForPageLoaded();
            LnklogInBtn.Click();

        }
        // [TestMethod]
        internal void CheckIfLoginExists()
        {
            LnkUserName.AssertElementPresent();

        }

        public void VerifyViewloginDropdown()
        {
            LogOut_drop_down.Click();
            Logout_btn.Click();

        }


        // [TestMethod]
        public void closeCurrentBrowser()
        {
            terminateBrowser();
        }
    }
}
