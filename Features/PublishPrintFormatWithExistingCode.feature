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
	#When Enter the Value of Print Name
	Then Publish the PF
	#When Enter the Value of Print Name
	Then Select the Store
	Then Delete the PF
	Then User is able to logout

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
	#And check the Manadatory & Fixed Width check box font2
	#And configure the row & Characters values Font2
	Then Save the font with data
	Then Close the font
	Then Delete the PF
	Then User is able to logout






    



