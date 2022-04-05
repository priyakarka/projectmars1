Feature: ProfileFeature

As a seller i want to add my profile details so that if people 
who are looking for some skills can can go through my details 



Scenario: Adding a languages details in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I add details in language   
	Then the  details should be saved sucessfully

Scenario: updating a languages details in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I update details in language  
	Then the language details should be updated sucessfully

Scenario: Deleting a languages details in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I delete details in language  
	Then the language details should be deleted sucessfully

		
Scenario: Adding a skills details  in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I add details in skills   
	Then the skills details should be saved sucessfully

Scenario: Editing a skills details  in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I edit details in skills  
	Then the skills details should be edited sucessfully

Scenario: Deleting a skills details  in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I delete details in Skills    
	Then the skills details should be deleted sucessfully


Scenario: Adding a education details in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I add details in education   
	Then the education details should be saved sucessfully

Scenario: Editing a education details in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I edit details in education  
	Then the education details should be edited sucessfully

Scenario: Deleting a education details  in the profile page 
   Given  I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I delete details in education  
	Then the education details should be deleted sucessfully

Scenario: Adding a certifications details in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I add details in certification   
	Then the certification details should be saved sucessfully

Scenario: Editing a certification details in the profile page 
	Given I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I edit details in certification  
	Then the certification details should be edited sucessfully

Scenario: Deleting a certification details  in the profile page 
   Given  I logged into Turnup portal successfully
	And I Navigate to profile page 
	When I delete details in certification  
	Then the certification details should be deleted sucessfully




	
	

