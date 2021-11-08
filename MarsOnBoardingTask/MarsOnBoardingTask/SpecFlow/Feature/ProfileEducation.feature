Feature: ProfileEducation
	As a Seller on Mars
	I would like to add my Profile Details such as Education.
	So that
	The people seeking for my profile fields which can show in the Education.

@addEducation1
Scenario: 1. Adding of the Seller Profile Education with invalid records
	Given I login to the Trade Skills portal for education successfully
	And I navigate to the skiils page under Education tab
	And I click on the Add New button under Education tab
	When I enter the records for '<UniversityName>', '<CountryUniversity>', '<GraduationYear>' and click on Add button
	Then The display error popup message '<Message>' come out

	Examples:
	| UniversityName | CountryUniversity | Title | Degree | GraduationYear | Message                     |
	| NUS            | Singapore         |       |        | 2020           | Please enter all the fields |

@addEducation2
Scenario: 2. Adding of the Seller Profile Education with records
	Given I login to the Trade Skills portal for education successfully
	And I navigate to the skiils page under Education tab
	And I click on Add New button under Education tab
	When I enter the records as '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	Then The display popup message '<Message>' will come out
	And The new row should be added for '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' successfully

	Examples:
	| UniversityName | CountryUniversity | Title | Degree           | GraduationYear | Message                  |
	| NUS            | Singapore         | B.Sc  | Software-Testing | 2020           | Education has been added |

@addEducation3
Scenario: 3. Adding of the Seller Profile Education with duplicate records
	Given I login to the Trade Skills portal for education successfully
	And I navigate to the skiils page under Education tab
	And I click on Add New button under Education section
	When I enter the details of '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<SecondGraduationYear>' and click on Add button
	And The display error popup message '<Message>' will be come out
	And I enter the data in '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<SecondGraduationYear>'and click on Add button
	Then The display error popup message '<Message>' will come out

	Examples:
	| UniversityName | CountryUniversity | Title | Degree           | GraduationYear | SecondGraduationYear | Message                            |
	| NUS            | Singapore         | B.Sc  | Software-Testing | 2020           | 2020                 | This information is already exist. |
	| NUS            | Singapore         | B.Sc  | Software-Testing | 2020           | 2021                 | Duplicated data                    |

@editEducation
Scenario: 4. Editing of the Seller Profile Education with records
	Given I login to the Trade Skills portal for education successfully
	And I navigate to the skiils page under Education tab
	And I click on the Education pen icon
	When I edit the records in '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	And The display prompt message '<Message>' will shown
	Then The new row should be updated in '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' successfully

	Examples:
	| UniversityName | CountryUniversity | Title  | Degree           | GraduationYear | Message                   |
	| SMU            | Singapore         | B.Tech | Software Testing | 2021           | Education as been updated |

@deleteEducation
Scenario: 5. Deleting of the Seller Profile Education
	Given I login to the Trade Skills portal for education successfully
	And I navigate to the skiils page under Education tab
	And I click on delete icon under Education tab
	When The prompt message of the '<Message>' will be shown
	Then the Education should have the deleted successfully

	Examples:
	| Message                              |
	| Education entry successfully removed |