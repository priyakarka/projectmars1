Feature: EducationFeature

As a seller i want to add my Education details so that if people 
who are looking for some skills can can go through my details

Scenario: Adding a education details in the profile page 
	Given I logged into Turnup portal successfully
	When I add details in education   
	Then the education details should be saved sucessfully

Scenario: Editing a education details in the profile page 
	Given I logged into Turnup portal successfully
	When I edit details in education  
	Then the education details should be edited sucessfully

Scenario: Deleting a education details  in the profile page 
   Given  I logged into Turnup portal successfully
	When I delete details in education  
	Then the education details should be deleted sucessfully
