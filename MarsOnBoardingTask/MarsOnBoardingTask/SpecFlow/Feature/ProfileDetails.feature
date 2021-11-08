Feature: ProfileDetails
	As a Seller on Mars
	I would like to add/edit my Profile Details such as Profile Name, Availability, Hours, Target.
	So that
	The people seeking for my profile fields which can show in the Name, Availability to work, Hours of woking, cost of the Earn Target.


@editprofilename1
Scenario: 1. Editing of the Seller Profile Name invalid records
	Given I login to the Trade Skills portal successfully
	And I click on the name expand icon
	When I clear on FirstName and LastName fields in the textbox
	Then Click on Save button and the auto popup message will appear

@editprofilename2
Scenario: 2. Editing of the Seller Profile Name with records
	Given I login to the Trade Skills portal successfully
	And I click on the name expand icon
	When I update the '<FirstName>', '<LastName>' and click on Save button
	Then the Fullname should be updated as '<FullName>', '<LastName>' successfully

	Examples:
	| FirstName | LastName | FullName |
	| Caleb     | Yo       | Caleb Yo |

@editAvailability
Scenario: 3. Edit the Availability in the Profile
	Given I login to the Trade Skills portal successfully
	And I click on the Availability pen icon
	When I select Availability of '<Availability>' from the dropdown list
	Then the availability should be updated as '<Availability>' successfully

	Examples:
	| Availability |
	| Full Time    |

@editHours
Scenario: 4. Edit the Hours in the Profile
	Given I login to the Trade Skills portal successfully
	And I click on the Hours pen icon
	When I select Hours of '<Hours>' from the dropdown list
	Then the Hours should be updated as '<Hours>' successfully

	Examples:
	| Hours     |
	| As needed |

@editEarnTarget
Scenario: 5. Edit the EarnTarget in the Profile
	Given I login to the Trade Skills portal successfully
	And I click on the Earn Target pen icon
	When I select EarnTarget of '<EarnTarget>' from the dropdown list
	Then the EarnTarget should be updated as '<EarnTarget>' successfully

	Examples:
	| EarnTarget                       |
	| More than $1000 per month        | 