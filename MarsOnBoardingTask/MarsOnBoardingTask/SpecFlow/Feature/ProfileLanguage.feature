Feature: ProfileLanguage
	As a Seller on Mars
	I would like to add my Profile Details such as Languages.
	So that
	The people seeking for my profile fields which can show in the Languages.

@addlanguage1
Scenario: 1. Adding of the Seller Profile Language with invalid records
	Given I login to the Trade Skills portal in the Profile successfully
	And I click on the Add New button under Languages tab
	When I click on the Add button without records
	And The display error popup message of '<Message>' will appear
	And I enter the data in level of '<Level>' and click on Add button
	And The display error popup message '<Message>' will appear
	And I enter the data in language of '<Language>' and click on Add button
	Then The display error popup message '<Message>' will appear
	
	Examples:
	| Language | Level            | Message                         |
	|          |                  | Please enter language and level |
	|          | Native/Bilingual | Please enter language and level |
	| Japanese |                  | Please enter language and level |

@addlanguage2
Scenario: 2. Adding of the Seller Profile Language with records
	Given I login to the Trade Skills portal in the Profile successfully
	And I click on the Add New button under Languages tab
	When I enter the data in language and level '<Language>', '<Level>' and click on Add button
	And The popup message of '<message>' will appear
	Then The new row should be added as '<Language>', '<Level>' successfully

	Examples:
	| Language | Level  | message                                   |
	| Japanese | Fluent | Japanese has been added to your languages |

@addlanguage3
Scenario: 3. Adding of the Seller Profile Language with duplicate records
	Given I login to the Trade Skills portal in the Profile successfully
	And I click on Add New button under Languages section
	When I enter the records in language,level '<Language>', '<SecondLevel>' and click on Add button
	And The error popup message of '<Message>' will shown
	And I enter the data in languageandlevel '<Language>', '<SecondLevel>' and click on Add button
	Then The display error popup message of'<Message>' will appear
	
	Examples:
	| Language | Level  | SecondLevel    | Message                                               |
	| Japanese | Fluent | Fluent         | This language is already exist in your language list. |
	| Japanese | Fluent | Conversational | Duplicated data                                       |

@editlanguage
Scenario: 4. Editing of the Seller Profile Language with records
	Given I login to the Trade Skills portal in the Profile successfully
	And I click on Edit of pen icon under Languages tab
	When edit the data in language and level '<Language>', '<Level>' and click on Add button
	And The popup message of '<Message>' will shown
	Then The new row should be edited as '<Language>', '<Level>' successfully

	Examples:
	| Language | Level            | Message                                    |
	| English  | Native/Bilingual | English has been updated to your languages |

@deletelanguage
Scenario: 5. Deleting of the Seller Profile Language
	Given I login to the Trade Skills portal in the Profile successfully
	And I click on delete icon under Languages tab
	When The prompt message of the '<Message>' will shown
	Then the Language should have the deleted successfully

	Examples:
	| Message                                      |
	| English has been deleted from your languages |
