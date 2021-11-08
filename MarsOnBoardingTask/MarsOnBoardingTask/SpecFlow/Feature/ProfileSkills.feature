Feature: ProfileSkills
	As a Seller on Mars
	I would like to add my Profile Details such as Skills.
	So that
	The people seeking for my profile fields which can show in the Skills.

@addSkills1
Scenario: 1. Adding of the Seller Profile Skills with invalid records
	Given I login to the Trade Skills portal in Profile successfully
	And I navigate to the skiils page under Skills tab
	And I click on the Add New button under Skills tab
	When I click on Add button without records
	And The popup message '<Message>' will shown
	And I enter the data in '<Skill>' and click on Add button
	Then The invalid popup message '<Message>' will appear

	Examples:
	| Skill  | Level | Message                                 |
	|        |       | Please enter skill and experience level |
	| Appium |       | Please enter skill and experience level |

@addSkills2
Scenario: 2. Adding of the Seller Profile Skills with records
	Given I login to the Trade Skills portal in Profile successfully
	And I navigate to the skiils page under Skills tab
	And I click on the Add New button under Skills section
	When I enter the records of '<Skill>', '<Level>' and click on Add button
	And The display popup message '<Message>' will appear
	Then The new row should be added as in '<Skill>', '<Level>' successfully

	Examples:
	| Skill    | Level        | Message                                |
	| Selenium | Intermediate | Selenium has been added to your skills |

@addSkills3
Scenario: 3. Adding of the Seller Profile Skills with duplicate records
	Given I login to the Trade Skills portal in Profile successfully
	And I navigate to the skiils page under Skills tab
	And I click on Add New button under Skills tab
	When I enter the records '<Skill>', '<SecondLevel>' and click on Add button
	Then Invalid error popup message '<Message>' will appear
	
	Examples:
	| Skill    | Level        | SecondLevel | Message         |
	| Selenium | Intermediate | Expert      | Duplicated data |

@editSkills
Scenario: 4. Editing of the Seller Profile Skills with records
	Given I login to the Trade Skills portal in Profile successfully
	And I navigate to the skiils page under Skills tab
	And I click on edit pen icon under Skills tab
	When I edit the data in '<Skill>', '<Level>' and click on Add button
	And The display popup message '<Message>' will shown
	Then The new row should be edited as in '<Skill>', '<Level>' successfully

	Examples:
	| Skill    | Level  | Message                                  |
	| SpecFlow | Expert | SpecFlow has been updated to your skills |

@deleteSkills
Scenario: 5. Deleting of the Seller Profile Skill
	Given I login to the Trade Skills portal in Profile successfully
	And I navigate to the skiils page under Skills tab
	And I click on delete icon under Skills tab
	When The prompt message of '<Message>' will shown
	Then the Skill should have the deleted successfully

	Examples:
	| Message                   |
	| SpecFlow has been deleted |
