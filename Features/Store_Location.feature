Feature: Store_Location

This Feature is for scenarios related to Store/ Locations

Scenario: Publish location and verify at the store
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When user click the StoreLocation tab
	And Add new location for FourZeroZero '<locationcode>','<locationname>'

