using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VeevaCRMAutomationPOM.Base;
using VeevaCRMAutomationPOM.Config;
using VeevaCRMAutomationPOM.Extensions;
using VeevaCRMAutomationPOM.Helpers;


namespace VeevaCRM.Pages
{
    class AccountsPage
    {
        LoginPage login = new LoginPage();

        static SelectElement viewDropdownSelect;

        //static SelectElement ddl1 = new SelectElement();
        static string acntsHeaderTxt_commercial;
        static string acntsHeaderTxt_Employer;
        static string selected_Employer_Plan;
        static string selected_Pbm_Plan;
        static string selected_Specialty_plan;
        static string selected_State_Medicaid_plan;
        static string selected_Tricare_plan;
        static string selected_Va_Plan;
        static string selected_Medicare_Plan;
        static string selected_My_Accounts_plan;
        static string selected_Parents_Accounts_plan;
        static int xpathnumer = 0;
        static IList<string> options;



        IWebElement calendar_evnt => DriverContext.Driver.FindElement(By.XPath("//*[@class='pbBody']/table/tbody/tr/td/div/ul/li[2]"));

        IList<IWebElement> Calendar_evnt1 => DriverContext.Driver.FindElements(By.XPath("//h1[contains(text(),'Deepak Mahapatra at Veeva TechPartner 11')]"));

        static IWebElement AccountsBtn => DriverContext.Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));

        static IWebElement MyAccountsText => DriverContext.Driver.FindElement(By.XPath("//body[contains(@class,'sfdcBody brandQuaternaryBgr')]"));

        IWebElement AccntDropDown => DriverContext.Driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/div[2]/div[3]/div/div[1]/form/div/span/span[1]"));

        static IWebElement ViewDropdown => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'bFilterView']/span/span/select[1][@id = 'vwid']"));

        static IWebElement ViewDropdown1 => DriverContext.Driver.FindElement(By.Name("vwid"));
        static IWebElement CommercialPlan => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(),'Aetna Health Inc - Alabama')]"));

        IWebElement AcountVerificationText => DriverContext.Driver.FindElement(By.XPath("//*[@id='contentWrapper']/div[2]/table/tbody/tr/td[2]/div/div/div/h2"));

        IWebElement Account_Detail_txt => DriverContext.Driver.FindElement(By.XPath("//h2[contains(text(),'Account Detail')]"));

        IWebElement Formulary_txt => DriverContext.Driver.FindElement(By.XPath("//h3[contains(text(),'Formulary')]"));

        IWebElement Dashboard_txt => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Dashboard')]"));

        IWebElement Coverage_Policy_Details_txt => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Coverage Policy')]"));

        IWebElement Pharmacy_Service_txt => DriverContext.Driver.FindElement(By.XPath("//label[contains(text(),'Pharmacy Service')]"));

        IWebElement Plan_Products_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr/td[1]//h3"));

        IWebElement Specialty_Providers_txt => DriverContext.Driver.FindElement(By.XPath("//h3[contains(text(),'Specialty Providers')]"));

        IWebElement Member_Of_txt => DriverContext.Driver.FindElement(By.XPath("//h3[contains(text(),'Member Of')]"));

        IWebElement Members_txt => DriverContext.Driver.FindElement(By.XPath("//h3[contains(text(),'Members')]"));

        IWebElement Addresses_txt => DriverContext.Driver.FindElement(By.XPath("//h3[contains(text(),'Addresses')]"));

        IWebElement Account_Plans_txt => DriverContext.Driver.FindElement(By.XPath("//h3[contains(text(),'Account Plans')]"));

        IWebElement Calls_txt => DriverContext.Driver.FindElement(By.XPath("//h3[contains(text(),'Calls (Account)')]"));

        IWebElement Name_txt => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'detailList']/tbody/tr[1]/td[1][contains(text(),'Name')]"));

        IWebElement Account_Type_txt => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'detailList']/tbody/tr[2]/td[1][contains(text(),'Account Type')]"));

        IWebElement Entity_Level_txt => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'detailList']/tbody/tr[3]/td[1][contains(text(),'Entity Level')]"));

        IWebElement Parent_Account_Txt => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'detailList']/tbody/tr[1]/td[3][contains(text(),'Parent Account')]"));

        IWebElement Website_txt => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'detailList']/tbody/tr[2]/td[3][contains(text(),'Website')]"));

        IWebElement Plan_LivesRx_txt => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'detailList']/tbody/tr[3]/td[3][contains(text(),'Plan Lives Rx')]"));

        IWebElement Name_of_slctd_comme_accnt => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'detailList']/tbody/tr[1]/td[2][contains(text(),'Aetna Health Inc - Alabama')]"));

        IWebElement View_of_Formulary_txt => DriverContext.Driver.FindElement(By.XPath("//body[1]/div/table/tbody/tr[2]/td[1]/a"));

        IWebElement BenifitDesign_of_Formulary_txt => DriverContext.Driver.FindElement(By.XPath("//body[1]/div/table/tbody/tr[2]/td[2][contains(text(),'Benefit Design')]"));

        IWebElement Market_txt => DriverContext.Driver.FindElement(By.XPath("//body[1]/div/table/tbody/tr[3]/td[contains(text(),'Market')]"));

        IWebElement DrugName_txt_of_cvrg_plc => DriverContext.Driver.FindElement(By.XPath("//*[@class='coveragepolicy']/tbody/tr/th[contains(text(),'Drug Name')]"));

        IWebElement Channel_txt_of_cvrg_plc => DriverContext.Driver.FindElement(By.XPath("//*[@class='coveragepolicy']/tbody/tr/th[(text()='Channel')]"));

        IWebElement Subchannel_txt_of_cvrg_plc => DriverContext.Driver.FindElement(By.XPath("//*[@class='coveragepolicy']/tbody/tr/th[(text()='SubChannel')]"));

        IWebElement Score_txt_of_cvrg_plc => DriverContext.Driver.FindElement(By.XPath("//*[@class='coveragepolicy']/tbody/tr/th[(text()='Score')]"));

        IWebElement Indication_txt_of_cvrg_plc => DriverContext.Driver.FindElement(By.XPath("//*[@class='coveragepolicy']/tbody/tr/th[(text()='Indication')]"));

        IWebElement Sub_Indication_txt_of_cvrg_plc => DriverContext.Driver.FindElement(By.XPath("//*[@class='coveragepolicy']/tbody/tr/th[(text()='Sub-Indication')]"));

        IWebElement Service_of_pharmacyServices => DriverContext.Driver.FindElement(By.XPath("//*[@class='pharmacyService']/tbody/tr/th[1]"));

        IWebElement Channel_of_pharmacyServices => DriverContext.Driver.FindElement(By.XPath("//*[@class='pharmacyService']/tbody/tr/th[(text()='Channel')]"));

        IWebElement SubChannel_of_pharmacySevices => DriverContext.Driver.FindElement(By.XPath("//*[@class='pharmacyService']/tbody/tr/th[(text()='SubChannel')]"));

        IWebElement PbmName_of_pharmacySevices => DriverContext.Driver.FindElement(By.XPath("//*[@class='pharmacyService']/tbody/tr/th[(text()='PBM Name')]"));

        IWebElement PbmName_of_pharmacySevices_PBM => DriverContext.Driver.FindElement(By.XPath("//*[@class='pharmacyService']/tbody/tr/th[(text()='Account Name')]"));
   

        IWebElement Prvdr_name_of_pharmacySevices => DriverContext.Driver.FindElement(By.XPath("//*[@class='pharmacyService']/tbody/tr/th[(text()='Provider Name')]"));

        IWebElement Action_txt_of_plan_prods => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));

        IWebElement Product_Nametxt_of_plan_prods => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[(text()='Product Name')]"));

        IWebElement Channel_txt_of_plan_products => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[(text()='Channel')]"));

        IWebElement SubChannel_txt_of_plan_prods => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[(text()='SubChannel')]"));

        IWebElement Product_Type_txt_of_plan_prods => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[(text()='Product Type')]"));

        IWebElement Formulary_Used_txt_of_plan_prods => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[(text()='Formulary Type Used')]"));

        IWebElement Spc_Prvdr_action_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[6]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));

        IWebElement Spc_Prvdr_Specialty_Provider_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[6]//table/tbody/tr[@class = 'headerRow']/th[(text()='Specialty Provider')]"));

        IWebElement Spc_Prvdr_Website_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[6]//table/tbody/tr[@class = 'headerRow']/th[(text()='Website')]"));

        IWebElement Member_Of_Action_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[7]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));

        IWebElement Member_Of_Parent_Account_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[7]//table/tbody/tr[@class = 'headerRow']/th[(text()='Parent Account')]"));

        IWebElement Member_Action_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[8]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));

        IWebElement Member_Action_txt_VA => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[7]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));


        IWebElement Member_child_acnt_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[8]//table/tbody/tr[@class = 'headerRow']/th[(text()='Child Account')]"));

        IWebElement Member_child_acnt_txt_VA => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[7]//table/tbody/tr[@class = 'headerRow']/th[(text()='Child Account')]"));

        IWebElement Member_Title_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[8]//table/tbody/tr[@class = 'headerRow']/th[(text()='Title')]"));

        IWebElement Member_Title_txt_VA => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[7]//table/tbody/tr[@class = 'headerRow']/th[(text()='Title')]"));

        IWebElement Member_Acnt_type_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[8]//table/tbody/tr[@class = 'headerRow']/th[(text()='Account Type')]"));

        IWebElement Member_Acnt_type_txt_VA => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[7]//table/tbody/tr[@class = 'headerRow']/th[(text()='Account Type')]"));


        IWebElement Member_Action_txt_PBM => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[1]"));

        IWebElement Member_child_acnt_txt_PBM => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[2]"));

        IWebElement Member_Title_txt_PBM => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[3]"));

        IWebElement Member_Acnt_type_txt_PBM => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[5]//table/tbody/tr[@class = 'headerRow']/th[4]"));

        IWebElement Address_action_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[9]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));

        IWebElement Address_action_txt_employer => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[6]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));

        IWebElement Address_Address_line_1_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[9]//table/tbody/tr[@class = 'headerRow']/th[(text()='Address line 1')]"));

        IWebElement Address_Address_line_1_txt_employer => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[6]//table/tbody/tr[@class = 'headerRow']/th[(text()='Address line 1')]"));

        IWebElement AccountPlans_Action_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[10]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));

        IWebElement AccountPlans_ac_plan_name_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[10]//table/tbody/tr[@class = 'headerRow']/th[(text()='Account Plan Name')]"));

        IWebElement AccountPlans_Complt_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[10]//table/tbody/tr[@class = 'headerRow']/th[(text()='% Complete')]"));

        IWebElement AccountPlans_Status_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[10]//table/tbody/tr[@class = 'headerRow']/th[(text()='Status')]"));

        IWebElement AccountPlans_Type_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[10]//table/tbody/tr[@class = 'headerRow']/th[(text()='Type')]"));

        IWebElement AccountPlans_Created_By_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[10]//table/tbody/tr[@class = 'headerRow']/th[(text()='Created By')]"));

        IWebElement AccountPlans_Last_Modified_Date_txt => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[10]//table/tbody/tr[@class = 'headerRow']/th[(text()='Last Modified Date')]"));

        IWebElement Call_name => DriverContext.Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/div[2]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/ul[1]/li[2]/span[1]/a[(text()='Testing the Subject Field')]"));

        IWebElement Delete_btn => DriverContext.Driver.FindElement(By.Name("del"));

        IWebElement View_hierarchy_btn => DriverContext.Driver.FindElement(By.Name("view_hierarchy_vod"));

        IList<IWebElement> View_hierarchy_btn_1 => DriverContext.Driver.FindElements(By.Name("view_hierarchy_vod"));

        IWebElement First_itration_plan_table => DriverContext.Driver.FindElement(By.XPath("//*[@class='bPageBlock secondaryPalette']/div[2]/table/tbody/tr[2]"));

        //IWebElement First_Element_of_oplan_table => DriverContext.Driver.FindElement(By.XPath("//*[@class='bPageBlock secondaryPalette']/div[2]/table/tbody/tr[2]/td[2]/a"));

        IWebElement First_Element_of_oplan_table => DriverContext.Driver.FindElement(By.XPath("//*[@class='dataCell']//a"));
        IWebElement Verify_table_rows => DriverContext.Driver.FindElement(By.XPath("//*[@id='vodResultSet']//tr"));

        static IWebElement Employer_plan => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(),'AbbVie')]"));

        static IWebElement PbmPlan => DriverContext.Driver.FindElement(By.XPath("//a[contains(text(),'aClaim Inc')]"));

        static IWebElement Specialty_plan => DriverContext.Driver.FindElement(By.XPath("//a[(text()='AcariaHealth')]"));

        IWebElement Therapeutic_Classes_txt => DriverContext.Driver.FindElement(By.XPath("//h3[contains(text(),'Therapeutic Classes')]"));

        IWebElement Acoounts_txt => DriverContext.Driver.FindElement(By.XPath("//h3[contains(text(),'Accounts')]"));

        static IWebElement State_Medicaid_plan => DriverContext.Driver.FindElement(By.XPath("//a[(text()='State Medicaid of Alabama (AL)')]"));

        static IWebElement Tricare_plan => DriverContext.Driver.FindElement(By.XPath("//a[(text()='Health Net Federal Services (Company)')]"));

        static IWebElement Va_Plan => DriverContext.Driver.FindElement(By.XPath("//a[(text()='U.S. Department of Veterans Affairs (Corporate)')]"));

        static IWebElement Medicare_Plan => DriverContext.Driver.FindElement(By.XPath("//a[(text()='AgeRight Advantage Health Plan')]"));

        static IWebElement My_Accounts_plan => DriverContext.Driver.FindElement(By.XPath("//a[(text()='1199SEIU National Benefit Funds')]"));

        static IWebElement Parents_Accounts_plan => DriverContext.Driver.FindElement(By.XPath("//a[(text()='Aetna Inc - (Corporate)')]"));

        IWebElement View_verification_name => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'detailList']/tbody/tr[2]/td[2]"));

        IWebElement Action_txt_of_Therapeutic_Classes_sp => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[7]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));

        IWebElement Thera_Name_txt_of_Therapeutic_Classes_sp => DriverContext.Driver.FindElement(By.XPath("//*[@class='pbBody']/table/tbody/tr[1]/th[(text()='Thera Name')]"));

        IWebElement Action_txt_of_Accounts_sp => DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div[6]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));

        IWebElement Account_txt_of_Accounts_sp => DriverContext.Driver.FindElement(By.XPath("//*[@class='pbBody']/table/tbody/tr/th[(text()='Account')]"));

        IWebElement Top_next_button => DriverContext.Driver.FindElement(By.XPath("//div[@id='vodNavLinks']/div[4]//a[(text()='Next>')]"));

        IWebElement Top_Previous_button => DriverContext.Driver.FindElement(By.XPath("//div[@id='vodNavLinks']/div[4]//a[(text()='<Previous')]"));

        IWebElement Top_next_button1 => DriverContext.Driver.FindElement(By.XPath("//div[@id='vodNavLinks']/div[4]//a[(text()='Next>')]"));

        IWebElement Plan_products_hover_commercial => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'listHoverLinks']/a/span[(text()='Plan Products')]"));

        IWebElement Specialty_Providers_hover_commercial => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'listHoverLinks']/a/span[(text()='Specialty Providers')]"));

        IWebElement Member_Of_hover_Commercial => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'listHoverLinks']/a/span[(text()='Member Of')]"));

        IWebElement Members_hover_Commercial => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'listHoverLinks']/a/span[(text()='Members')]"));

        IWebElement Address_Hover_Commercial => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'listHoverLinks']/a/span[(text()='Addresses')]"));

        IWebElement Account_Plans_Hover_Commercial => DriverContext.Driver.FindElement(By.XPath("Account_Plans_Hover_Commercial"));

        IWebElement Calls_Hover_Commercial => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'listHoverLinks']/a/span[(text()='Calls (Account)')]"));

        IWebElement New_Account_plan_button_commercial => DriverContext.Driver.FindElement(By.XPath("//*[@class = 'listRelatedObject Custom78Block']/div/div/table/tbody/tr[1]/td[2]/input[@class='btn']"));

        IWebElement Account_name_fld_in_Account_plan => DriverContext.Driver.FindElement(By.Id("Name"));

        IWebElement Percentage_Complete_txt_of_Account_plan => DriverContext.Driver.FindElement(By.XPath("//*[@class='detailList']/tbody/tr[2]/td[4]/input"));

        IWebElement Description_box_txt => DriverContext.Driver.FindElement(By.XPath("//*[@class='detailList']/tbody/tr[5]/td[2]/textarea"));

        IWebElement Save_btn_of_Account_plan => DriverContext.Driver.FindElement(By.XPath("//*[@class='pbButton']/input[@name= 'save']"));

        IWebElement Delete_btn_of_Account_plan => DriverContext.Driver.FindElement(By.XPath("//td[@id='topButtonRow']//input[@name='del']"));





        public void VerifyCalls()
        {
            if (Calendar_evnt1.Count > 0)
            {
                WebDriverExtensions.WaitToLoadPage();
                string actaul_clndr_evnt_without_call = calendar_evnt.Text;
                LogHelpers.Write("sssssssss" + actaul_clndr_evnt_without_call);
                string expected_clndr_evnt_without_call = "You have no events scheduled for the next 7 days.";
                if (actaul_clndr_evnt_without_call.Equals(expected_clndr_evnt_without_call))
                {
                    AccountsBtn.Click();
                }
                else
                {
                    //WebDriverExtensions.WaitForPageLoad();
                    Call_name.Click();
                    Delete_btn.Click();
                }
            }

        }

        public static void AcntPage()
        {

            AccountsBtn.Click();
            string accountverify = MyAccountsText.Text;

            bool accountPage_verification = accountverify.Contains("My Accounts");
            if (accountPage_verification == true)
            {
                LogHelpers.Write("The user is on Account Page");
            }
            else
            {
                LogHelpers.Write("The user is on different Page:----:" + "\n" + "The Header is:----------:" + "\n" + accountverify);

            }
        }

        public string VerifyTitle()
        {
            //string titleOfAccntPage = driver.getTitle();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            string titleOfAccntPage = DriverContext.Driver.Title;
            // string text = "My Accounts";
            Assert.AreEqual(titleOfAccntPage, "Salesforce - Enterprise Edition");
            LogHelpers.Write("The Page Title is Matching");
            return titleOfAccntPage;

        }
        public static bool VerifyViewDropdown()
        {
            //DriverContext.Driver.SwitchTo().Frame("itarget");

             options = WebElementExtensions.GetSelectedListOptions(ViewDropdown1);

            string[] exp = {  "Commercial", "Employer", "Inactive Accounts", "Medicare",
                "My Accounts", "Parent Accounts", "PBM", "Specialty Provider", "State Medicaid", "Tricare", "VA" };
            IList<string> Expected = new List<string>(exp);
            var ViewDropDownValues = Expected.Where(i => !options.Contains(i)).ToList();
            //LogHelpers.Write("Options",options);
            Assert.AreEqual(0, ViewDropDownValues.Count);
            LogHelpers.Write("The Drop-Downs in the View are matching with the requirement");
            return true;
        }
        public void Click_on_commercial_view()
        {
            //WebElementExtensions.SelectDropDownList1(ViewDropdown1, 0);
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown1, "Commercial");
        }
        public static void Click_on_commercial_plan()
        {
            xpathnumer = 9;
            WebDriverExtensions.WaitForPageLoaded(DriverContext.Driver);
            WebDriverExtensions.WaitToLoadPage();
            acntsHeaderTxt_commercial = CommercialPlan.Text;
            WebDriverExtensions.WaitToLoadPage();
            CommercialPlan.Click();
            LogHelpers.Write("The commercial Plan which is selected ");

        }

        public void CheckHeader_for_commercial()
        {

            LogHelpers.Write("acntsHeaderTxt_commercial  " + acntsHeaderTxt_commercial);
            string expAccountHeaderTxt_commercial = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_commercial  " + expAccountHeaderTxt_commercial);
            Assert.AreEqual(acntsHeaderTxt_commercial, expAccountHeaderTxt_commercial);
        }
        public void CheckAccounts_items_for_Commercial()
        {
            List<string> actualAccountslist = new List<string>();
            actualAccountslist.Add(Account_Detail_txt.Text);
            actualAccountslist.Add(Formulary_txt.Text);
            DriverContext.Driver.SwitchTo().Frame(1);
            actualAccountslist.Add(Dashboard_txt.Text);
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(3);
            actualAccountslist.Add(Coverage_Policy_Details_txt.Text);
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(4);
            actualAccountslist.Add(Pharmacy_Service_txt.Text);

            // DriverContext.Driver.SwitchTo().parentFrame();
            DriverContext.Driver.SwitchTo().DefaultContent();
            LogHelpers.Write("got back to parent Frame");
            // DriverContext.Driver.navigate().refresh();
            // DriverContext.Driver.SwitchTo().defaultContent();
            actualAccountslist.Add(Plan_Products_txt.Text);
            actualAccountslist.Add(Specialty_Providers_txt.Text);
            actualAccountslist.Add(Member_Of_txt.Text);
            actualAccountslist.Add(Members_txt.Text);
            actualAccountslist.Add(Addresses_txt.Text);
            actualAccountslist.Add(Account_Plans_txt.Text);
            actualAccountslist.Add(Calls_txt.Text);
            actualAccountslist.Sort();
            LogHelpers.Write("actualAccountslist" + string.Join<string>(" , ", actualAccountslist));
            string[] expectedAccountsDetails = { "Account Detail", "Dashboard", "Formulary", "Coverage Policy",
                "Pharmacy Service", "Plan Products", "Specialty Providers", "Member Of", "Members", "Addresses",
                "Account Plans", "Calls (Account)" };
            List<string> expectedaccountslist = new List<string>();
            expectedaccountslist.AddRange(expectedAccountsDetails);

            expectedaccountslist.Sort();
            LogHelpers.Write("expectedaccountslist" + string.Join<string>(" , ", expectedaccountslist));
            var result = actualAccountslist.Where(x => !expectedaccountslist.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
            LogHelpers.Write("The Accounts Items are matching aginst the Requirement");
        }
        public void CheckFiledsinAccountDetails_items()
        {

            List<string> actual_AccountDetails_list = new List<string>();
            actual_AccountDetails_list.Add(Name_txt.Text);
            actual_AccountDetails_list.Add(Account_Type_txt.Text);
            actual_AccountDetails_list.Add(Entity_Level_txt.Text);
            actual_AccountDetails_list.Add(Parent_Account_Txt.Text);
            actual_AccountDetails_list.Add(Website_txt.Text);
            actual_AccountDetails_list.Add(Plan_LivesRx_txt.Text);

            actual_AccountDetails_list.Sort();

            LogHelpers.Write("actual_AccountDetails_list " + string.Join<string>(" , ", actual_AccountDetails_list));

            string[] expected_AccountDetails = { "Name", "Account Type", "Entity Level", "Parent Account", "Website",
                "Plan Lives Rx" };

            List<string> expected_account_Deatail_list = new List<string>();
            expected_account_Deatail_list.AddRange(expected_AccountDetails);
            expected_account_Deatail_list.Sort();
            LogHelpers.Write("expected_account_Deatail_list " + string.Join<string>(" , ", expected_account_Deatail_list));
            var result = actual_AccountDetails_list.Where(x => !expected_account_Deatail_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
            LogHelpers.Write("The Account Details Items are matching aginst the Requirement");
        }

        public void VerifyAccountNameAgainstAccountDetails()
        {
            string accountverify_txt = AcountVerificationText.Text;
            string name_verify_txt = Name_of_slctd_comme_accnt.Text;
            Assert.AreEqual(accountverify_txt, name_verify_txt);
            LogHelpers.Write("The account name is matching with the account Details ");
        }

        public void Verify_Formulary_items()
        {
            List<string> actual_formulary_item_list = new List<string>();
            DriverContext.Driver.SwitchTo().Frame(2);
            //actual_formulary_item_list.add(view_of_Formulary_txt.getText());
            actual_formulary_item_list.Add(BenifitDesign_of_Formulary_txt.Text);
            actual_formulary_item_list.Add(Market_txt.Text);
            actual_formulary_item_list.Sort();

            LogHelpers.Write("actual_formulary_item_list" + string.Join<string>(" , ", actual_formulary_item_list));

            string[] expected_formulary_item = { "Benefit Design", "Market" };
            List<string> expected_formulary_list = new List<string>();
            expected_formulary_list.AddRange(expected_formulary_item);

            expected_formulary_list.Sort();
            LogHelpers.Write("expected_formulary_list" + string.Join<string>(" , ", expected_formulary_list));
            var result = actual_formulary_item_list.Where(x => !expected_formulary_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
            LogHelpers.Write("The Formulary Items are matching aginst the Requirement");
        }

        public void Verify_coverage_policy_items()
        {
            List<string> actual_cvrg_plc_item_list = new List<string>();
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(3);

            actual_cvrg_plc_item_list.Add(DrugName_txt_of_cvrg_plc.Text);
            actual_cvrg_plc_item_list.Add(Channel_txt_of_cvrg_plc.Text);
            actual_cvrg_plc_item_list.Add(Subchannel_txt_of_cvrg_plc.Text);
            actual_cvrg_plc_item_list.Add(Score_txt_of_cvrg_plc.Text);
            actual_cvrg_plc_item_list.Add(Indication_txt_of_cvrg_plc.Text);
            actual_cvrg_plc_item_list.Add(Sub_Indication_txt_of_cvrg_plc.Text);
            actual_cvrg_plc_item_list.Sort();

            LogHelpers.Write("actual_cvrg_plc_item_list" + string.Join<string>(" , ", actual_cvrg_plc_item_list));

            string[] expected_cvrg_plc_item = { "Drug Name", "Channel", "SubChannel", "Score", "Indication", "Sub-Indication" };
            List<string> expected_cvrg_plc_item_list = new List<string>();
            expected_cvrg_plc_item_list.AddRange(expected_cvrg_plc_item);
            expected_cvrg_plc_item_list.Sort();

            LogHelpers.Write("expected_cvrg_plc_item_list" + string.Join<string>(" , ", expected_cvrg_plc_item_list));
            var result = actual_cvrg_plc_item_list.Where(x => !expected_cvrg_plc_item_list.Contains(x)).ToList();

            Assert.AreEqual(0, result.Count);
            LogHelpers.Write("The Coverage Policy Items are matching aginst the Requirement");
        }

        public void Verify_pharmacy_srvices_items()
        {
            List<string> actual_pharmacy_plc_item_list = new List<string>();
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(4);

            actual_pharmacy_plc_item_list.Add(Service_of_pharmacyServices.Text);
            actual_pharmacy_plc_item_list.Add(Channel_of_pharmacyServices.Text);
            actual_pharmacy_plc_item_list.Add(SubChannel_of_pharmacySevices.Text);
            actual_pharmacy_plc_item_list.Add(PbmName_of_pharmacySevices.Text);
            actual_pharmacy_plc_item_list.Add(Prvdr_name_of_pharmacySevices.Text);
            actual_pharmacy_plc_item_list.Sort();

            LogHelpers.Write("actual_pharmacy_plc_item_list" + string.Join<string>(" , ", actual_pharmacy_plc_item_list));
            string[] expected_cvrg_plc_item = { "Service Name", "Channel", "SubChannel", "PBM Name", "Provider Name" };
            List<string> expected_cvrg_plc_item_list = new List<string>();
            expected_cvrg_plc_item_list.AddRange(expected_cvrg_plc_item);
            expected_cvrg_plc_item_list.Sort();
            LogHelpers.Write("expected_cvrg_plc_item_list" + string.Join<string>(" , ", expected_cvrg_plc_item_list));
            var result = actual_pharmacy_plc_item_list.Where(x => !expected_cvrg_plc_item_list.Contains(x)).ToList();

            Assert.AreEqual(0, result.Count);
            LogHelpers.Write("The Pharmacy Policy Items are matching aginst the Requirement");
        }

        public void Verify_plan_products_items()
        {
            List<string> actual_plan_products_item_list = new List<string>();
            DriverContext.Driver.SwitchTo().DefaultContent();

            actual_plan_products_item_list.Add(Action_txt_of_plan_prods.Text);
            actual_plan_products_item_list.Add(Product_Nametxt_of_plan_prods.Text);
            actual_plan_products_item_list.Add(Channel_txt_of_plan_products.Text);
            actual_plan_products_item_list.Add(SubChannel_txt_of_plan_prods.Text);
            actual_plan_products_item_list.Add(Product_Type_txt_of_plan_prods.Text);
            actual_plan_products_item_list.Add(Formulary_Used_txt_of_plan_prods.Text);
            actual_plan_products_item_list.Sort();

            LogHelpers.Write("actual_plan_products_item_list" + string.Join<string>(" , ", actual_plan_products_item_list));

            string[] expected_plan_products_item = { "Action", "Product Name", "Channel", "SubChannel", "Product Type",
                "Formulary Type Used" };
            List<string> expected_plan_products_item_list = new List<string>();

            expected_plan_products_item_list.AddRange(expected_plan_products_item);
            expected_plan_products_item_list.Sort();
            LogHelpers.Write("expected_plan_products_item_list" + string.Join<string>(" , ", expected_plan_products_item_list));
            var result = actual_plan_products_item_list.Where(x => !expected_plan_products_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
            LogHelpers.Write("The Phlan Products Items are matching aginst the Requirement");
        }
        public void Verify_Specialty_Providers_items()
        {
            List<string> actual_Specialty_Providers_item_list = new List<string>();
            actual_Specialty_Providers_item_list.Add(Spc_Prvdr_action_txt.Text);
            actual_Specialty_Providers_item_list.Add(Spc_Prvdr_Specialty_Provider_txt.Text);
            actual_Specialty_Providers_item_list.Add(Spc_Prvdr_Website_txt.Text);
            actual_Specialty_Providers_item_list.Sort();

            LogHelpers.Write("actual_Specialty_Providers_item_list" + string.Join<string>(" , ", actual_Specialty_Providers_item_list));

            string[] expected_Specialty_Providers_item = { "Action", "Specialty Provider", "Website" };
            List<string> expected_Specialty_Providers_item_list = new List<string>();
            expected_Specialty_Providers_item_list.AddRange(expected_Specialty_Providers_item);
            expected_Specialty_Providers_item_list.Sort();
            LogHelpers.Write("expected_Specialty_Providers_item_list" + string.Join<string>(" , ", expected_Specialty_Providers_item_list));
            var result = actual_Specialty_Providers_item_list.Where(x => !expected_Specialty_Providers_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
            LogHelpers.Write("The Items in Specialty Provider is matching against Requirement");
        }
        public void Verify_Member_Of_items()
        {
            List<string> actual_MemberOf_item_list = new List<string>();
            actual_MemberOf_item_list.Add(Member_Of_Action_txt.Text);
            actual_MemberOf_item_list.Add(Member_Of_Parent_Account_txt.Text);
            actual_MemberOf_item_list.Sort();

            LogHelpers.Write("actual_MemberOf_item_list" + string.Join<string>(" , ", actual_MemberOf_item_list));

            string[] expected_MemberOf_item = { "Action", "Parent Account" };
            List<string> expected_MemberOf_item_list = new List<string>();
            expected_MemberOf_item_list.AddRange(expected_MemberOf_item);
            expected_MemberOf_item_list.Sort();
            LogHelpers.Write("expected_MemberOf_item_list" + string.Join<string>(" , ", expected_MemberOf_item_list));
            var result = actual_MemberOf_item_list.Where(x => !expected_MemberOf_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }
        public void Verify_member_items()
        {
            List<string> actual_member_item_list = new List<string>();
            actual_member_item_list.Add(Member_Action_txt.Text);
            actual_member_item_list.Add(Member_child_acnt_txt.Text);
            actual_member_item_list.Add(Member_Title_txt.Text);
            actual_member_item_list.Add(Member_Acnt_type_txt.Text);
            actual_member_item_list.Sort();

            LogHelpers.Write("actual_member_item_list" + string.Join<string>(" , ", actual_member_item_list));
            string[] expected_member_item = { "Action", "Child Account", "Title", "Account Type" };
            List<string> expected_member_item_list = new List<string>();
            expected_member_item_list.AddRange(expected_member_item);
            expected_member_item_list.Sort();
            LogHelpers.Write("expected_member_item_list" + string.Join<string>(" , ", expected_member_item_list));
            var result = actual_member_item_list.Where(x => !expected_member_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }

        public void Verify_member_items_VA()
        {
            List<string> actual_member_item_list = new List<string>();
            actual_member_item_list.Add(Member_Action_txt_VA.Text);
            actual_member_item_list.Add(Member_child_acnt_txt_VA.Text);
            actual_member_item_list.Add(Member_Title_txt_VA.Text);
            actual_member_item_list.Add(Member_Acnt_type_txt_VA.Text);
            actual_member_item_list.Sort();

            LogHelpers.Write("actual_member_item_list" + string.Join<string>(" , ", actual_member_item_list));
            string[] expected_member_item = { "Action", "Child Account", "Title", "Account Type" };
            List<string> expected_member_item_list = new List<string>();
            expected_member_item_list.AddRange(expected_member_item);
            expected_member_item_list.Sort();
            LogHelpers.Write("expected_member_item_list" + string.Join<string>(" , ", expected_member_item_list));
            var result = actual_member_item_list.Where(x => !expected_member_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }

        public void Verify_address_items()
        {
            List<string> actual_address_item_list = new List<string>();

            IWebElement address_action_txt = DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div"
                    + "[" + xpathnumer + "]//table/tbody/tr[@class = 'headerRow']/th[(text()='Action')]"));
            actual_address_item_list.Add(address_action_txt.Text);
            IWebElement address_Address_line_1_txt = DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div"
                    + "[" + xpathnumer + "]//table/tbody/tr[@class = 'headerRow']/th[(text()='Address line 1')]"));
            actual_address_item_list.Add(address_Address_line_1_txt.Text);
            IWebElement address_Address_line_2_txt = DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div"
                    + "[" + xpathnumer + "]//table/tbody/tr[@class = 'headerRow']/th[(text()='Address line 2')]"));
            actual_address_item_list.Add(address_Address_line_2_txt.Text);
            IWebElement address_City_txt = DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div"
                    + "[" + xpathnumer + "]//table/tbody/tr[@class = 'headerRow']/th[(text()='City')]"));
            actual_address_item_list.Add(address_City_txt.Text);
            IWebElement address_State_txt = DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div"
                    + "[" + xpathnumer + "]//table/tbody/tr[@class = 'headerRow']/th[(text()='State')]"));
            actual_address_item_list.Add(address_State_txt.Text);
            IWebElement address_Zip_txt = DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div"
                    + "[" + xpathnumer + "]//table/tbody/tr[@class = 'headerRow']/th[(text()='Zip')]"));
            actual_address_item_list.Add(address_Zip_txt.Text);
            IWebElement address_Map_txt = DriverContext.Driver.FindElement(By.XPath("//*[@id = 'contentWrapper']/div[2]/table/tbody/tr[1]/td[2]/div"
                    + "[" + xpathnumer + "]//table/tbody/tr[@class = 'headerRow']/th[(text()='Map')]"));
            actual_address_item_list.Add(address_Map_txt.Text);

            actual_address_item_list.Sort();

            LogHelpers.Write("actual_address_item_list" + string.Join<string>(" , ", actual_address_item_list));
            string[] expected_address_item = { "Action", "Address line 1", "Address line 2", "City", "State", "Zip",
                "Map" };
            List<string> expected_address_item_list = new List<string>();
            expected_address_item_list.AddRange(expected_address_item);
            expected_address_item_list.Sort();
            LogHelpers.Write("expected_address_item_list" + string.Join<string>(" , ", expected_address_item_list));
            var result = actual_address_item_list.Where(x => !expected_address_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }
        public void Verify_Account_plan_items()
        {
            List<string> actual_account_plan_item_list = new List<string>();

            actual_account_plan_item_list.Add(AccountPlans_Action_txt.Text);
            actual_account_plan_item_list.Add(AccountPlans_ac_plan_name_txt.Text);
            actual_account_plan_item_list.Add(AccountPlans_Complt_txt.Text);
            actual_account_plan_item_list.Add(AccountPlans_Status_txt.Text);
            actual_account_plan_item_list.Add(AccountPlans_Type_txt.Text);
            actual_account_plan_item_list.Add(AccountPlans_Created_By_txt.Text);
            actual_account_plan_item_list.Add(AccountPlans_Last_Modified_Date_txt.Text);

            actual_account_plan_item_list.Sort();
            LogHelpers.Write("actual_account_plan_item_list" + string.Join<string>(" , ", actual_account_plan_item_list));
            string[] expected_account_plan_item = { "Action", "Account Plan Name", "% Complete", "Status", "Type",
                "Created By", "Last Modified Date" };
            List<string> expected_account_plan_item_list = new List<string>();
            expected_account_plan_item_list.AddRange(expected_account_plan_item);
            expected_account_plan_item_list.Sort();
            LogHelpers.Write("expected_account_plan_item_list" + string.Join<string>(" , ", expected_account_plan_item_list));
            var result = actual_account_plan_item_list.Where(x => !expected_account_plan_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }

        public void Verify_view_Hierarchy_Button()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            viewDropdownSelect = new SelectElement(ViewDropdown1);
            //IList options = new IList<>();
            int dropdown_size = viewDropdownSelect.Options.Count;
            
            
            for (int i = 0; i < dropdown_size; i++)
            {
                //WebDriverExtensions.WaitForPageLoaded(DriverContext.Driver);
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                viewDropdownSelect = new SelectElement(ViewDropdown1);
                viewDropdownSelect.SelectByIndex(i);
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                List<IWebElement> table_list = DriverContext.Driver.FindElements(By.XPath("//*[@id='vodResultSet']//tr")).ToList();

                if (table_list.Count() > 2)
                {
                    LogHelpers.Write("Entered into the if clause for " + i);
                    WebDriverExtensions.WaitToLoadPage();

                    //DriverContext.Driver.FindElement(By.XPath("//*[@class='bPageBlock secondaryPalette']/div[2]/table/tbody/tr[2]/td[2]/a")).Click();

                    //IWebElement first_ele = DriverContext.Driver.FindElement(By.XPath("//*[@class='bPageBlock secondaryPalette']/div[2]/table/tbody/tr[2]/td[2]/a"));
                    //IWebElement first_ele = DriverContext.Driver.FindElement(By.XPath("//*[@id='vodResultSet']/tbody/tr[2]/td[2]/a"));
                    IWebElement first_ele = DriverContext.Driver.FindElement(By.XPath("//*[@id='vodBodyTable']//*[@id='vodResultSet']/tbody/tr[2]/td[2]/a"));
                    //first_ele.Click();
                    //DriverContext.Driver.SwitchTo().Frame("itarget");
                    IJavaScriptExecutor jse = (IJavaScriptExecutor)DriverContext.Driver;
                    //jse.ExecuteScript("document.getElementById('"+ first_ele + "').click();");
                    jse.ExecuteScript("arguments[0].click();", first_ele);
                    //actions.MoveToElement(first_ele).Click();
                    //actions.Click();
                    // actions.Build();
                    // actions.Perform();
                    WebDriverExtensions.WaitToLoadPage();

                    // First_Element_of_oplan_table.Click();
                    LogHelpers.Write("first Element Clicked");
                    WebDriverExtensions.WaitForPageLoaded(DriverContext.Driver);
                    if (View_hierarchy_btn_1.Count() > 0)
                    {
                        // WebDriverExtensions.WaitForPageLoaded(DriverContext.Driver);
                        WebDriverExtensions.WaitToLoadPage();
                        View_hierarchy_btn.Click();
                        LogHelpers.Write("View Hierarchy button clicked for " + i);
                        AccountsBtn.Click();
                        WebDriverExtensions.WaitToLoadPage();
                        
                        DriverContext.Driver.SwitchTo().Frame("itarget");
                    }
                    else
                    {
                        //WebDriverExtensions.WaitForPageLoaded(DriverContext.Driver);
                        LogHelpers.Write("View Hierarchy button is not there");
                        AccountsBtn.Click();
                        DriverContext.Driver.SwitchTo().Frame("itarget");
                    }
                }
            }
        }
        public void Click_on_Employer_view()
        {
            //DriverContext.Driver.SwitchTo().Frame("itarget");
            //AccountsBtn.Click();
            //DriverContext.Driver.SwitchTo().Frame("itarget");
            //WebElementExtensions.SelectDropDownList1(ViewDropdown, 2);
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Employer");
        }
        public static void Click_on_Employer_plan()
        {
            WebDriverExtensions.WaitForPageLoaded(DriverContext.Driver);
            WebDriverExtensions.WaitToLoadPage();
            selected_Employer_Plan = Employer_plan.Text;

            Employer_plan.Click();
        }
        public void CheckHeader_of_Employer()
        {
            // String acntsHeaderTxt=acountVerificationText.getText();
            LogHelpers.Write("selected_Employer_Plan" + selected_Employer_Plan);
            string expAccountHeaderTxt = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_____" + expAccountHeaderTxt);
            Assert.AreEqual(selected_Employer_Plan, expAccountHeaderTxt);
        }

        public void CheckAccounts_items_for_Employer()
        {
            List<string> actualAccountslist_Employer = new List<string>();
            actualAccountslist_Employer.Add(Account_Detail_txt.Text);
            actualAccountslist_Employer.Add(Formulary_txt.Text);
            DriverContext.Driver.SwitchTo().Frame(1);
            actualAccountslist_Employer.Add(Dashboard_txt.Text);
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(3);
            actualAccountslist_Employer.Add(Pharmacy_Service_txt.Text);
            // driver.switchTo().parentFrame();
            DriverContext.Driver.SwitchTo().DefaultContent();
            LogHelpers.Write("got back to parent frame");
            // driver.navigate().refresh();
            // driver.switchTo().defaultContent();
            actualAccountslist_Employer.Add(Plan_Products_txt.Text);
            actualAccountslist_Employer.Add(Addresses_txt.Text);
            actualAccountslist_Employer.Add(Account_Plans_txt.Text);
            actualAccountslist_Employer.Add(Calls_txt.Text);
            actualAccountslist_Employer.Sort();
            LogHelpers.Write("actualAccountslist" + string.Join<string>(" , ", actualAccountslist_Employer));
            string[] expectedAccountsDetails_for_Employer = { "Account Detail", "Dashboard", "Formulary",
                "Pharmacy Service", "Plan Products", "Addresses", "Account Plans", "Calls (Account)" };
            List<string> expectedaccountslist_for_employer = new List<string>();
            expectedaccountslist_for_employer.AddRange(expectedAccountsDetails_for_Employer);

            expectedaccountslist_for_employer.Sort();
            LogHelpers.Write("expectedaccountslist_for_employer" + string.Join<string>(" , ", expectedaccountslist_for_employer));
            var result = actualAccountslist_Employer.Where(x => !expectedaccountslist_for_employer.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }

        public void Click_on_PBM_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            //viewDropdownSelect.SelectByIndex(9);
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "PBM");
        }

        public static void Click_on_PBM_plan()
        {
            WebDriverExtensions.WaitToLoadPage();
            selected_Pbm_Plan = PbmPlan.Text;
            
            PbmPlan.Click();
        }

        public void CheckHeader_of_PBM()
        {
            LogHelpers.Write("selected_Pbm_Plan" + selected_Pbm_Plan);
            String expAccountHeaderTxt = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_____" + expAccountHeaderTxt);
            Assert.AreEqual(selected_Pbm_Plan, expAccountHeaderTxt);
        }

        public void CheckAccounts_items_for_PBM()
        {
            List<string> actualAccountslist_PBM = new List<string>();
            actualAccountslist_PBM.Add(Account_Detail_txt.Text);
            actualAccountslist_PBM.Add(Formulary_txt.Text);
            DriverContext.Driver.SwitchTo().Frame(1);
            actualAccountslist_PBM.Add(Dashboard_txt.Text);
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(3);
            actualAccountslist_PBM.Add(Coverage_Policy_Details_txt.Text);
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(4);
            actualAccountslist_PBM.Add(Pharmacy_Service_txt.Text);

            // DriverContext.Driver.SwitchTo().parentFrame();
            DriverContext.Driver.SwitchTo().DefaultContent();
            LogHelpers.Write("got back to parent frame");
            // DriverContext.Driver.navigate().refresh();
            // DriverContext.Driver.SwitchTo().defaultContent();
            actualAccountslist_PBM.Add(Members_txt.Text);
            actualAccountslist_PBM.Add(Addresses_txt.Text);
            actualAccountslist_PBM.Add(Account_Plans_txt.Text);
            actualAccountslist_PBM.Add(Calls_txt.Text);
            actualAccountslist_PBM.Sort();
            LogHelpers.Write("actualAccountslist_PBM" + string.Join<string>(" , ",actualAccountslist_PBM));
            LogHelpers.Write("actualAccountslist" + string.Join<string>(" , ",actualAccountslist_PBM));
            string[] expectedAccountsDetails_for_PBM = { "Account Detail", "Dashboard", "Formulary", "Coverage Policy",
                "Pharmacy Service", "Members", "Addresses", "Account Plans", "Calls (Account)" };
            List<string> expectedaccountslist_for_PBM = new List<string>();
            expectedaccountslist_for_PBM.AddRange(expectedAccountsDetails_for_PBM);
            
            expectedaccountslist_for_PBM.Sort();
            LogHelpers.Write("expectedaccountslist_for_PBM" + string.Join<string>(" , ",expectedaccountslist_for_PBM));

            var result = actualAccountslist_PBM.Where(x => !expectedaccountslist_for_PBM.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }

        public void Click_on_Specialty_plan_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            //viewDropdownSelect.SelectByIndex(10);
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Specialty Provider");
        }

        public static void Click_on_Specialty_plan()
        {
            WebDriverExtensions.WaitToLoadPage();
            selected_Specialty_plan = Specialty_plan.Text;
            WebDriverExtensions.WaitToLoadPage();
            Specialty_plan.Click();
        }
        public void CheckHeader_of_Specialty()
        {
            LogHelpers.Write("selected_Specialty_plan" + selected_Specialty_plan);
            string expAccountHeaderTxt = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_____" + expAccountHeaderTxt);
            Assert.AreEqual(selected_Specialty_plan, expAccountHeaderTxt);
        }
        public void CheckAccounts_items_for_Specialty_view()
        {
            List<string> actualAccountslist_for_Specialty_plan = new List<string>();
            actualAccountslist_for_Specialty_plan.Add(Account_Detail_txt.Text);
            actualAccountslist_for_Specialty_plan.Add(Therapeutic_Classes_txt.Text);
            actualAccountslist_for_Specialty_plan.Add(Acoounts_txt.Text);
            actualAccountslist_for_Specialty_plan.Add(Addresses_txt.Text);

            actualAccountslist_for_Specialty_plan.Sort();
           
            LogHelpers.Write("actualAccountslist" + string.Join<string>(" , ",actualAccountslist_for_Specialty_plan));
            string[] expectedAccountsDetails_for_Specialty_Provider = { "Account Detail", "Therapeutic Classes", "Accounts",
                "Addresses" };
            List<string> expectedaccountslist_for_Specialty_Provider = new List<string>();
            expectedaccountslist_for_Specialty_Provider.AddRange(expectedAccountsDetails_for_Specialty_Provider);
            expectedaccountslist_for_Specialty_Provider.Sort();
            LogHelpers.Write("expectedaccountslist_for_Specialty_Provider" + string.Join<string>(" , ",expectedaccountslist_for_Specialty_Provider));
            var result = actualAccountslist_for_Specialty_plan.Where(x => !expectedaccountslist_for_Specialty_Provider.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }
        public void Click_on_State_Medicaid_plan_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "State Medicaid");
        }
        public static void Click_on_State_Medicaid_plan()
        {
            WebDriverExtensions.WaitToLoadPage();
            selected_State_Medicaid_plan = State_Medicaid_plan.Text;
            State_Medicaid_plan.Click();
        }
        public void CheckHeader_of_State_Medicaid_plan()
        {
            LogHelpers.Write("selected_State_Medicaid_plan" + selected_State_Medicaid_plan);
            string expAccountHeaderTxt = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_____" + expAccountHeaderTxt);
            Assert.AreEqual(selected_State_Medicaid_plan, expAccountHeaderTxt);
        }


        public void CheckAccounts_items_for_State_Mediacaid_Plan()
        {
            List<string> actualAccountslist_State_Mediacaid = new List<string>();
            actualAccountslist_State_Mediacaid.Add(Account_Detail_txt.Text);
            actualAccountslist_State_Mediacaid.Add(Formulary_txt.Text);
            DriverContext.Driver.SwitchTo().Frame(1);
            actualAccountslist_State_Mediacaid.Add(Dashboard_txt.Text);
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(3);
            actualAccountslist_State_Mediacaid.Add(Coverage_Policy_Details_txt.Text);
            // driver.switchTo().parentFrame();
            DriverContext.Driver.SwitchTo().DefaultContent();
            LogHelpers.Write("got back to parent frame");
            // driver.navigate().refresh();
            // driver.switchTo().defaultContent();
            actualAccountslist_State_Mediacaid.Add(Plan_Products_txt.Text);
            actualAccountslist_State_Mediacaid.Add(Specialty_Providers_txt.Text);
            actualAccountslist_State_Mediacaid.Add(Member_Of_txt.Text);
            actualAccountslist_State_Mediacaid.Add(Members_txt.Text);
            actualAccountslist_State_Mediacaid.Add(Addresses_txt.Text);
            actualAccountslist_State_Mediacaid.Add(Account_Plans_txt.Text);
            actualAccountslist_State_Mediacaid.Add(Calls_txt.Text);
            actualAccountslist_State_Mediacaid.Sort();
            LogHelpers.Write("actualAccountslist_State_Mediacaid" + string.Join<string>(" , ",actualAccountslist_State_Mediacaid));
            string[] expectedAccountsDetails_for_State_Medicaid = { "Account Detail", "Dashboard", "Formulary",
                "Coverage Policy", "Plan Products", "Specialty Providers", "Member Of", "Members", "Addresses",
                "Account Plans", "Calls (Account)" };
            List<string> expectedaccountslist_for_State_Medicaid = new List<string>();
            expectedaccountslist_for_State_Medicaid.AddRange(expectedAccountsDetails_for_State_Medicaid);
            expectedaccountslist_for_State_Medicaid.Sort();
            LogHelpers.Write("expectedaccountslist_for_State_Medicaid" + string.Join<string>(" , ",expectedaccountslist_for_State_Medicaid));
            var result = actualAccountslist_State_Mediacaid.Where(x => !expectedaccountslist_for_State_Medicaid.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);  
        }
        public void Click_on_Tricare_plan_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Tricare");
        }
        public static void Click_on_Tricare_plan()
        {
            WebDriverExtensions.WaitToLoadPage();
            selected_Tricare_plan = Tricare_plan.Text;
            Tricare_plan.Click();
        }
        public void CheckHeader_of_Tricare_plan()
        {
            LogHelpers.Write("selected_Tricare_plan" + selected_Tricare_plan);
            string expAccountHeaderTxt = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_____" + expAccountHeaderTxt);
            Assert.AreEqual(selected_Tricare_plan, expAccountHeaderTxt);
        }

        public void CheckAccounts_items_for_Tricare_Plan()
        {
            List<string> actualAccountslist_Tricare = new List<string>();
            actualAccountslist_Tricare.Add(Account_Detail_txt.Text);
            actualAccountslist_Tricare.Add(Formulary_txt.Text);
            DriverContext.Driver.SwitchTo().Frame(1);
            actualAccountslist_Tricare.Add(Dashboard_txt.Text);
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(3);
            actualAccountslist_Tricare.Add(Pharmacy_Service_txt.Text);
            DriverContext.Driver.SwitchTo().DefaultContent();
            LogHelpers.Write("got back to parent frame");
            actualAccountslist_Tricare.Add(Plan_Products_txt.Text);
            actualAccountslist_Tricare.Add(Specialty_Providers_txt.Text);
            actualAccountslist_Tricare.Add(Member_Of_txt.Text);
            actualAccountslist_Tricare.Add(Members_txt.Text);
            actualAccountslist_Tricare.Add(Addresses_txt.Text);
            actualAccountslist_Tricare.Add(Account_Plans_txt.Text);
            actualAccountslist_Tricare.Add(Calls_txt.Text);
            actualAccountslist_Tricare.Sort();
            LogHelpers.Write("actualAccountslist_Tricare" + string.Join<string>(" , ",actualAccountslist_Tricare));
            string[] expectedAccountsDetails_for_Tricare = { "Account Detail", "Dashboard", "Formulary", "Pharmacy Service",
                "Plan Products", "Specialty Providers", "Member Of", "Members", "Addresses", "Account Plans",
                "Calls (Account)" };
            List<string> expectedaccountslist_for_Tricare = new List<string>();
            expectedaccountslist_for_Tricare.AddRange(expectedAccountsDetails_for_Tricare);
            expectedaccountslist_for_Tricare.Sort();
            LogHelpers.Write("expectedaccountslist_for_Tricare" + string.Join<string>(" , ",expectedaccountslist_for_Tricare));
            var result = actualAccountslist_Tricare.Where(x => !expectedaccountslist_for_Tricare.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }

        public void Click_on_VA_plan_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "VA");
        }

        public static void Click_on_VA_plan()
        {
            WebDriverExtensions.WaitToLoadPage();
            selected_Va_Plan = Va_Plan.Text;
            Va_Plan.Click();
        }

        public void CheckHeader_of_VA_plan()
        {
            LogHelpers.Write("selected_Va_Plan" + selected_Va_Plan);
            string expAccountHeaderTxt = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_____" + expAccountHeaderTxt);
            Assert.AreEqual(selected_Va_Plan, expAccountHeaderTxt);
        }

        public void CheckAccounts_items_for_VA_Plan()
        {
            List<string> actualAccountslist_VA = new List<string>();
            actualAccountslist_VA.Add(Account_Detail_txt.Text);
            actualAccountslist_VA.Add(Formulary_txt.Text);
            DriverContext.Driver.SwitchTo().Frame(1);
            actualAccountslist_VA.Add(Dashboard_txt.Text);
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(3);
            actualAccountslist_VA.Add(Coverage_Policy_Details_txt.Text);
            DriverContext.Driver.SwitchTo().DefaultContent();
            LogHelpers.Write ("got back to parent frame");
            actualAccountslist_VA.Add(Plan_Products_txt.Text);
            actualAccountslist_VA.Add(Member_Of_txt.Text);
            actualAccountslist_VA.Add(Members_txt.Text);
            actualAccountslist_VA.Add(Addresses_txt.Text);
            actualAccountslist_VA.Add(Account_Plans_txt.Text);
            actualAccountslist_VA.Add(Calls_txt.Text);
            actualAccountslist_VA.Sort();
            LogHelpers.Write("actualAccountsactualAccountslist_VAlist" + string.Join<string>(" , ",actualAccountslist_VA));
            string[] expectedAccountsDetails_for_VA = { "Account Detail", "Dashboard", "Formulary", "Coverage Policy",
                "Plan Products", "Member Of", "Members", "Addresses", "Account Plans", "Calls (Account)" };
            List<string> expectedaccountslist_for_VA = new List<string>();
            expectedaccountslist_for_VA.AddRange(expectedAccountsDetails_for_VA);
            expectedaccountslist_for_VA.Sort();
            LogHelpers.Write("expectedaccountslist_for_VA" + string.Join<string>(" , ",expectedaccountslist_for_VA));
            var result = actualAccountslist_VA.Where(x => !expectedaccountslist_for_VA.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }

        public void Click_on_Medicare_plan_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Medicare");
        }
        public static void Click_on_Medicare_plan()
        {
            WebDriverExtensions.WaitToLoadPage();
            selected_Medicare_Plan = Medicare_Plan.Text;
            Medicare_Plan.Click();
        }
        public void CheckHeader_of_Medicare_plan()
        {
            LogHelpers.Write("selected_Medicare_Plan" + selected_Medicare_Plan);
            string expAccountHeaderTxt = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_____" + expAccountHeaderTxt);
            Assert.AreEqual(selected_Medicare_Plan, expAccountHeaderTxt);
        }

        public void Click_on_My_Accounts_plan_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "My Accounts");
        }
        public static void Click_on_My_Accounts_plan()
        {
            WebDriverExtensions.WaitToLoadPage();
            selected_My_Accounts_plan = My_Accounts_plan.Text;
            My_Accounts_plan.Click();
        }
        public void CheckHeader_of_My_Accounts_plan()
        {
            LogHelpers.Write("selected_My_Accounts_plan" + selected_My_Accounts_plan);
            string expAccountHeaderTxt = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_____" + expAccountHeaderTxt);
            Assert.AreEqual(selected_My_Accounts_plan, expAccountHeaderTxt);
        }

        public void Click_on_Parents_Accounts_plan_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Parent Accounts");
        }
        public static void Click_on_Parents_Accounts_plan()
        {
            WebDriverExtensions.WaitToLoadPage();
            selected_Parents_Accounts_plan = Parents_Accounts_plan.Text;
            WebDriverExtensions.WaitToLoadPage();
            Parents_Accounts_plan.Click();
        }

        public void CheckHeader_of_Parents_Accounts_plan()
        {
            LogHelpers.Write("selected_Parents_Accounts_plan" + selected_Parents_Accounts_plan);
            string expAccountHeaderTxt = AcountVerificationText.Text;
            LogHelpers.Write("expAccountHeaderTxt_____" + expAccountHeaderTxt);
            Assert.AreEqual(selected_Parents_Accounts_plan, expAccountHeaderTxt);
        }

        public void Select_Employer_channel()
        {
            WebDriverExtensions.WaitToLoadPage();
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Employer");
            xpathnumer = 6;
            WebDriverExtensions.WaitToLoadPage();
            First_Element_of_oplan_table.Click();
        }
        public void Verify_pharmacy_srvices_items_Employer_channel()
        {
            List<string> actual_pharmacy_plc_item_list = new List<string>();
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(3);
            actual_pharmacy_plc_item_list.Add(Service_of_pharmacyServices.Text);
            actual_pharmacy_plc_item_list.Add(Channel_of_pharmacyServices.Text);
            actual_pharmacy_plc_item_list.Add(SubChannel_of_pharmacySevices.Text);
            actual_pharmacy_plc_item_list.Add(PbmName_of_pharmacySevices.Text);
            actual_pharmacy_plc_item_list.Add(Prvdr_name_of_pharmacySevices.Text);
            actual_pharmacy_plc_item_list.Sort();
            LogHelpers.Write("actual_pharmacy_plc_item_list" + string.Join<string>(" , ",actual_pharmacy_plc_item_list));
            string[] expected_pharmacy_plc_item = { "Service Name", "Channel", "SubChannel", "PBM Name", "Provider Name" };
            List<string> expected_pharmacy_plc_item_list = new List<string>();
            expected_pharmacy_plc_item_list.AddRange(expected_pharmacy_plc_item);
            expected_pharmacy_plc_item_list.Sort();
            LogHelpers.Write("expected_pharmacy_plc_item_list" + string.Join<string>(" , ",expected_pharmacy_plc_item_list));
            var result = actual_pharmacy_plc_item_list.Where(x => !expected_pharmacy_plc_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }
        public void Vefrify_selected_Medicare_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            xpathnumer = 9;
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Medicare");
            WebDriverExtensions.WaitToLoadPage();
            First_Element_of_oplan_table.Click();
            string verify_medicare = View_verification_name.Text;
            LogHelpers.Write("verify_medicare::" + verify_medicare);
            Boolean view_verification_for_Medicare = verify_medicare.Contains("Medicare");
            if (view_verification_for_Medicare == true)
            {
                LogHelpers.Write("The user is Accessing Medicare plan");
            }
            else
            {
                LogHelpers.Write(
                        "The user is accessing a different Page:----:" + "\n" + "The page is:----------:" + "\n" + verify_medicare);
            }
        }
        public void Vefrify_selected_Parents_Accounts_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            xpathnumer = 9;
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Parent Accounts");
            WebDriverExtensions.WaitToLoadPage();
            First_Element_of_oplan_table.Click();
            string verify_Parent_Accounts = View_verification_name.Text;
            LogHelpers.Write("verify_Parent_Accounts::" + verify_Parent_Accounts);
        }

        public void Vefrify_selected_My_Accounts_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            xpathnumer = 9;
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "My Accounts");
            WebDriverExtensions.WaitToLoadPage();
            First_Element_of_oplan_table.Click();
            string verify_My_Accounts = View_verification_name.Text;
            LogHelpers.Write("verify_My_Accounts::" + verify_My_Accounts);
        }

        public void Vefrify_selected_PBM_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            xpathnumer = 6;
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "PBM");
            WebDriverExtensions.WaitToLoadPage();
            First_Element_of_oplan_table.Click();
            string verify_PBM_View = View_verification_name.Text;
            LogHelpers.Write("verify_PBM_View::" + verify_PBM_View);
        }

        public void CheckFiledsinAccountDetails_items_PBM()
        {

            List<string> actual_AccountDetails_list = new List<string>();
            actual_AccountDetails_list.Add(Name_txt.Text);
            actual_AccountDetails_list.Add(Account_Type_txt.Text);
            actual_AccountDetails_list.Add(Entity_Level_txt.Text);
            actual_AccountDetails_list.Add(Parent_Account_Txt.Text);
            actual_AccountDetails_list.Add(Website_txt.Text);
            actual_AccountDetails_list.Sort();
            LogHelpers.Write("actual_AccountDetails_list" + string.Join<string>(" , ",actual_AccountDetails_list));
            string[] expected_AccountDetails = { "Name", "Account Type", "Entity Level", "Parent Account", "Website" };
            List<string> expected_account_Deatail_list = new List<string>();
            expected_account_Deatail_list.AddRange(expected_AccountDetails);
            expected_account_Deatail_list.Sort();
            LogHelpers.Write("expected_account_Deatail_list" + string.Join<string>(" , ",expected_account_Deatail_list));
            var result = actual_AccountDetails_list.Where(x => !expected_account_Deatail_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }
        public void Verify_pharmacy_srvices_items_PBM()
        {
            List<string> actual_pharmacy_plc_item_list_PBM = new List<string>();
            DriverContext.Driver.SwitchTo().ParentFrame();
            DriverContext.Driver.SwitchTo().Frame(4);

            actual_pharmacy_plc_item_list_PBM.Add(Service_of_pharmacyServices.Text);
            actual_pharmacy_plc_item_list_PBM.Add(Channel_of_pharmacyServices.Text);
            actual_pharmacy_plc_item_list_PBM.Add(SubChannel_of_pharmacySevices.Text);
            actual_pharmacy_plc_item_list_PBM.Add(PbmName_of_pharmacySevices_PBM.Text);
            actual_pharmacy_plc_item_list_PBM.Add(Prvdr_name_of_pharmacySevices.Text);
            actual_pharmacy_plc_item_list_PBM.Sort();
            LogHelpers.Write ("actual_pharmacy_plc_item_list_PBM" + actual_pharmacy_plc_item_list_PBM);

            string[] expected_cvrg_plc_item_PBM = { "Service Name", "Channel", "SubChannel", "Account Name", "Provider Name" };
            List<string> expected_cvrg_plc_item_list_PBM = new List<string>();
            expected_cvrg_plc_item_list_PBM.AddRange(expected_cvrg_plc_item_PBM);
            expected_cvrg_plc_item_list_PBM.Sort();
            LogHelpers.Write("expected_cvrg_plc_item_list" + string.Join<string>(" , ",expected_cvrg_plc_item_list_PBM));
            var result = actual_pharmacy_plc_item_list_PBM.Where(x => !expected_cvrg_plc_item_list_PBM.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }
        public void Verify_member_items_PBM()
        {
            DriverContext.Driver.SwitchTo().DefaultContent();
            List<string> actual_member_item_list_PBM = new List<string>();
            actual_member_item_list_PBM.Add(Member_Action_txt_PBM.Text);
            actual_member_item_list_PBM.Add(Member_child_acnt_txt_PBM.Text);
            actual_member_item_list_PBM.Add(Member_Title_txt_PBM.Text);
            actual_member_item_list_PBM.Add(Member_Acnt_type_txt_PBM.Text);
            actual_member_item_list_PBM.Sort();
            LogHelpers.Write("actual_member_item_list_PBM" + string.Join<string>(" , ",actual_member_item_list_PBM));
            string[] expected_member_item_PBM = { "Action", "Child Account", "Title", "Account Type" };
            List<string> expected_member_item_list_PBM = new List<string>();
            expected_member_item_list_PBM.AddRange(expected_member_item_PBM);
            expected_member_item_list_PBM.Sort();
            LogHelpers.Write("expected_member_item_PBM" + string.Join<string>(" , ",expected_member_item_list_PBM));
            var result = actual_member_item_list_PBM.Where(x => !expected_member_item_list_PBM.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }

        public void Vefrify_selected_Specialty_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            xpathnumer = 7;
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Specialty Provider");
            WebDriverExtensions.WaitToLoadPage();
            First_Element_of_oplan_table.Click();
            string verify_Specialty_view = View_verification_name.Text;
            LogHelpers.Write("verify_Specialty_view:: " + verify_Specialty_view);
        }

        public void CheckFiledsinAccountDetails_items_SP()
        {
            List<string> actual_AccountDetails_list = new List<string>();
            actual_AccountDetails_list.Add(Name_txt.Text);
            actual_AccountDetails_list.Add(Account_Type_txt.Text);
            actual_AccountDetails_list.Add(Parent_Account_Txt.Text);
            actual_AccountDetails_list.Sort();
            LogHelpers.Write("actual_AccountDetails_list" + string.Join<string>(" , ",actual_AccountDetails_list));
            string[] expected_AccountDetails = { "Name", "Account Type", "Parent Account" };
            List<string> expected_account_Deatail_list = new List<string>();
            expected_account_Deatail_list.AddRange(expected_AccountDetails);
            expected_account_Deatail_list.Sort();
            LogHelpers.Write("expected_account_Deatail_list" + string.Join<string>(" , ",expected_account_Deatail_list));
            var result = actual_AccountDetails_list.Where(x => !expected_account_Deatail_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }
        public void Verify_Therapeutic_Classes_items_of_SP()
        {
            List<string> actual_Therapeutic_Classes_list = new List<string>();
            actual_Therapeutic_Classes_list.Add(Action_txt_of_Therapeutic_Classes_sp.Text);
            actual_Therapeutic_Classes_list.Add(Thera_Name_txt_of_Therapeutic_Classes_sp.Text);
            actual_Therapeutic_Classes_list.Sort();
            LogHelpers.Write("actual_Therapeutic_Classes_list" + string.Join<string>(" , ",actual_Therapeutic_Classes_list));
            string[] expected_Therapeutic_Classes_item = { "Action", "Thera Name" };
            List<string> expected_Therapeutic_Classes_item_list = new List<string>();
            expected_Therapeutic_Classes_item_list.AddRange(expected_Therapeutic_Classes_item);
            expected_Therapeutic_Classes_item_list.Sort();
            LogHelpers.Write("expected_Therapeutic_Classes_item_list" + string.Join<string>(" , ",expected_Therapeutic_Classes_item_list));
            var result = actual_Therapeutic_Classes_list.Where(x => !expected_Therapeutic_Classes_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }
        public void Verify_Accounts_items_of_SP()
        {
            List<string> actual_Accounts_list = new List<string>();
            actual_Accounts_list.Add(Action_txt_of_Accounts_sp.Text);
            actual_Accounts_list.Add(Account_txt_of_Accounts_sp.Text);
            actual_Accounts_list.Sort();
            LogHelpers.Write("actual_Accounts_list" + string.Join<string>(" , ",actual_Accounts_list));
            string[] expected_Accounts_item = { "Action", "Account" };
            List<string> expected_Accounts_item_list = new List<string>();
            expected_Accounts_item_list.AddRange(expected_Accounts_item);
            expected_Accounts_item_list.Sort();
            LogHelpers.Write("expected_Accounts_item_list" + string.Join<string>(" , ",expected_Accounts_item_list));
            var result = actual_Accounts_list.Where(x => !expected_Accounts_item_list.Contains(x)).ToList();
            Assert.AreEqual(0, result.Count);
        }
        public void Vefrify_selected_State_Medicaid_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            xpathnumer = 9;
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "State Medicaid");
            WebDriverExtensions.WaitToLoadPage();
            First_Element_of_oplan_table.Click();
            string verify_State_Medicaid_View = View_verification_name.Text;
            LogHelpers.Write ("verify_State_Medicaid_View::" + verify_State_Medicaid_View);
        }

        public void Vefrify_selected_Tricare_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            xpathnumer = 9;
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "Tricare");
            WebDriverExtensions.WaitToLoadPage();
            First_Element_of_oplan_table.Click();
            string verify_Tricare_view = View_verification_name.Text;
            LogHelpers.Write("verify_Tricare_view::" + verify_Tricare_view);
        }
        public void Vefrify_selected_VA_view()
        {
            AccountsBtn.Click();
            DriverContext.Driver.SwitchTo().Frame("itarget");
            xpathnumer = 8;
            WebElementExtensions.SelectDropDownList1byText(ViewDropdown, "VA");
            WebDriverExtensions.WaitToLoadPage();
            First_Element_of_oplan_table.Click();
            string verify_VA_View = View_verification_name.Text;
            LogHelpers.Write("verify_VA_View::" + verify_VA_View);
        }
        public void Vefrify_Next_Button() {
         AccountsBtn.Click();
		DriverContext.Driver.SwitchTo().Frame("itarget");
        viewDropdownSelect = new SelectElement(DriverContext.Driver.FindElement(By.XPath("//*[@class = 'bFilterView']/span/span/select[1][@id = 'vwid']")));


        for (int i = 0; i< 4; i++) {
		
                viewDropdownSelect = new SelectElement(DriverContext.Driver.FindElement(By.XPath("//*[@class = 'bFilterView']/span/span/select[1][@id = 'vwid']")));
                viewDropdownSelect.SelectByIndex(i);
                IList<IWebElement> table_list = DriverContext.Driver.FindElements(By.XPath("//*[@id='vodResultSet']//tr"));
			if (table_list.Count() > 15) {
				LogHelpers.Write("Entered into the if clause for " + i);
                 WebDriverExtensions.WaitToLoadPage();
                Top_next_button.Click();
				LogHelpers.Write("Next Button Clicked");
                WebDriverExtensions.WaitToLoadPage();
                Top_Previous_button.Click();
                WebDriverExtensions.WaitToLoadPage();
                LogHelpers.Write("Previous button clicked");
    }
			else {
				LogHelpers.Write("There are below 50 plans for the view "+ i +"   So Next button is not There");
                    WebDriverExtensions.WaitToLoadPage();
                }
	}
		for (int i = 5; i<options.Count(); i++) {
                viewDropdownSelect = new SelectElement(DriverContext.Driver.FindElement(By.XPath("//*[@class = 'bFilterView']/span/span/select[1][@id = 'vwid']")));
                viewDropdownSelect.SelectByIndex(i);
               // viewDropdownSelect.SelectByIndex(i);
			
			
			IList<IWebElement> table_list = DriverContext.Driver.FindElements(By.XPath("//*[@id='vodResultSet']//tr"));
                if (table_list.Count() > 15)
                {
                    LogHelpers.Write("Entered into the if clause for " + i);
                    WebDriverExtensions.WaitToLoadPage();
                    Top_next_button.Click();
                    LogHelpers.Write("Next Button Clicked");
                    WebDriverExtensions.WaitToLoadPage();
                    Top_Previous_button.Click();
                    WebDriverExtensions.WaitToLoadPage();
                    LogHelpers.Write("Previous button clicked");
                }
                else
                {
                    LogHelpers.Write("There are below 50 plans for the view " + i + "   So Next button and previous is not There");
                }
	}
	}
        public void Vefrify_pagination()
        {

            viewDropdownSelect = new SelectElement(ViewDropdown);
            viewDropdownSelect.SelectByIndex(1);
            string before_xpath_piagnation = "//div[@class='rolodex']/a";

            for (int i = 1; i < 28; i++)
            {
                WebDriverExtensions.WaitToLoadPage();
                string pagination = before_xpath_piagnation + "[" + i + "]";
                WebDriverExtensions.WaitToLoadPage();
                DriverContext.Driver.FindElement(By.XPath(pagination)).Click();
                LogHelpers.Write("Pagination clicked on " + i);
            }
        }
        public void Vefrify_Hover()
        {
            //WebElement web_Element_To_Be_Hovered =driver.findE(plan_products_hover_commercial.toString()));
            WebElementExtensions.Hover(Plan_products_hover_commercial);
            WebElementExtensions.Hover(Specialty_Providers_hover_commercial);
            WebElementExtensions.Hover(Member_Of_hover_Commercial);
            WebElementExtensions.Hover(Members_hover_Commercial);
            WebElementExtensions.Hover(Address_Hover_Commercial);
            WebElementExtensions.Hover(Account_Plans_Hover_Commercial);
            WebElementExtensions.Hover(Calls_Hover_Commercial);
        }
        public void Verify_Account_plan_btn()
        {
            ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript("arguments[0].scrollIntoView(true);", New_Account_plan_button_commercial);
            Actions a = new Actions(DriverContext.Driver);
            a.MoveToElement(New_Account_plan_button_commercial).Click().Build().Perform(); ;
        }

        public void Verify_mandatory_fileds_in_Account_plans()
        {
            //Thread.sleep(10000);
            Account_name_fld_in_Account_plan.SendKeys("Testing account Plans Field");
            Percentage_Complete_txt_of_Account_plan.SendKeys("60");
            Description_box_txt.SendKeys("The Automation for Creation of Account Plan is working fine .It's good to go" + "\n" + "\n" + "\n" + "Deepak Kumar Mahapatra");
            Save_btn_of_Account_plan.Click();
        }

        public void Delete_Created_Account_Plan()
        {
            Delete_btn_of_Account_plan.Click();
            DriverContext.Driver.SwitchTo().Alert().Accept();
        }

        public void Close_Browser()
        {
            login.VerifyViewloginDropdown();
            DriverContext.Driver.Close();
        }
    }
}
