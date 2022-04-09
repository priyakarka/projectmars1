Feature: CertificationFeature

As a seller i want to add my certification details so that if people 
who are looking for some skills can can go through my details 




Scenario: Adding a certifications details in the profile page 
	Given I logged into Turnup portal successfully
	When I add details in certification   
	Then the certification details should be saved sucessfully

Scenario: Editing a certification details in the profile page 
	Given I logged into Turnup portal successfully
	When I edit details in certification  
	Then the certification details should be edited sucessfully

Scenario: Deleting a certification details  in the profile page 
   Given  I logged into Turnup portal successfully
	When I delete details in certification  
	Then the certification details should be deleted sucessfully

