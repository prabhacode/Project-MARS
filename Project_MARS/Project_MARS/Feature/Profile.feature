Feature: Profile
	As a seller
	I would like to add my profile details and view it on the profile page

@mytag

Scenario: 01_Add Avalabilities and Description
	Given I have logged into the portal successfully <username>,<password>
	And I add Availability, Hours, Earn Target and Description <description>
	Then The Record should be added successfully
	Examples:
	| username                    | password    | description                              |
	| prabhabuoyant24.7@gmail.com | password123 | Hello! I am Prabha, I am a Test Analyst. |

Scenario: 02_Add a profile using valid input
	Given I have logged into the portal successfully <username>,<password>
	And I add Languages, Skills, Education and Certifications <language>,<languagelevel>,<skill>,<skilllevel>,<university>,<degree>,<country>,<title>,<eduyear>,<certificate>,<certifiedfrom>,<certyear>
	Then The Record should be added successfully
	Examples:
	| username                    | password    | language | languagelevel | skill     | skilllevel | university | degree | country | title  | eduyear | certificate | certifiedfrom | certyear |
	| prabhabuoyant24.7@gmail.com | password123 | English  | Basic         | Photoshop | Expert     | Sastra     | ECE    | India   | B.Tech | 2015    | Java        | WelTec        | 2018     |
	
	Scenario: 03_Edit the profile details with valid input
	Given I have logged into the portal successfully <username>,<password>
	And I edit Languages and Skills <Editlanguage>,<EditSkill>
	Then The Record should be edited successfully
	Examples:
	| username                    | password   | Editlanguage | EditSkill |
	| prabhabuoyant24.7@gmail.com | password123| Tamil        | Drawing   |

	Scenario: 04_Add a profile with null input
	Given I have logged into the portal successfully <username>,<password>
	And I add Languages, Skills, Education and Certifications with null input
	Then I should get the error message to the enter details
	Examples:
	| username                    | password    |
	| prabhabuoyant24.7@gmail.com | password123 |


#OTHER TEST CASES

#Scenario: I try to login with invalid credentials
#	Given I have entered the credentials 
#	And I click on the login button
#	Then I should get error message
#
#Scenario: Add Description upto 600 characters
#	Given I have logged into the portal successfully 
#	And I add description upto 600 characters and I press add
#	Then The description should be added sucessfully
#
#Scenario: Add Description more than 600 characters
#	Given I have logged into the portal successfully 
#	And I add description more than 600 characters and I press add
#	Then I should be able to see the error message
#
#Scenario: Check if the user is able to see the updated datas on the profile
#	Given I login to the mars portal
#	And I update my skill datas and the level
#	Then I should be able to see the updated skill on my profile
#
#Scenario: User cannot add Description with null values
#	Given I have logged into the portal successfully 
#	And I click on description and entered null value
#	Then I should be able to see the error message
#
#Scenario: User can delete the languages, skills, Education and Certificate added to the profile
#	Given I have logged into the portal successfully 
#	And I select the datas to be deleted and click on delete button
#	Then I should be able to delete the datas successfully
#
#Scenario: User directed to login page once the mars portal session is expired
#	Given I login to the mars portal and left unused for a long time
#	And I click on any option on the portal
#	Then I should be redirected to the mars login page to continue use the portal
