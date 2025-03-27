Feature: TradeMeHome

A short summary of the feature

@Home
Scenario: Validate verifying home page of trademe Application
	Given when i have navigated to trademe Home Page
	Then I verify if home page icon is loaded


@Home
Scenario: Validate trade me jobs page from the home page
	Given when i have navigated to trademe Home Page
	Then I click on Jobs tab
	Then Verify that jobs page is open

@Home
Scenario: Validate the we can navigate to Trademe Insurance page
	Given when i have navigated to trademe Home Page
	Then I click on trade me insurance
	Then Verify that insurance page is loaded

@Home
Scenario: Validate marketplace page is opening
	Given when i have navigated to trademe Home Page
	Then I click on Marketplace tab
	And Verify that Marketplace is loaded

@Jobs
Scenario: Validate search page showing while clicking on search button with empty fields
	Given when i have navigated to trademe Home Page
	Then I click on Jobs tab
	Then click on Jobs Search Button
	Then Verify page displays the jobs
	Then testing git working
	Then testing again git
	Then testing git again and again








