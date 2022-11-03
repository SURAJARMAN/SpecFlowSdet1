Feature: CreateORG

The user can login to vtiger with valid credential


Scenario: create org with valid fields 
Given launch the browser and enter the url
And in login page enter the url and password and click on login button
When in home page click on oraganisation link
And in organisation page click on organisation image 
And in create new org page enter the "<organisation>" name 
Then verify "<organisation>" is created or not

Examples: 
| organisation  |
| Myntra |
| Ajio   |

	
