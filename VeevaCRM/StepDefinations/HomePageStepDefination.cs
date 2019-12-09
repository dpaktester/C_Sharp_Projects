using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using VeevaCRM.Pages;
using VeevaCRMAutomationPOM.Base;
using VeevaCRMAutomationPOM.Helpers;

namespace VeevaCRM.StepDefinations
{
    [Binding]
    public  class HomePageStepDefination
    {
        HomePage home = new HomePage();
        

        [When(@"user hovers on graph One verify the message of graph one")]
        public void WhenUserHoversOnGraphOneVerifyTheMessageOfGraphOne()
        {
            home.VerifyGraphOne();
        }

        [When(@"user hovers on graph two verify message of graph two")]
        public void WhenUserHoversOnGraphTwoVerifyMessageOfGraphTwo()
        {
            home.VerifyGraphTwo();
        }

        [When(@"user hovers on graph three verify message of graph three")]
        public void WhenUserHoversOnGraphThreeVerifyMessageOfGraphThree()
        {
            home.VerifyGraphThree();
        }

        [When(@"user clicks on Refresh button")]
        public void WhenUserClicksOnRefreshButton()
        {
            home.VerifyRefreshButton();
        }

        [Then(@"the three graphs refreshed")]
        public void ThenTheThreeGraphsRefreshed()
        {
             home.VerifyGraphOne();
             home.VerifyGraphTwo();
             home.VerifyGraphThree();
             LogHelpers.Write("All the three graphs are refreshed after clicking on Refresh Button");
        }

        [When(@"user clicks on New Event button")]
        public void WhenUserClicksOnNewEventButton()
        {
            home.VerifynewEvent();
        }

        [Then(@"Calendar opens")]
        public void ThenCalendarOpens()
        {
            home.Verifycalendar();
            LogHelpers.Write("It verifies the Calander");
        }

        [Then(@"Enter the subject as Testing Calander Event")]
        public void ThenEnterTheSubjectAsTestingCalanderEvent()
        {
            home.VerifySubjectField();
        }

        [Then(@"Enter the location as Bangalore")]
        public void ThenEnterTheLocationAsBangalore()
        {
            home.VerifyLocationField();
        }

        [Then(@"Enter the Start Date")]
        public void ThenEnterTheStartDate()
        {
            home.VerifyStartDate();
        }

        [Then(@"Enter the Start Time")]
        public void ThenEnterTheStartTime()
        {
            home.VerifyStartTime();
        }

        [Then(@"Enter the End Date")]
        public void ThenEnterTheEndDate()
        {
            home.VerifyEndDate();
        }

        [Then(@"Enter the End Time")]
        public void ThenEnterTheEndTime()
        {
            home.VerifyEndTime();
        }

        [Then(@"Click on Save button")]
        public void ThenClickOnSaveButton()
        {
            home.VerifySaveBtn();
        }

        [Then(@"close the home browser")]
        public void ThenCloseTheHomeBrowser()
        {
            DriverContext.Driver.Close();
            LogHelpers.Write("It closes the Browser from Home Page");
        }


    }
}
