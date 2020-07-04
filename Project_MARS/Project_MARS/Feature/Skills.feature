Feature:4_Skills
	As a seller
	I would like to add my skills detail and view it on the profile page 

@Add_Skill
Scenario:1_Add a skill using valid input
	Given I click on the skills tab
	And I click on Add New button of skills tab
	And I enter the skill details <skill>,<skilllevel>
	Then I click on Add button of skills tab
	Then I validate that the new skill has been added successfully <skill>

	Examples:
		| skill     | skilllevel   |
		| Photoshop | Expert       |
		| Singing   | Intermediate |

Scenario:2_Edit an existing skill using valid input
	Given I click on the skills tab
	And I click on Edit button of skills tab
	And I edit the skill details <EditSkill>
	Then I click on the Update button of skills tab
	Then I validate that the skill has been edited successfully <EditSkill>

	Examples:
		| EditSkill |
		| Drawing   |

Scenario:3_Delete an existing skill
	Given I click on the skills tab
	And I click on Delete button of skills tab
	Then I validate that the skill has been deleted successfully