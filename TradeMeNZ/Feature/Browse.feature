Feature: Browse

A short summary of the feature

@Browse
Scenario: Navigate to Antiques & collectables and verify the screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Antiques & collectables option
	Then I should be navigated to Antiques & collectables screen
	And the screen title should Antiques & collectables
	And the list of Antiques & collectables should be available

Scenario: Verifying the screen shows appropriate message when no result found in Antiques & collectables category
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Antiques & collectables option
	Then I should be navigated to Antiques & collectables screen
	And A message indicating No results found or similar should be displayed if there is no results in Antiques & collectables screen

Scenario: Verify the user can navigate back to home page from Antiques & collectables screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Antiques & collectables option
	Then I should be navigated to Antiques & collectables screen
	And  I navigate back to the homepage
    Then I should be on the Trade Me homepage
	
Scenario: Navigate to Art and verify the screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Art option
	Then I should be navigated to Art screen
	And the screen title should Art
	And the list of Art should be available

Scenario: Verifying the screen shows appropriate message when no result found in Art category
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Art option
	Then I should be navigated to Art screen
	And A message indicating No results found or similar should be displayed if there is no results in Art screen


Scenario: Verify the user can navigate back to home page from Art screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Art option
	Then I should be navigated to Art screen
	And  I navigate back to the homepage
    Then I should be on the Trade Me homepage

Scenario: Navigate to Baby gear and verify the screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Baby gear option
	Then I should be navigated to Baby gear screen
	And the screen title should Baby gear
	And the list of Baby gear should be available

Scenario: Verifying the screen shows appropriate message when no result found in Baby gear category
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Baby gear option
	Then I should be navigated to Baby gear screen
	And A message indicating No results found or similar should be displayed if there is no results in Baby gear screen

Scenario: Verify the user can navigate back to home page from Baby gear screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Baby gear option
	Then I should be navigated to Baby gear screen
	And  I navigate back to the homepage
    Then I should be on the Trade Me homepage

Scenario: Navigate to Books and verify the screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Books option
	Then I should be navigated to Books screen
	And the screen title should Books
	And the list of Books should be available

Scenario: Verifying the screen shows appropriate message when no result found in Books category
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Books option
	Then I should be navigated to Books screen
	And A message indicating No results found or similar should be displayed if there is no results in Books screen

Scenario: Verify the user can navigate back to home page from Books screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Books option
	Then I should be navigated to Books screen
	And  I navigate back to the homepage
    Then I should be on the Trade Me homepage

Scenario:  Navigate to Building & renovation and verify the screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Building & renovation option
	Then I should be navigated to Building & renovation screen
	And the screen title should Building & renovation
	And the list of Building & renovation should be available

Scenario: Verifying the screen shows appropriate message when no result found in Building & renovation category
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Building & renovation option
	Then I should be navigated to Building & renovation screen
	And A message indicating No results found or similar should be displayed if there is no results in Building & renovation screen

Scenario: Verify the user can navigate back to home page from Building & renovation screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Building & renovation option
	Then I should be navigated to Building & renovation screen
	And  I navigate back to the homepage
    Then I should be on the Trade Me homepage

Scenario:  Navigate to Business, farming & industry and verify the screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Business, farming & industry option
	Then I should be navigated to Business, farming & industry screen
	And the screen title should Business, farming & industry
	And the list of Business, farming & industry should be available

Scenario: Verifying the screen shows appropriate message when no result found in Business, farming & industry category
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Business, farming & industry option
	Then I should be navigated to Business, farming & industry screen
	And A message indicating No results found or similar should be displayed if there is no results in Business, farming & industry screen

Scenario: Verify the user can navigate back to home page from Business, farming & industry screen
	Given when i have navigated to trademe Home Page
	When I clicked on Browse option
	Then I clicked on Business, farming & industry option
	Then I should be navigated to Business, farming & industry screen
	And  I navigate back to the homepage
    Then I should be on the Trade Me homepage
