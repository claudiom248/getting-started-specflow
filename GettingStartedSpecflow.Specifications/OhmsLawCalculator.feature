Feature: OhmsLawCalculator
	In order to avoid silly mistakes
	As an electonic engineer idiot
	I want to be told the results of the first Ohm's law formula

@mytag
Scenario: Calculate voltage
	Given I have entered 150 into the calculator as value for current
	And I have entered 50 into the calculator as value for resistance
	When I press calculate
	Then the result should be 750 on the screen

Scenario: Calculate current
	Given I have entered 100 into the calculator as value for voltage
	And I have entered 25 into the calculator as value for resistance
	When I press calculate
	Then the result should be 4 on the screen

Scenario: Calculate resistance
	Given I have entered 100 into the calculator as value for voltage
	And I have entered 20 into the calculator as value for current
	When I press calculate
	Then the result should be 5 on the screen