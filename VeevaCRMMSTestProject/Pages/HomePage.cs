using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using VeevaCRMAutomationPOM.Base;
using VeevaCRMAutomationPOM.Helpers;

namespace VeevaCRMMSTestProject.Pages
{
    public class HomePage : VeevaCRMAutomationPOM.Base.HookInitialize
    //public class HomePage : BasePage
    {

        IWebElement RefreshBtn => _driver.FindElement(By.XPath("//*[@id=\"db_ref_btn\"]"));

        IWebElement userTitle => _driver.FindElement(By.XPath("//h1[contains(text(),'Deepak Mahapatra at Veeva TechPartner 11')]"));

        IWebElement tooltip_of_Graph1 => _driver.FindElement(By.XPath("//img[@id='01a3B0000006EeFImg']"));

        IWebElement tooltip_of_Graph2 => _driver.FindElement(By.XPath("//*[@id=\"01a3B0000006EeGImg\"]"));

        IWebElement tooltip_of_Graph3 => _driver.FindElement(By.XPath("//img[@id='01a3B0000006EeHImg']"));

        IWebElement newEvent => _driver.FindElement(By.Name("newEvent"));

        IWebElement calandertxt => _driver.FindElement(By.XPath("//*[@id=\"head_1_ep\"]/h3"));

        IWebElement subField => _driver.FindElement(By.XPath("//*[@id=\"evt5\"]"));

        IWebElement locField => _driver.FindElement(By.XPath("//*[@id=\"evt12\"]"));

        IWebElement startDate => _driver.FindElement(By.Name("StartDateTime"));

        IWebElement startTime => _driver.FindElement(By.Name("StartDateTime_time"));

        IWebElement endDate => _driver.FindElement(By.Name("EndDateTime"));

        IWebElement endTime => _driver.FindElement(By.Name("EndDateTime_time"));

        IWebElement saveBtn => _driver.FindElement(By.Name("save"));

        IWebElement verifyEvent => _driver.FindElement(By.XPath("//*[@id=\"homeCalendarSection\"]/div/div[2]/table/tbody/tr/td[1]/div/ul/li[2]/span/a"));

        IWebElement verifyCreatedEvnt => _driver.FindElement(By.XPath("//*[@id=\"bodyCell\"]/div[1]/div[1]/div[1]/h2"));

        IWebElement verifySubjectOfEvent => _driver.FindElement(By.XPath("//h2[@class='pageDescription']"));

        public string VerifyHomePageUrl()
        {
            string homePageUrl = DriverContext.Driver.Url;
            Assert.IsTrue(homePageUrl.Contains("home.jsp"));
            if (homePageUrl.Contains("home.jsp"))
            {
                LogHelpers.Write("Page is in Home Page");
            }
            else
            {
                LogHelpers.Write("Page is not in Home Page");
            }

            return homePageUrl;

        }
        [TestMethod]
        public void verifyUserTitle()
        {
            //driver.switchTo().frame("sessionserver");
            string title_of_user = userTitle.Text;
            Assert.IsTrue(title_of_user.Equals("Deepak Mahapatra at Veeva TechPartner 11"));
        }

    }
}
