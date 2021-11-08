Feature: ProfileEducation
	As a Seller on Mars
	I would like to add my Profile Details such as Education.
	So that
	The people seeking for my profile fields which can show in the Education.

@addEducation1
Scenario: Adding of the Seller Profile Education with invalid records
	Given I login to the Trade Skills portal successfully
	And I navigate to the skiils page under Education tab
	And I click on the "Add New" button under "Education" tab
	When I enter the records for '<Country>', '<University>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	Then The display error popup message '<Message>' come out
	And The new row should be not updated as '<Country>', '<University>', '<Title>', '<Degree>', '<GraduationYear>' successfully

	Examples:
	| Country   | University | Title | Degree | Graduation Year | Message                     |
	|           |            |       |        |                 | Please enter all the fields |
	| Singapore | NUS        |       |        | 2020            | Please enter all the fields |

@addEducation2
Scenario: Adding of the Seller Profile Education with records
	Given I login to the Trade Skills portal successfully
	And I navigate to the skiils page under Education tab
	And I click on the "Add New" button under "Education" tab
	When I enter the records as '<Country>', '<University>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	Then The display popup message '<Message>' will come out
	And The new row should be added for '<Country>', '<University>', '<Title>', '<Degree>', '<GraduationYear>' successfully

	Examples:
	| Country   | University | Title | Degree           | GraduationYear | Message                  |
	| Singapore | NUS        | B.Sc  | Software-Testing | 2020           | Education has been added |

@addEducation3
Scenario: Adding of the Seller Profile Education with duplicate records
	Given I login to the Trade Skills portal successfully
	And I navigate to the skiils page under Education tab
	And I click on the "Add New" button under "Education" tab
	When I enter the details of '<Country>', '<University>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	And I click on the "Add New" button under "Education" tab
	And I enter the data in '<Country>', '<University>', '<Title>', '<Degree>', '<GraduationYear>'and click on Add button
	Then The display error popup message '<Message>' will come out
	And The new row should be not updated as '<Country>', '<University>', '<Title>', '<Degree>', '<GraduationYear>' successfully

	Examples:
	| Country  | University | Title     | Degree           | Graduation Year | Second Graduation Year | Message                            |
	| Japanese | Tokyo Uni  | Associate | Computer Science | 2020            | 2020                   | This information is already exist. |
	| Japanese | Tokyo Uni  | Associate | Computer Science | 2020            | 2021                   | Duplicated data                    |

@editEducation
Scenario: Editing of the Seller Profile Education with records
	Given I login to the Trade Skills portal successfully
	And I navigate to the skiils page under Education tab
	And I click on the pen icon
	When I edit the records in '<Country>', '<University>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	Then The new row should be updated in '<Country>', '<University>', '<Title>', '<Degree>', '<GraduationYear>' successfully
	And The display prompt message '<Message>' will appear

	Examples:
	| Country   | University | Title  | Degree           | GraduationYear | Message                  |
	| Singapore | SMU        | B.Tech | Software Testing | 2020           | Education has been added |

@deleteEducation
Scenario: Deleting of the Seller Profile Education
	Given I login to the Trade Skills portal successfully
	And I choose the education
	When I click on the delete icon
	Then the Education should have the deleted successfully