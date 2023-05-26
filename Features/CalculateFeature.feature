Feature: CalculateFeature

Calculation operations
	
@smoke
Scenario: Addition of 2 numbers
Given User visits Calculator web page
When User clicks on number '4'
And User clicks on '+'
And User clicks on number '5'
Then User verifies Result '9'

