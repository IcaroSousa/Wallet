Feature: CreateUserFeature
	As a system admin
	I want to be able to add a new user 
	If none user were found with the details passed as parameter

@valid @user
Scenario: Create a new user
	Given a user with name Icaro and surname Sousa	
	When try to save it at the database
	And it is not at the database yet
	Then it should be success
	
@invalid @user
Scenario: Create a user with invalid data
	Given a user with name Icaro and surname Sousa
	When try to save it at the database
	And it is at the database
	Then it should return invalid user details exception	