using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using VeevaCRMAutomationPOM.Base;
using VeevaCRMAutomationPOM.Config;
using VeevaCRMAutomationPOM.Extensions;
using VeevaCRMAutomationPOM.Helpers;

namespace VeevaCRM.Pages
{
    public class HomePage : VeevaCRMAutomationPOM.Base.HookInitialize
    //public class HomePage : BasePage
    {
        //Actions builder = new Actions(DriverContext.Driver);
        LoginPage login = new LoginPage();
        

        IWebElement RefreshBtn => DriverContext.Driver.FindElement(By.XPath("//*[@id=\"db_ref_btn\"]"));

        IWebElement UserTitle => DriverContext.Driver.FindElement(By.XPath("//h1[contains(text(),'Deepak Mahapatra at Veeva TechPartner 11')]"));

        IWebElement Tooltip_of_Graph1 => DriverContext.Driver.FindElement(By.XPath("//img[@id='01a3B0000006EeFImg']"));

        IWebElement Tooltip_of_Graph2 => DriverContext.Driver.FindElement(By.XPath("//*[@id=\"01a3B0000006EeGImg\"]"));

        IWebElement Tooltip_of_Graph3 => DriverContext.Driver.FindElement(By.XPath("//img[@id='01a3B0000006EeHImg']"));

        IWebElement NewEvent => DriverContext.Driver.FindElement(By.Name("newEvent"));

        IWebElement Calandertxt => DriverContext.Driver.FindElement(By.XPath("//*[@id=\"head_1_ep\"]/h3"));

        IWebElement SubField => DriverContext.Driver.FindElement(By.XPath("//*[@id=\"evt5\"]"));

        IWebElement LocField => DriverContext.Driver.FindElement(By.XPath("//*[@id=\"evt12\"]"));

        IWebElement StartDate => DriverContext.Driver.FindElement(By.Name("StartDateTime"));

        IWebElement StartTime => DriverContext.Driver.FindElement(By.Name("StartDateTime_time"));

        IWebElement EndDate => DriverContext.Driver.FindElement(By.Name("EndDateTime"));

        IWebElement EndTime => DriverContext.Driver.FindElement(By.Name("EndDateTime_time"));

        IWebElement SaveBtn => DriverContext.Driver.FindElement(By.Name("save"));

        IWebElement VerifyEvent => DriverContext.Driver.FindElement(By.XPath("//*[@id=\"homeCalendarSection\"]/div/div[2]/table/tbody/tr/td[1]/div/ul/li[2]/span/a"));

        IWebElement VerifyCreatedEvnt => DriverContext.Driver.FindElement(By.XPath("//*[@id=\"bodyCell\"]/div[1]/div[1]/div[1]/h2"));

        IWebElement VerifySubjectOfEvent => DriverContext.Driver.FindElement(By.XPath("//h2[@class='pageDescription']"));

        public string VerifyHomePageUrl()
        {
            string homePageUrl = DriverContext.Driver.Url;
            DriverContext.Driver.WaitForPageLoaded();
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
        public void VerifyUserTitle()
        {
            //driver.switchTo().frame("sessionserver");
            DriverContext.Driver.WaitForPageLoaded();
            string title_of_user = UserTitle.Text;
            DriverContext.Driver.WaitForPageLoaded();
            Assert.IsTrue(title_of_user.Equals("Deepak Mahapatra at Veeva TechPartner 11"));
            //StringAssert.Contains(title_of_user, "Deepak Mahapatra at Veeva TechPartner 11");
            Assert.AreEqual(title_of_user, "Deepak Mahapatra at Veeva TechPartner 11");
            LogHelpers.Write("The User Title is matching as per the requirement");
        }

        public void VerifyGraphOne()
        {
            //builder=new Actions(driver);

            WebElementExtensions.Hover(Tooltip_of_Graph1);
            //builder.MoveToElement(tooltip_of_Graph1).Perform();

            string tooltip_msg_of_graph1 = Tooltip_of_Graph1.GetAttribute("alt");
            LogHelpers.Write("Tooltip message for Graph 1 is " + tooltip_msg_of_graph1);
            string msg1 = "Call Activities by Users - Click to go to full report.";
            Assert.AreEqual(tooltip_msg_of_graph1, msg1);
        }

        public void VerifyGraphTwo()
        {
            //builder=new Actions(driver);
            WebElementExtensions.Hover(Tooltip_of_Graph2);
            //builder.MoveToElement(tooltip_of_Graph2).Perform();
            string tooltip_msg_of_graph2 = Tooltip_of_Graph2.GetAttribute("alt");
            LogHelpers.Write("Tooltip message for Graph 2 is " + tooltip_msg_of_graph2);
            string msg2 = "Call Activities by Account - Click to go to full report.";
            Assert.AreEqual(tooltip_msg_of_graph2, msg2);
        }
        public void VerifyGraphThree()
        {
            WebElementExtensions.Hover(Tooltip_of_Graph3);
           // builder.MoveToElement(tooltip_of_Graph3).Perform();
            string tooltip_msg_of_graph3 = Tooltip_of_Graph3.GetAttribute("alt");
            LogHelpers.Write("Tooltip message for Graph 3 is " + tooltip_msg_of_graph3);
            string msg3 = "Call Activities by Product - Click to go to full report.";
            Assert.AreEqual(tooltip_msg_of_graph3, msg3);
        }

        public HomePage VerifyRefreshButton()
        {
            RefreshBtn.Click();
            LogHelpers.Write("Refresh Button Clicked");
            return new HomePage();
        }

        public void VerifynewEvent()
        {
            NewEvent.Click();
            LogHelpers.Write("New Event Button is clicked");
        }

        public void Verifycalendar()
        {
            string txtClndr = Calandertxt.Text;
            Assert.AreEqual(txtClndr, "Calendar Details");
            LogHelpers.Write("Calandar is found on the page");
        }

        public void VerifySubjectField()
        {
            SubField.SendKeys(Settings.SubjectField);
            LogHelpers.Write("The subject Filed in Calander is entered as" + Settings.SubjectField);
        }
        public void VerifyLocationField()
        {
            LocField.SendKeys("Bangalore");
            LogHelpers.Write("The Location in Calander is entered as Bangalore ");
        }
        public void VerifyStartDate()
        {
            StartDate.Clear();
            Base.Date();
            StartDate.SendKeys(Base.formattedStartDate);
            LogHelpers.Write("The start date is entered as " + formattedStartDate);
        }
        public void VerifyStartTime()
        {
            StartTime.Clear();
            StartTime.SendKeys(Settings.StartTime);
            LogHelpers.Write("The Time is entered in Calander as " +Settings.StartTime);
        }
        public void VerifyEndDate()
        {
            EndDate.Clear();
            EndDate.SendKeys(Base.formattedEndDate);
            LogHelpers.Write("The End Date is entered as " +formattedEndDate);
        }
        public void VerifyEndTime()
        {
            EndTime.Clear();
            EndTime.SendKeys(Settings.EndTime);
            LogHelpers.Write("The End Time is entered as "+ Settings.EndTime);
        }
        public void VerifySaveBtn()
        {
            SaveBtn.Click();
            VerifyEvent.Click();
            String subOfCalanderEvent = VerifySubjectOfEvent.Text;
            Assert.AreEqual(subOfCalanderEvent, Settings.SubjectField);
            LogHelpers.Write("It clicked on Save BUtton");
        }

    }
}
