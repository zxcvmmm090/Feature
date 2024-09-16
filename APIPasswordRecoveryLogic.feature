Feature: APIPasswordRecoveryLogic
This Api's are used to users information and reset the user password
	
@authorization @UserAuthentication @GetUserInformationadmin
Scenario: GetUserInformation admin
Given I created admin user
And I login user details have user details
Then GetUserInformation and verify admin

@authorization @UserAuthentication @GetUserInformationclinician
Scenario: GetUserInformation clinician
Given I created clinician user
And I change the password
When try to login with the clinician user
Then GetUserInformation and verify clinician

 @ResetPwdWithUserQuestions
Scenario: ResetPwdWithUserQuestions
Given Create Admin with Question modal
And ResetPwdWithUserQuestions

 @ResetPwdWithUserQuestionswithsecondadmin
Scenario: ResetPwdWithUserQuestions with second admin
Given Create Admin with Question modal
And I created secondary admin with different question modal
When I verify CheckWhetherTwoAdminsExist
And  ResetPwdWithUserQuestions with second admin questions
