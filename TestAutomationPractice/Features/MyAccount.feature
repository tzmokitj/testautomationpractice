Feature: MyAccount
	In order to complete orders
	As a user
	I want to be able to log in

@mytag
Scenario: User can log in
	Given User clicks on Sign in option
	And enters correct credentials
	When clicks Sign in option
	Then user will be logged in
	