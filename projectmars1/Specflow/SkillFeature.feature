Feature: SkillsFeature

As a seller i want to add my skills details so that if people 
who are looking for some skills can can go through my details

@tag1
Scenario: Add a skills details  in the profile page 
	Given I logged into Turnup portal successfully
	When I add details in skills   
	Then the skills details should be saved sucessfully

Scenario: Editing a skills details  in the profile page 
	Given I logged into Turnup portal successfully
	When I edit details in skills  
	Then the skills details should be edited sucessfully

Scenario: Deleting a skills details  in the profile page 
	Given I logged into Turnup portal successfully
	When I delete details in Skills    
	Then the skills details should be deleted sucessfully
