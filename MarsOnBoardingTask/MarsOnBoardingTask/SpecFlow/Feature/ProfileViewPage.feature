Feature: ProfileViewPage
	Seller is able to see the seller’s details on the Profile page. 

@sellerprofileview
Scenario: 1. Seller is able to see the seller’s details on the Profile page. 
	Given I login to the Trade Skills portal of view successfully
	And I navigate to the main page and click on Programming & Tech
	When I navigate to the seller profile page
	Then The seller profile page should be updated successfully