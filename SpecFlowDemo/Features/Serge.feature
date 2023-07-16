Feature: Is Serge studied today
	Calculate if Serge actually studied


@tag1
Scenario: Serge have something to study
	Given Serge have computer
	When Task arrive
	Then Read study task 
	And at least for 1 hour
