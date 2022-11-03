Feature: Vtiger

A User can login Vtiger with valid credential

Background: 
Given Open the browser
And    Enter the url

Scenario:Enter the Credential Login to Vtiger

	When in Login page enter valid username and valid password
	And click on login button
	Then verify home page is displayed or not
	
Scenario:Enter the username and password and Login to Vtiger
	
	When in Login page enter valid username "admin" and valid password "admin"
	And click on login button
	Then verify home page is displayed or not