Feature: APIUserSecurityQuestionsLogic
	IUserSecurityQuestionsLogic API interface methods

	#@UserAuthentication - using this tag will create new admin and login to the application
	#use @Unauthorized for any cases end with exception- This will re-login to the existing admin user for seamless test execution

	#IUserSecurityQuestionsLogic all avaliable operational contractors (methods) are covered as scenarios in this feature file
	#SaveUserQuestions
	#DeleteUserQuestions

@IUserSecurityQuestionsLogic @SaveUserQuestions @UserAuthentication
Scenario:SaveUserQuestions
Given I created admin user
Then I verify that the SaveUserQuestions

@IUserSecurityQuestionsLogic @SaveUserQuestions @negative @Unauthorized @UserAuthentication
Scenario:SaveUserQuestions_negative
Given I created clinician user
	And I change the password
	And try to force authenticate clinical user
Then I will try to the SaveUserQuestions then user get "Unauthorized" access

@IUserSecurityQuestionsLogic @UserAuthentication @Unauthorized
Scenario:NonAdmin user should not have security questions
Given I created clinician user
And I change the password
	When try to login with the clinician user
Then I verify that user dont have security questions

#Delete the existing user question & update with new uesr question then savequestions
@IUserSecurityQuestionsLogic @SaveUserQuestions @UserAuthentication @alternative
Scenario:SaveUserQuestions_alternative
Given I verify that updated question and answers are updated using SaveUserQuestions

#Try to SaveUserQuestions second time for admin without
@IUserSecurityQuestionsLogic @SaveUserQuestions @negative @Unauthorized @UserAuthentication
Scenario:SaveUserQuestions_negative_second_save
Given I verify second time SaveUserQuestions is not saved
