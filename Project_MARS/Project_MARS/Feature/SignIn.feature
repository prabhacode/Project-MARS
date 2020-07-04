Feature:1_SignIn
	As a user, I should be Signed In successfully

Background:
	Given Web browser is opened

@Login
Scenario: SignIn the portal
	Given I Navigate to the portal
	And I enter user credentials and press Login button <username>,<password>
	Then I validate that I logged into the portal successfully

	Examples:
		| username                    | password    |
		| prabhabuoyant24.7@gmail.com | password123 |