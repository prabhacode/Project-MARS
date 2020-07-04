@ignore
Feature:5_ManualTestCases 
	As a user
	I would like to add my profile details and view it on the profile page

Scenario: Add a Language with null input
	Given I click on the Languages tab
	And I add Language with null input
	Then I should get the error message to enter the details

Scenario: Add a Skill with null input
	Given I click on the Skill tab
	And I add Skills with null input
	Then I should get the error message to enter the details

Scenario: Add Education with null input
	Given I click on the Education tab
	And I add Education with null input
	Then I should get the error message to enter the details

Scenario: Add Certifications with null input
	Given I click on the Certifications tab
	And I add Certifications with null input
	Then I should get the error message to enter the details

Scenario: 01_Add Availabilities
	Given I click on the profile tab
	And I add Availability, Hours, Earn Target
	Then The availabilities should be added successfully

Scenario: I try to login with invalid credentials
	Given I click on SignIn button
	And I enter the invalid credentials
	And I click on the login button
	Then I should get error message

Scenario: Add Description more than 600 characters
	Given I click on the profile tab
	And I add description more than 600 characters and I press add
	Then I should be able to see the error message

Scenario: User cannot add Description with null values
	Given I click on the profile tab
	And I click on description and entered null value
	Then I should be able to see the error message

Scenario: Check if the user is able to see the updated datas on the profile
	Given I click on SignIn button
	And I update my skill datas and the level
	Then I should be able to see the updated skill on my profile

Scenario: Delete an existing Education details
	Given I click on the Education tab
	And I click on Delete button of Education tab
	Then I validate that the Education has been deleted successfully

Scenario: Delete an existing Certifications
	Given I click on the Certifications tab
	And I click on Delete button of Certifications tab
	Then I validate that the Certification has been deleted successfully

Scenario: User directed to login page once the mars portal session is expired
	Given I click on the profile tab
	And I left the portal unused for a long time
	And I click on any option on the portal
	Then I should be redirected to the mars login page to continue use the portal