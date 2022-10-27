Feature: Store_Location

This Feature is for scenarios related to Store/ Locations

Scenario: Publish location and verify store location exists at store with same code and same name 
    Given user navigates to SR application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Login button of SR app
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Click on PF tab in SR
	And Click on add new PF button in SR
	Then Enter the new PF in SR '<SRCode>' and '<SRPFname>'
	When user search for the PF in SR'<SRCode>'
	And Open PF in edit page as per TD FourZeroZero
	And Save and close PF in SR
	And User navigate to Location tab
	And Click new location button
	Then Add new location in SR application '<SRLocationCode>' and '<SRLocationName>'
    Then search for a location '<SRLocationCode>'
	And Open location in edit page
	Then add Vendor to location
	And Link PF to Lcation <SRPFname>'
	Then Save and close location in SR
	And user navigates to next tab
	When user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When User clicks on Tab Print Format
	Then Click on the New Button
	And Enter '<code>' and '<PFname>'
	And User search for the PF '<code>'
	When user search and select the printformat code
	And Open PF and update as per TD FourZeroZero
	Then Save and close the PF
	When user click the StoreLocation tab
	And Add new location
	And Create New Scale Location '<LocationCode>' and '<LocationName>'
	Then Add the PF to location '<LocationCode>','<PFname>'
	Then publish the location to store '<LocationCode>'

	 Examples: 
	  | SRCode | SRPFname | SRLocationCode | SRLocationName | LocationCode | LocationName  | code | PFname |
	  |    53  |  Almond  | 93             | Butterhoney    | 93           | Butterhoney   | 53   | Almond |


Scenario: Publish location and verify store location exists at store with same code but different name 
    Given user navigates to SR application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Login button of SR app
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Click on PF tab in SR
	And Click on add new PF button in SR
	Then Enter the new PF in SR '<SRCode>' and '<SRPFname>'
	When user search for the PF in SR'<SRCode>'
	And Open PF in edit page as per TD FourZeroOne
	And Save and close PF in SR
	And User navigate to Location tab
	And Click new location button
	Then Add new location in SR application '<SRLocationCode>' and '<SRLocationName>'
    Then search for a location '<SRLocationCode>'
	And Open location in edit page
	Then add Vendor to location
	And Link PF to Lcation <SRPFname>'
	Then Save and close location in SR
	And user navigates to next tab
	When user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When User clicks on Tab Print Format
	Then Click on the New Button
	And Enter '<code>' and '<PFname>'
	And User search for the PF '<code>'
	When user search and select the printformat code
	And Open PF and update as per TD FourZeroZero
	Then Save and close the PF
	When user click the StoreLocation tab
	And Add new location
	And Create New Scale Location '<LocationCode>' and '<LocationName>'
	Then Add the PF to location '<LocationCode>','<PFname>'
	Then publish the location to store '<LocationCode>'

	 Examples: 
	  | SRCode | SRPFname | SRLocationCode | SRLocationName | LocationCode | LocationName  | code | PFname |
	  |    53  |  Almond  | 72             | Blueberry      | 72           | Nutella       | 53   | Almond |


Scenario: Publish location and verify store location exists at store with same name but different code 
    Given user navigates to SR application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Login button of SR app
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Click on PF tab in SR
	And Click on add new PF button in SR
	Then Enter the new PF in SR '<SRCode>' and '<SRPFname>'
	When user search for the PF in SR'<SRCode>'
	And Open PF in edit page as per TD FourZeroTwo
	And Save and close PF in SR
	And User navigate to Location tab
	And Click new location button
	Then Add new location in SR application '<SRLocationCode>' and '<SRLocationName>'
    Then search for a location '<SRLocationCode>'
	And Open location in edit page
	Then add Vendor to location
	And Link PF to Lcation <SRPFname>'
	Then Save and close location in SR
	And user navigates to next tab
	When user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When User clicks on Tab Print Format
	Then Click on the New Button
	And Enter '<code>' and '<PFname>'
	And User search for the PF '<code>'
	When user search and select the printformat code
	And Open PF and update as per TD FourZeroZero
	Then Save and close the PF
	When user click the StoreLocation tab
	And Add new location
	And Create New Scale Location '<LocationCode>' and '<LocationName>'
	Then Add the PF to location '<LocationCode>','<PFname>'
	Then publish the location to store '<LocationCode>'

	 Examples: 
	  | SRCode | SRPFname | SRLocationCode | SRLocationName | LocationCode | LocationName  | code | PFname |
	  | 53     | Almond   | 93             | Butterhoney    | 66           | Butterhoney   | 60   | Cashew |



Scenario: Publish location and verify store location exists at store with same name and code against different print formats
    Given user navigates to SR application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Login button of SR app
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Click on PF tab in SR
	And Click on add new PF button in SR
	Then Enter the new PF in SR '<SRCode1>' and '<SRPFname1>'
	When user search for the PF in SR'<SRCode1>'
	And Open PF in edit page as per TD FourZeroTwo
	And Save and close PF in SR
	Then Click on PF tab in SR
	And Click on add new PF button in SR
	Then Enter the new PF in SR '<SRCode2>' and '<SRPFname2>'
	When user search for the PF in SR'<SRCode2>'
	And Open PF in edit page as per TD FourZeroThree
	And Save and close PF in SR
	And User navigate to Location tab
	And Click new location button
	Then Add new location in SR application '<SRLocationCode1>' and '<SRLocationName1>'
    Then search for a location '<SRLocationCode1>'
	And Open location in edit page
	Then add Vendor to location
	And Link PF to Lcation <SRPFname1>'
	Then Save and close location in SR
	When Click new location button
	Then Add new location in SR application '<SRLocationCode2>' and '<SRLocationName2>'
    Then search for a location '<SRLocationCode2>'
	And Open location in edit page
	Then add Vendor to location
	And Link PF to Lcation <SRPFname2>'
	Then Save and close location in SR
	And user navigates to next tab
	When user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When User clicks on Tab Print Format
	Then Click on the New Button
	And Enter '<code>' and '<PFname>'
	And User search for the PF '<code>'
	When user search and select the printformat code
	And Open PF and update as per TD FourZeroThree
	Then Save and close the PF
	When user click the StoreLocation tab
	And Add new location
	And Create New Scale Location '<LocationCode>' and '<LocationName>'
	Then Add the PF to location '<LocationCode>','<PFname>'
	Then publish the location to store '<LocationCode>'

	 Examples: 
	  | SRCode1| SRPFname1| SRCode2| SRPFname2| SRLocationCode1 | SRLocationName1 | SRLocationCode2 | SRLocationName2 | LocationCode | LocationName | code | PFname   |
	  | 60     | Cashew   | 53     | Almond   | 87              | Strawberry      | 72              | Sandwich        | 87           | Sandwich     | 65   | Pastries |


Scenario: Publish location and verify store location does not exist at store with code or name or Print format 
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When User clicks on Tab Print Format
	Then Click on the New Button
	And Enter '<code>' and '<PFname>'
	And User search for the PF '<code>'
	When user search and select the printformat code
	And Open PF and update as per TD FourZeroFour
	Then Save and close the PF
	When user click the StoreLocation tab
	And Add new location
	And Create New Scale Location '<LocationCode>' and '<LocationName>'
	Then Add the PF to location '<LocationCode>','<PFname>'
	Then publish the location to store '<LocationCode>'

	 Examples: 
	  | LocationCode | LocationName  | code | PFname          |
	  | 95           | Vanilla Cream | 35   | White Chocolate |



Scenario: Publish location and verify queue messages
    Given user navigates to SR application
    When enter valid '<username>', '<hqpassword>'
    And Clicks on Login button of SR app
    When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Scale Configuration in the Search Box
    Then Scale Configuration Item should be displayed on the Menu
    When User Selects the Scale Configuration
    And User navigate to Location tab
    And Click new location button
    Then Add new location in SR application '<SRLocationCode1>' and '<SRLocationName1>'
    When Click new location button
    Then Add new location in SR application '<SRLocationCode3>' and '<SRLocationName3>'
    Then Click on PF tab in SR
    And Click on add new PF button in SR
    Then Enter the new PF in SR '<SRPFCode3>' and '<SRPFname3>'
    When user search for the PF in SR'<SRPFCode3>'
    And Open PF in edit page as per TD FourZeroFiveC
    And Save and close PF in SR
    And User navigate to Location tab
    Then search for a location '<SRLocationCode3>'
    And Open location in edit page
    Then add Vendor to location
    And Link PF to Lcation <SRPFname3>'
    Then Save and close location in SR
    When User navigate to Location tab
    And Click new location button
    Then Add new location in SR application '<SRLocationCode4>' and '<SRLocationName4>'
    Then Click on PF tab in SR
    And Click on add new PF button in SR
    Then Enter the new PF in SR '<SRPFCode4>' and '<SRPFname4>'
    When user search for the PF in SR'<SRPFCode4>'
    And Open PF in edit page as per TD FourZeroFiveD
    And Save and close PF in SR
    And User navigate to Location tab
    Then search for a location '<SRLocationCode4>'
    And Open location in edit page
    Then choose '<columnChoosed>' to yes
    Then add Vendor to location
    And Link PF to Lcation <SRPFname4>'
    Then Save and close location in SR
    And user navigates to next tab
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
    Then search for location code '<LocationCodeD>'
    Then select column chooser for column name '<columnChoosed>'
    And Edit '<columnChoosed>' to Yes
    Then remove '<columnChoosed>' from table
    When User clicks on Tab Print Format
    Then Click on the New Button
    And Enter '<codeD>' and '<PFnameD>'
    Then User should click on PF edit '<PFnameD>' ,'<codeD>'and set the Print Format fields  for FourZeroFiveD
    Then Add the PF to location '<LocationCodeD>','<PFnameD>'
    Then publish the location to store '<LocationCodeA>'
	When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Queue Manager in the Search Box
    Then User click on Queue Manager Item should be displayed on the Menu
    When user click the Scale queue
	And navigate to history tab
	Then click on view summary of the entry
	Then Validate queue message for location A
	Then close the view summary popup
	 When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Scale Configuration in the Search Box
    Then User click on Scale Configuration Item should be displayed on the Menu
    When user click the StoreLocation tab
    Then publish the location to store '<LocationCodeB>'
	When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Queue Manager in the Search Box
    Then User click on Queue Manager Item should be displayed on the Menu
    When user click the Scale queue
	And navigate to history tab
	Then click on view summary of the entry
	Then Validate queue message for location B
	Then close the view summary popup
	 When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Scale Configuration in the Search Box
    Then User click on Scale Configuration Item should be displayed on the Menu
    When user click the StoreLocation tab
    Then publish the location to store '<LocationCodeC>'
	When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Queue Manager in the Search Box
    Then User click on Queue Manager Item should be displayed on the Menu
    When user click the Scale queue
	And navigate to history tab
	Then click on view summary of the entry
	Then Validate queue message for location C
	Then close the view summary popup
	 When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Scale Configuration in the Search Box
    Then User click on Scale Configuration Item should be displayed on the Menu
    When user click the StoreLocation tab
    Then publish the location to store '<LocationCodeD>'
	When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Queue Manager in the Search Box
    Then User click on Queue Manager Item should be displayed on the Menu
    When user click the Scale queue
	And navigate to history tab
	Then click on view summary of the entry
	Then Validate queue message for location D
	Then close the view summary popup


     Examples:
    | SRLocationCode1 | SRLocationName1 | SRLocationCode3 | SRLocationName3 | SRPFCode3 | SRPFname3 | SRPFCode4 | SRPFname4 | SRLocationCode4 | SRLocationName4 | columnChoosed             | LocationCodeA | LocationCodeB | LocationCodeC | codeC | PFnameC | LocationCodeD | codeD | PFnameD |
    | 59              | Plum Cakes      | 51              | Burgers         | 60        | Cashew    | 53        | Almond    | 66              | Rainbow cake    | Send Department/Commodity | 59            | 93            | 51            | 60    | Cashew  | 66            | 53    | Almond  |


	 
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
    Given user navigates to SR application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Login button of SR app
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	Then User navigates to Location 
	And Verify that deleted location in HQ is not published and other item locations are published '<LocationName>' and '<LocationCode>'
	When user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When User clicks on Tab Print Format
	And User Search the PF and delete the PF from HQ '<code>' and '<PFname>'
	
	

	Examples:
    | LocationCode | LocationName     | code | PFname           |
    | 96           | Butter           | 16   | Organic butter   |

Scenario: Publish Scale item locations to selected stores
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	When user click the StoreLocation tab
	And Add new location
	Then Create multiple locations '<store1>','<store2>','<LocCode1>','<LocCode2>','<LocName1>','<LocName2>'
	When User clicks on Tab Print Format
	Then Click on the New Button
	And Enter '<code>' and '<PFname>'
	Then Add the PF to Multiple location '<store1>','<store2>','<LocCode1>','<LocCode2>','<PFname>','<code>'
	Then Publish the locations
	Examples:
    | store1       | store2          | LocCode1 | LocCode2 | LocName1  | LocName2  | code   | PFname     |
    | Crace (1501) | Kingston (1500) | 11       | 11       | Chocolate | Chocolate |  11    |   Coco     |

	Scenario:Import against a location, where  no locations are there to import from a store.
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
	 Then select a scale item
	 And Select stores/locations tab from item page
	 Then Select the location '<LocationName>' and click on import 
     And verify the Queue message'<Queue Message>'
	 Examples:
    | LocationCode | LocationName | Queue Message                           |
    | 76           | ButterBun    | Scale location not configured in store. |

	Scenario:Publish Scale item locations to selected stores in which location is soft deleted 
	 Given user navigates to HQ application
	 When enter valid '<username>', '<hqpassword>'
	 And Clicks on Log In button
	 When User clicks on the Left Menu
	 Then menu should be displayed
	 When User enters Scale Configuration in the Search Box
	 Then User click on Scale Configuration Item should be displayed on the Menu
	 When user click the StoreLocation tab

	 Scenario:Import all scale location data for selected item from the stores that are active. 
	 Given user navigates to HQ application
	 When enter valid '<username>', '<hqpassword>'
	 And Clicks on Log In button
	 When User clicks on the Left Menu
	 Then menu should be displayed
	 When User enters Scale Configuration in the Search Box
	 Then User click on Scale Configuration Item should be displayed on the Menu
	 When user click the StoreLocation tab
	 And Add new location
	Then Create multiple locations '<store1>','<store2>','<LocCode1>','<LocCode2>','<LocName1>','<LocName2>'
	When User clicks on the Left Menu
	 Then menu should be displayed
	 And User enters Store Maintenance in the Search Box
	 Then User click on Store Maintenance should be displayed on the Menu
	 Examples:
    | store1       | store2          | LocCode1 | LocCode2 | LocName1   | LocName2   | 
    | Crace (1501) | Kingston (1500) | 33       | 33       | Diary Milk | Diary Milk |  
    
