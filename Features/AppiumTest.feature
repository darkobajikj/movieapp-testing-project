Feature: AppiumTestFeature
 

@ToDoApp
Scenario: Successful MobileApp Search
	Given I type in the search input
	When the result is shown
	Then I verify the Movie