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

Scenario: Publish location and verify queue messages
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When user click the StoreLocation tab
	Then Add new location for FourZeroFiveA
	Then Add new location for FourZeroFiveB
	Then Add new location for FourZeroFiveC	
	Then search for location code '<LocationCodeC>'
	Then select column chooser for column name '<columnChoosed>'
	And Edit '<columnChoosed>' to Yes
	Then remove '<columnChoosed>' from table
	When User clicks on Tab Print Format
	Then Click on the New Button
	And Enter '<codeC>' and '<PFnameC>'
	Then User should click on PF edit '<PFnameC>' ,'<codeC>'and set the Print Format fields  for FourZeroFiveC
	Then Add the PF to location '<LocationCodeC>','<PFnameC>' 
	Then Add new location for FourZeroFiveD
	Then search for location code for '<LocationCodeD>'
#	Then select column chooser for column name '<columnChoosed>'
#	And Edit '<columnChoosed>' to Yes
#	Then remove '<columnChoosed>' from table
#	When User clicks on Tab Print Format
#	Then Click on the New Button
#	And Enter '<codeD>' and '<PFnameD>'
#	Then User should click on PF edit '<PFnameD>' ,'<codeD>'and set the Print Format fields  for FourZeroFiveD
#	Then Add the PF to location '<LocationCodeD>','<PFnameD>'

	  Examples: 
	| columnChoosed             | LocationCodeC | codeC | PFnameC | LocationCodeD | codeD | PFnameD |
	| Send Department/Commodity | 51            | 60    | Cashew  | 66            | 53    | Almond  |


	Scenario: Create location and verify that deleted location is not published
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When user click the StoreLocation tab
	And Add new location
	And Create New Scale Location '<LocationCode>' and '<LocationName>'
	When User clicks on Tab Print Format
	Then Click on the New Button
	And Enter '<code>' and '<PFname>'
	Then User should click on PF edit '<PFname>' ,'<code>'and set the Print Format fields
	Then Add the PF to location '<LocationCode>','<PFname>'
	When User click on left menu and select the item maintenance 
	Then user should select an item and add PF & location '<PFname>' ,'<LocationName>
	And User should navigate to config page and delete the location '<LocationCode>'
	Then Go to item location and publish '<LocationName>' 
#	And user navigates to SR application
#	When enter valid '<username>', '<hqpassword>'
#	And Clicks on Login button of SR app
#	When User clicks on the Left Menu
#	Then menu should be displayed
#	When User enters Scale Configuration in the Search Box
#	Then Scale Configuration Item should be displayed on the Menu
#	When User Selects the Scale Configuration
#	And Verify that deleted location in HQ is not published and other item locations are published '<LocationName>'
	
	

	Examples:
    | LocationCode | LocationName     | code | PFname           |
    | 96           | Butter           | 14   | Organic butter   |
