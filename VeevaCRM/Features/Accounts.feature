Feature: Veeva CRM Account Page Feature

@SmokeTest
Scenario: Checking the the Accounts page
Given user opens browser
Then user entered into the application by using valid login credentials
And user is on home page
Then Check if call is associated with the user or not
Then user clicks on my Accounts
And verifies the Title of the Page

@SmokeTest
Scenario: Checking the the veiw drop down in Accounts page
Given user is in Accounts Page
Then Check the view Drop down values against Requirement 

@SmokeTest
Scenario: checking the data for commercial channel
Given user is in Accounts Page
When view selected is commercial
And click on one commercial plan 
Then Check the Header
And check the selected items in the particular Account

@SmokeTest
Scenario: Check the data for Account Detail for commercial view
Given user is in Accounts Page
Then check the items in Account Detail

@SmokeTest
Scenario: Check weather the Account Details name is same as AccountName or not  for commercial view 
Given user is in Accounts Page
Then compare the accountname with the account Details 

@SmokeTest
Scenario: Check Formulary for commercial view
Given user is in Accounts Page
Then check the items in Formulary

@SmokeTest
Scenario: Check the Coverage Policy items for Commercial View
Given user is in Accounts Page
Then check the items in CovergePolicy

@SmokeTest
Scenario: Check the pharmacy Services items for Commercial View
Given user is in Accounts Page
Then check the items in pharmacy Services

@SmokeTest
Scenario: Check the Plan Products items for Commercial View
Given user is in Accounts Page
Then check the items in Plan Products

@SmokeTest
Scenario: Check the Specialty Providers items for Commercial View
Given user is in Accounts Page
Then check the items in Specialty Providers

@SmokeTest
Scenario: Check the (Member Of) of items for Commercial View
Given user is in Accounts Page
Then check the items in Member Of

@SmokeTest
Scenario: Check the Member items for Commercial View
Given user is in Accounts Page
Then check the items in Member

@SmokeTest
Scenario: Check the Address items for Commercial View
Given user is in Accounts Page
Then check the items in Address

@SmokeTest
Scenario: Check the Account Plan for Commercial View
Given user is in Accounts Page
Then check the items in Account Plan

@SmokeTest
Scenario: Check the View Hierarchy button for All View
Given user is in Accounts Page
Then check the View Hierarchy button

@SmokeTest
Scenario: checking the data for Employer channel
Given user is in Accounts Page
When view selected is Employer
And click on one Employer plan 
Then Check the Header of Employer Plan
And check the selected items in the particular Account of Employer Plan


@SmokeTest
Scenario: checking the data for PBM channel
Given user is in Accounts Page
When view selected is PBM
And click on one PBM plan 
Then Check the Header of PBM Plan
And check the selected items in the particular Account of PBM Plan

@SmokeTest
Scenario: checking the data for Specialty Provider channel
Given user is in Accounts Page
When view selected is Specialty Provider
And click on one Specialty Provider plan 
Then Check the Header of Specialty Provider Plan
And check the selected items in the particular Account of Specialty Provider Plan

@SmokeTest
Scenario: checking the data for State Medicaid channel
Given user is in Accounts Page
When view selected is State Medicaid
And click on one State Medicaid plan 
Then Check the Header of State Medicaid Plan
And check the selected items in the particular Account of State Medicaid Plan

@SmokeTest
Scenario: checking the data for Tricare channel
Given user is in Accounts Page
When view selected is Tricare
And click on one Tricare plan 
Then Check the Header of Tricare Plan
And check the selected items in the particular Account of Tricare Plan

@SmokeTest
Scenario: checking the data for VA channel
Given user is in Accounts Page
When view selected is VA
And click on one VA plan 
Then Check the Header of VA Plan
And check the selected items in the particular Account of VA Plan

@SmokeTest
Scenario: checking the data for Medicare channel
Given user is in Accounts Page
When view selected is Medicare
And click on Medicare plan
Then Check the Header of Medicare Plan
And check the selected items in the particular Account of Medicare Plan

@SmokeTest
Scenario: checking the data for My Accounts
Given user is in Accounts Page
When view selected is My Accounts
And click on My Accounts plan
Then Check the Header of My Accounts Plan
And check the selected items in the particular Account of My Accounts Plan


@SmokeTest
Scenario: checking the data for Parent Accounts
Given user is in Accounts Page
When view selected is Parent Accounts
And click on Parent Accounts plan 
Then Check the Header of Parent Accounts Plan
And check the selected items in the particular Account of Parent Accounts Plan


@SmokeTest
Scenario: Check the data for Employer view in all the items
Given user is in Accounts Page
Then check the items for Employer View

@SmokeTest
Scenario: Check the data for Medicare view in all the items
Given user is in Accounts Page
Then Check whether the Account belong medicare view or not
Then check the items for Medicare View

@SmokeTest
Scenario: Check the data for Parent Accounts view in all the items
Given user is in Accounts Page
Then Check whether the Account belong Parent Accounts view or not
Then check the items for Parent Accounts View

@SmokeTest
Scenario: Check the data for My Accounts view in all the items
Given user is in Accounts Page
Then Check whether the Account belong My Accounts view or not
Then check the items for My Accounts View


@SmokeTest
Scenario: Check the data for PBM view in all the items
Given user is in Accounts Page
Then Check whether the Account belong PBM view or not
Then check the items for PBM View

@SmokeTest
Scenario: Check the data for Specialty view in all the items
Given user is in Accounts Page
Then Check whether the Account belong Specialty view or not
Then check the items for Specialty View

@SmokeTest
Scenario: Check the data for State Medicaid view in all the items
Given user is in Accounts Page
Then Check whether the Account belong State Medicaid view or not
Then check the items for State Medicaid View

@SmokeTest
Scenario: Check the data for Tricare view in all the items
Given user is in Accounts Page
Then Check whether the Account belong Tricare view or not
Then check the items for Tricare View

@SmokeTest
Scenario: Check the data for VA view in all the items
Given user is in Accounts Page
Then Check whether the Account belong VA view or not
Then check the items for VA View

@SmokeTest
Scenario: Check the buttons in My Accounts screen
Given user is in Accounts Page
Then click on next button and Previous button
And click on each and every letter in the pagination

@SmokeTest
Scenario: Check the Hover of elements in My Accounts Page
Given user is in Accounts Page
Then Select a view
And check the hover functionality of the items
Then user clicks on my Accounts


@SmokeTest
Scenario: Check the Account Plan of elements in My Accounts Page
Given user is in Accounts Page
Then Select commercial view
And click on New Account Plan button
And Enter the mandatory fields and clicks on save
Then Delete the created plan
And close the My Accounts browser
