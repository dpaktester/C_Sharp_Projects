Feature: Veeva CRM Login Feature

@SmokeTest
Scenario Outline: Veeva CRM Login Test Scenario

Given user opens browser
Then user entered into the application by using valid login credentials
And user is on home page
When title of login page is Deepak Mahapatra at Veeva TechPartner 11
Then close the browser


Examples:
	| username | password |
	| dmahapatra@businessonetech.com.busone03  | Password@2019 |
 	