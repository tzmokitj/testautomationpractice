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


	Scenario: User can create an account
	    Given User clicks on Sign in option
		And initiates a flow for creating an account
		And user enters all required personal details
		When user submits the sign up form
		Then user will be logged in
		And user's full name is displayed

		Scenario: User can update Last name
		Given User clicks on Sign in option
		And enters correct credentials
	    When clicks Sign in option
		And user clicks on my personal information button
		And updates Last name,  current password field
		And clicks on Save button
		Then user's full name is displayed



	