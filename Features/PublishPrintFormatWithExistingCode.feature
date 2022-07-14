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

@mytag
Scenario: Publish PF to Store
Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Print Format
	Then Click on the New Button
	When Enter the CodeName and PrintFormat
	When Enter the Value of Print Name
	Then Click on Edit Button
	When Check the required text boxes
	Then Check the Content Symbol 
	When Click on Add Section
	Then Click on Font Dropdown
	Then Add Desc to font
	Then Save the font with data
	Then Close the font
	Then Publish the PF
	Then Select the Store
	
@mytag
Scenario: Edit PF
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Print Format
	Then Click on the New Button
	When Enter the CodeName and PrintFormat new
	When Enter the Value of Print Name OpenSanBiscuit1
	Then Click on Edit Button new PF
	When Check the required text boxes
	When Click on Add Section
	Then Click on Font Dropdown
	Then Add Desc to font
	And check the Manadatory & Fixed Width check box
	And configure the row & Characters values
	Then check a new nutritional Panel can be added to another section
	Then Click Support Basic Mode Header and Table
	Then Save the font with data
	Then Close the font
	




@mytag
Scenario: Publish PF existing with same name as in store
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
    When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Print Format
	And user search and select the printformat code
	Then user change the PF code and update the checkboxes
	And verify Content Symbol is automatically checked on checking Content
	And verify user can Change non nutritional section to the nutritional by adding a nutritional font and description
	And Save and close the PF
    Then select a scale item

    



    



