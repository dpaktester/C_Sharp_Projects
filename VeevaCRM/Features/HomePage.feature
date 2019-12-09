Feature: Veeva CRM Home Page Feature

@SmokeTest
Scenario: Checking the three graphs in the home page
Given user opens browser
Then user entered into the application by using valid login credentials
And user is on home page
When user hovers on graph One verify the message of graph one
And user hovers on graph two verify message of graph two
And user hovers on graph three verify message of graph three

@SmokeTest
Scenario: Checking the Refresh button
##Given user is on home page
When user clicks on Refresh button
Then the three graphs refreshed 

@SmokeTest
Scenario: Check the calender event
When user clicks on New Event button
Then Calendar opens
Then Enter the subject as Testing Calander Event
And Enter the location as Bangalore
And Enter the Start Date
And Enter the Start Time
And Enter the End Date
And Enter the End Time
Then Click on Save button
Then close the home browser