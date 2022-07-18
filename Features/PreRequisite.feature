Feature: PreRequisite

A short summary of the feature

@tag1
Scenario: Test Data 2.0 Font
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Config page
	When User clicks on Font New Button
	When Enter CodeName and Font Name
	Then click on save button

	
Scenario: Test Data 2.0 Nutritional Panel
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Config page
	When User clicks on Nutritional Panel New Button
	When Enter CodeName and Nutritional Panel
	Then click on save button

