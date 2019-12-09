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
    public  class AccountsPageStepDefination
    {
        AccountsPage Accounts = new AccountsPage();

        [Then(@"Check if call is associated with the user or not")]
        public void ThenCheckIfCallIsAssociatedWithTheUserOrNot()
        {
            Accounts.VerifyCalls();
        }

        [Then(@"user clicks on my Accounts")]
        public void ThenUserClicksOnMyAccounts()
        {
            AccountsPage.AcntPage();
        }

        [Then(@"verifies the Title of the Page")]
        public void ThenVerifiesTheTitleOfThePage()
        {
            Accounts.VerifyTitle();
        }

        [Given(@"user is in Accounts Page")]
        public void GivenUserIsInAccountsPage()
        {
            
        }

        [Then(@"Check the view Drop down values against Requirement")]
        public void ThenCheckTheViewDropDownValuesAgainstRequirement()
        {
            AccountsPage.VerifyViewDropdown();
        }
        [When(@"view selected is commercial")]
        public void WhenViewSelectedIsCommercial()
        {
            Accounts.Click_on_commercial_view();
        }

        [When(@"click on one commercial plan")]
        public void WhenClickOnOneCommercialPlan()
        {
            AccountsPage.Click_on_commercial_plan();
        }

        [Then(@"Check the Header")]
        public void ThenCheckTheHeader()
        {
            Accounts.CheckHeader_for_commercial();
        }

        [Then(@"check the selected items in the particular Account")]
        public void ThenCheckTheSelectedItemsInTheParticularAccount()
        {
            Accounts.CheckAccounts_items_for_Commercial();
        }

        [Then(@"check the items in Account Detail")]
        public void ThenCheckTheItemsInAccountDetail()
        {
            Accounts.CheckFiledsinAccountDetails_items();
        }
        [Then(@"compare the accountname with the account Details")]
        public void ThenCompareTheAccountnameWithTheAccountDetails()
        {
            Accounts.VerifyAccountNameAgainstAccountDetails();
        }

        [Then(@"check the items in Formulary")]
        public void ThenCheckTheItemsInFormulary()
        {
            Accounts.Verify_Formulary_items();
        }
        [Then(@"check the items in CovergePolicy")]
        public void ThenCheckTheItemsInCovergePolicy()
        {
            Accounts.Verify_coverage_policy_items();
        }

        [Then(@"check the items in pharmacy Services")]
        public void ThenCheckTheItemsInPharmacyServices()
        {
            Accounts.Verify_pharmacy_srvices_items();
        }
        [Then(@"check the items in Plan Products")]
        public void ThenCheckTheItemsInPlanProducts()
        {
            Accounts.Verify_plan_products_items();
        }

        [Then(@"check the items in Specialty Providers")]
        public void ThenCheckTheItemsInSpecialtyProviders()
        {
            Accounts.Verify_Specialty_Providers_items();
        }

        [Then(@"check the items in Member Of")]
        public void ThenCheckTheItemsInMemberOf()
        {
            Accounts.Verify_Member_Of_items();
        }
        [Then(@"check the items in Member")]
        public void ThenCheckTheItemsInMember()
        {
            Accounts.Verify_member_items();
        }
        [Then(@"check the items in Address")]
        public void ThenCheckTheItemsInAddress()
        {
            Accounts.Verify_address_items();
        }
        [Then(@"check the items in Account Plan")]
        public void ThenCheckTheItemsInAccountPlan()
        {
            Accounts.Verify_Account_plan_items();
        }

        [Then(@"check the View Hierarchy button")]
        public void ThenCheckTheViewHierarchyButton()
        {
           Accounts.Verify_view_Hierarchy_Button();
        }

        [When(@"view selected is Employer")]
        public void WhenViewSelectedIsEmployer()
        {
            Accounts.Click_on_Employer_view();
        }

        [When(@"click on one Employer plan")]
        public void WhenClickOnOneEmployerPlan()
        {
            AccountsPage.Click_on_Employer_plan();
        }

        [Then(@"Check the Header of Employer Plan")]
        public void ThenCheckTheHeaderOfEmployerPlan()
        {
            Accounts.CheckHeader_of_Employer();
        }

        [Then(@"check the selected items in the particular Account of Employer Plan")]
        public void ThenCheckTheSelectedItemsInTheParticularAccountOfEmployerPlan()
        {
            Accounts.CheckAccounts_items_for_Employer();
        }
        [When(@"view selected is PBM")]
        public void WhenViewSelectedIsPBM()
        {
            Accounts.Click_on_PBM_view();
        }

        [When(@"click on one PBM plan")]
        public void WhenClickOnOnePBMPlan()
        {
            AccountsPage.Click_on_PBM_plan();
        }

        [Then(@"Check the Header of PBM Plan")]
        public void ThenCheckTheHeaderOfPBMPlan()
        {
            Accounts.CheckHeader_of_PBM();
        }

        [Then(@"check the selected items in the particular Account of PBM Plan")]
        public void ThenCheckTheSelectedItemsInTheParticularAccountOfPBMPlan()
        {
            Accounts.CheckAccounts_items_for_PBM();
        }
        [When(@"view selected is Specialty Provider")]
        public void WhenViewSelectedIsSpecialtyProvider()
        {
            Accounts.Click_on_Specialty_plan_view();
        }

        [When(@"click on one Specialty Provider plan")]
        public void WhenClickOnOneSpecialtyProviderPlan()
        {
            AccountsPage.Click_on_Specialty_plan();
        }

        [Then(@"Check the Header of Specialty Provider Plan")]
        public void ThenCheckTheHeaderOfSpecialtyProviderPlan()
        {
            Accounts.CheckHeader_of_Specialty();
        }

        [Then(@"check the selected items in the particular Account of Specialty Provider Plan")]
        public void ThenCheckTheSelectedItemsInTheParticularAccountOfSpecialtyProviderPlan()
        {
            Accounts.CheckAccounts_items_for_Specialty_view();
        }

        [When(@"view selected is State Medicaid")]
        public void WhenViewSelectedIsStateMedicaid()
        {
            Accounts.Click_on_State_Medicaid_plan_view();
        }

        [When(@"click on one State Medicaid plan")]
        public void WhenClickOnOneStateMedicaidPlan()
        {
            AccountsPage.Click_on_State_Medicaid_plan();
        }

        [Then(@"Check the Header of State Medicaid Plan")]
        public void ThenCheckTheHeaderOfStateMedicaidPlan()
        {
            Accounts.CheckHeader_of_State_Medicaid_plan();
        }

        [Then(@"check the selected items in the particular Account of State Medicaid Plan")]
        public void ThenCheckTheSelectedItemsInTheParticularAccountOfStateMedicaidPlan()
        {
            Accounts.CheckAccounts_items_for_State_Mediacaid_Plan();
        }
        [When(@"view selected is Tricare")]
        public void WhenViewSelectedIsTricare()
        {
            Accounts.Click_on_Tricare_plan_view();
        }

        [When(@"click on one Tricare plan")]
        public void WhenClickOnOneTricarePlan()
        {
            AccountsPage.Click_on_Tricare_plan();
        }

        [Then(@"Check the Header of Tricare Plan")]
        public void ThenCheckTheHeaderOfTricarePlan()
        {
            Accounts.CheckHeader_of_Tricare_plan();
        }

        [Then(@"check the selected items in the particular Account of Tricare Plan")]
        public void ThenCheckTheSelectedItemsInTheParticularAccountOfTricarePlan()
        {
            Accounts.CheckAccounts_items_for_Tricare_Plan();
        }

        [When(@"view selected is VA")]
        public void WhenViewSelectedIsVA()
        {
            Accounts.Click_on_VA_plan_view();
        }

        [When(@"click on one VA plan")]
        public void WhenClickOnOneVAPlan()
        {
            AccountsPage.Click_on_VA_plan();
        }

        [Then(@"Check the Header of VA Plan")]
        public void ThenCheckTheHeaderOfVAPlan()
        {
            Accounts.CheckHeader_of_VA_plan();
        }

        [Then(@"check the selected items in the particular Account of VA Plan")]
        public void ThenCheckTheSelectedItemsInTheParticularAccountOfVAPlan()
        {
            Accounts.CheckAccounts_items_for_VA_Plan();
        }

        [When(@"view selected is Medicare")]
        public void WhenViewSelectedIsMedicare()
        {
            Accounts.Click_on_Medicare_plan_view();
        }

        [When(@"click on Medicare plan")]
        public void WhenClickOnMedicarePlan()
        {
            AccountsPage.Click_on_Medicare_plan();
        }

        [Then(@"Check the Header of Medicare Plan")]
        public void ThenCheckTheHeaderOfMedicarePlan()
        {
            Accounts.CheckHeader_of_Medicare_plan();
        }

        [Then(@"check the selected items in the particular Account of Medicare Plan")]
        public void ThenCheckTheSelectedItemsInTheParticularAccountOfMedicarePlan()
        {
            Accounts.CheckAccounts_items_for_Commercial();
        }
        [When(@"view selected is My Accounts")]
        public void WhenViewSelectedIsMyAccounts()
        {
            Accounts.Click_on_My_Accounts_plan_view();
        }

        [When(@"click on My Accounts plan")]
        public void WhenClickOnMyAccountsPlan()
        {
            AccountsPage.Click_on_My_Accounts_plan();
        }

        [Then(@"Check the Header of My Accounts Plan")]
        public void ThenCheckTheHeaderOfMyAccountsPlan()
        {
            Accounts.CheckHeader_of_My_Accounts_plan();
        }

        [Then(@"check the selected items in the particular Account of My Accounts Plan")]
        public void ThenCheckTheSelectedItemsInTheParticularAccountOfMyAccountsPlan()
        {
            Accounts.CheckAccounts_items_for_Commercial();
        }

        [When(@"view selected is Parent Accounts")]
        public void WhenViewSelectedIsParentAccounts()
        {
            Accounts.Click_on_Parents_Accounts_plan_view();
        }

        [When(@"click on Parent Accounts plan")]
        public void WhenClickOnParentAccountsPlan()
        {
            AccountsPage.Click_on_Parents_Accounts_plan();
        }

        [Then(@"Check the Header of Parent Accounts Plan")]
        public void ThenCheckTheHeaderOfParentAccountsPlan()
        {
            Accounts.CheckHeader_of_Parents_Accounts_plan();
        }

        [Then(@"check the selected items in the particular Account of Parent Accounts Plan")]
        public void ThenCheckTheSelectedItemsInTheParticularAccountOfParentAccountsPlan()
        {
            Accounts.CheckAccounts_items_for_Commercial();
        }


        [Then(@"check the items for Employer View")]
        public void ThenCheckTheItemsForEmployerView()
        {
            Accounts.Select_Employer_channel();
            Accounts.CheckFiledsinAccountDetails_items();
            Accounts.Verify_Formulary_items();
            Accounts.Verify_pharmacy_srvices_items_Employer_channel();
            Accounts.Verify_plan_products_items();
            Accounts.Verify_address_items();
        }

        [Then(@"Check whether the Account belong medicare view or not")]
        public void ThenCheckWhetherTheAccountBelongMedicareViewOrNot()
        {
            Accounts.Vefrify_selected_Medicare_view();
        }

        [Then(@"check the items for Medicare View")]
        public void ThenCheckTheItemsForMedicareView()
        {
            Accounts.CheckFiledsinAccountDetails_items();
            Accounts.Verify_Formulary_items();
            Accounts.Verify_coverage_policy_items();
            Accounts.Verify_pharmacy_srvices_items();
            Accounts.Verify_plan_products_items();
            Accounts.Verify_Member_Of_items();
            Accounts.Verify_address_items();
        }

        [Then(@"Check whether the Account belong Parent Accounts view or not")]
        public void ThenCheckWhetherTheAccountBelongParentAccountsViewOrNot()
        {
            Accounts.Vefrify_selected_Parents_Accounts_view();
        }

        [Then(@"check the items for Parent Accounts View")]
        public void ThenCheckTheItemsForParentAccountsView()
        {
            Accounts.CheckFiledsinAccountDetails_items();
            Accounts.Verify_Formulary_items();
            Accounts.Verify_coverage_policy_items();
            Accounts.Verify_plan_products_items();
            Accounts.Verify_Specialty_Providers_items();
            Accounts.Verify_Member_Of_items();
            Accounts.Verify_member_items();
            Accounts.Verify_address_items();
        }

        [Then(@"Check whether the Account belong My Accounts view or not")]
        public void ThenCheckWhetherTheAccountBelongMyAccountsViewOrNot()
        {
            Accounts.Vefrify_selected_My_Accounts_view();
        }

        [Then(@"check the items for My Accounts View")]
        public void ThenCheckTheItemsForMyAccountsView()
        {
            Accounts.CheckFiledsinAccountDetails_items();
            Accounts.Verify_Formulary_items();
            Accounts.Verify_coverage_policy_items();
            Accounts.Verify_pharmacy_srvices_items();
            Accounts.Verify_plan_products_items();
            Accounts.Verify_Specialty_Providers_items();
            Accounts.Verify_Member_Of_items();
            Accounts.Verify_member_items();
            Accounts.Verify_address_items();
        }

        [Then(@"Check whether the Account belong PBM view or not")]
        public void ThenCheckWhetherTheAccountBelongPBMViewOrNot()
        {
            Accounts.Vefrify_selected_PBM_view();
        }

        [Then(@"check the items for PBM View")]
        public void ThenCheckTheItemsForPBMView()
        {
            Accounts.CheckFiledsinAccountDetails_items_PBM();
            Accounts.Verify_Formulary_items();
            Accounts.Verify_pharmacy_srvices_items_PBM();
            Accounts.Verify_member_items_PBM();
            Accounts.Verify_address_items();
        }
        [Then(@"Check whether the Account belong Specialty view or not")]
        public void ThenCheckWhetherTheAccountBelongSpecialtyViewOrNot()
        {
            Accounts.Vefrify_selected_Specialty_view();
        }

        [Then(@"check the items for Specialty View")]
        public void ThenCheckTheItemsForSpecialtyView()
        {
            Accounts.CheckFiledsinAccountDetails_items_SP();
            Accounts.Verify_Therapeutic_Classes_items_of_SP();
            Accounts.Verify_Accounts_items_of_SP();
            Accounts.Verify_address_items();
        }

        [Then(@"Check whether the Account belong State Medicaid view or not")]
        public void ThenCheckWhetherTheAccountBelongStateMedicaidViewOrNot()
        {
            Accounts.Vefrify_selected_State_Medicaid_view();
        }

        [Then(@"check the items for State Medicaid View")]
        public void ThenCheckTheItemsForStateMedicaidView()
        {
            Accounts.CheckFiledsinAccountDetails_items();
            Accounts.Verify_Formulary_items();
            Accounts.Verify_coverage_policy_items();
            Accounts.Verify_plan_products_items();
            Accounts.Verify_member_items();
            Accounts.Verify_address_items();
        }

        [Then(@"Check whether the Account belong Tricare view or not")]
        public void ThenCheckWhetherTheAccountBelongTricareViewOrNot()
        {
            Accounts.Vefrify_selected_Tricare_view();
        }

        [Then(@"check the items for Tricare View")]
        public void ThenCheckTheItemsForTricareView()
        {
            Accounts.CheckFiledsinAccountDetails_items();
            Accounts.Verify_Formulary_items();
            Accounts.Verify_plan_products_items();
            //Accounts.Verify_Specialty_Providers_items();
            Accounts.Verify_Member_Of_items();
            Accounts.Verify_member_items();
            Accounts.Verify_address_items();
        }
        [Then(@"Check whether the Account belong VA view or not")]
        public void ThenCheckWhetherTheAccountBelongVAViewOrNot()
        {
            Accounts.Vefrify_selected_VA_view();
        }

        [Then(@"check the items for VA View")]
        public void ThenCheckTheItemsForVAView()
        {
            Accounts.CheckFiledsinAccountDetails_items();
            Accounts.Verify_Formulary_items();
            Accounts.Verify_plan_products_items();
            //Accounts.Verify_Specialty_Providers_items();
            //Accounts.Verify_Member_Of_items();
            Accounts.Verify_member_items_VA();
            Accounts.Verify_address_items();
        }
        [Then(@"click on next button and Previous button")]
        public void ThenClickOnNextButtonAndPreviousButton()
        {
            Accounts.Vefrify_Next_Button();
        }

        [Then(@"click on each and every letter in the pagination")]
        public void ThenClickOnEachAndEveryLetterInThePagination()
        {
            Accounts.Vefrify_pagination();
        }
        [Then(@"Select a view")]
        public void ThenSelectAView()
        {
            Accounts.Click_on_commercial_view();
            AccountsPage.Click_on_commercial_plan();
        }

        [Then(@"check the hover functionality of the items")]
        public void ThenCheckTheHoverFunctionalityOfTheItems()
        {
            Accounts.Vefrify_Hover();
        }
        [Then(@"Select commercial view")]
        public void ThenSelectCommercialView()
        {
            DriverContext.Driver.SwitchTo().Frame("itarget");
            Accounts.Click_on_commercial_view();
            AccountsPage.Click_on_commercial_plan();
        }

        [Then(@"click on New Account Plan button")]
        public void ThenClickOnNewAccountPlanButton()
        {
            Accounts.Verify_Account_plan_btn();
        }

        [Then(@"Enter the mandatory fields and clicks on save")]
        public void ThenEnterTheMandatoryFieldsAndClicksOnSave()
        {
            Accounts.Verify_mandatory_fileds_in_Account_plans();
        }

        [Then(@"Delete the created plan")]
        public void ThenDeleteTheCreatedPlan()
        {
            Accounts.Delete_Created_Account_Plan();
        }

        [Then(@"close the My Accounts browser")]
        public void ThenCloseTheMyAccountsBrowser()
        {
            Accounts.Close_Browser();
        }

    }
}

