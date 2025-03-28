Feature: TradeMeHome

A short summary of the feature

@Home
Scenario: Validate verifying home page of trademe Application
	Given when i have navigated to trademe Home Page
	Then I verify if home page icon is loaded

Scenario: Verify Trademe Home screen links
	Given when i have navigated to trademe Home Page
	Then I should verify Login link is visible
	And I should verify Register link is visible
	And I should verify Browse link is available
	And I should verify Watchlist, Favourites, Start a listing,My Trade Me links are available
	And I should verify Search Bar is available

Scenario: Verify the main tabs in Trademe Home screen
	Given when i have navigated to trademe Home Page
	Then I should verify Marketplace tab is visible
	And I should verify Jobs tab is visible
	And I should verify Motors tab is visible
	And I should verify Property tab is visible
	And I should verify Services tab is visible

Scenario: Verifying Browse categories screen is opened on selecting Browse link
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I should verify Browse categories screen is opened
	And List of categories should be listed

