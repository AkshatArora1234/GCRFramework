Feature: PublishPrintFormatWithExistingCode
	Simple calculator for adding two numbers

@mytag
Scenario: Verify Print Format with Existing same code as Store
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	Then HQ homepage should be displayed
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Print Format
	Then Print Format Page should be displayed
	When user clicks on the Print Format Code 
	Then  the Selected Print Format Code should be displayed in tab
