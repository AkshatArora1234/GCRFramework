Feature: PublishPrintFormatWithExistingCode
	Simple calculator for adding two numbers

@mytag
Scenario: Verify Print Format with Existing same code as Store
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	#Then HQ homepage should be displayed
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Print Format
	Then Print Format Page should be displayed
	Then Click on the New Button
	#When User Enters the Code and PrintFormat
#	And User clicks on button Save
	Then Font should get saved and a '<confirmationMsg>' should be displayed for the same
	When user Looks Font table
	And Click on Edit Button
	When Change the PF name to Popcorn, also uncheck 'product life' only.Take any nutritional font and uncheck 'Nutritional' and check 'Enable copy'.
	When Check the required text boxes
	Then Check the Content Symbol 
	When User Enters the Code and PrintFormat1
	And User clicks on button Save
	When user clicks on the Print Format Code 
	Then  the Selected Print Format Code should be displayed in tab
	When User Deletes the font added to PF
	Then Verifies the Toast is displayed 
	And a message'Scale font <scale font name> is in use and cannot be deleted.' should be displayed
	When User Pubilsh the PF to a Second Store where PF exists with the same Code
	And Verify that at store, all the Tares, Content Symbols and Preset messages of HQ are published and the PF at store with same code is updated with values from HQ in Configuration.
	#When Enter the Value of Print Name
	When Searches for PrintFormat
	Then Delete the PF
	Then User is able to logout

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
	Then Click on the New Button
	When user enter new PF code and name and Publish PF
	And user search and select the printformat code
	Then user change the PF code and update the checkboxes
	And verify Content Symbol is automatically checked on checking Content
	And verify user can Change non nutritional section to the nutritional by adding a nutritional font and description
	And Add another new nutritional Panel to another section
	And Save and close the PF
    Then select a scale item
	And add the PF and ContentSymbol 
	And Save item
	Then navigate to the configuration page to edit the content symbol assigned to item
	And Delete the second panel added from the configuration page
	And Verify that the change is reflected in Item's scale tab
	And Publish the PF to a second store where PF exists with same name
    

    



    



