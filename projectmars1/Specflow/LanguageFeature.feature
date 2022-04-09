Feature: LanguageFeature

As a seller i want to add my language details so that if people 
who are looking for some skills can can go through my details 



Scenario Outline: (1) add a language details in the profile page 
	Given I logged into Turnup portal successfully
	When I add '<Language>' details in language   
	Then the '<Language>' and level details should be successfully 

	Examples: 
	| Language |
	| Tamil    |
	
	
Scenario Outline: (2) Editing a languages details in the profile page 
	Given I logged into Turnup portal successfully
	When I update '<Language>' details on an existing language  
	Then the language details should have the updated '<Language>'
	
	Examples: 
	| Language |
	| Telugu   |

Scenario Outline: (3) Deleting a languages details in the profile page 
	Given I logged into Turnup portal successfully
	When I delete '<Language>' details of updated language  
	Then the language details should have  deleted '<Language>'

		








	
	

