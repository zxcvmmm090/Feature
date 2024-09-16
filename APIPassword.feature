Feature: APIPassword
	Password Api feature for updating and reseting the password

@GetPasswordRemainingDays @UserAuthentication
Scenario: GetPasswordRemainingDays
Given GetPasswordRemainingDays

@ChangeUsersCurrentPassword @UserAuthentication
Scenario: ChangeUsersCurrentPassword
Given I created clinician user
And ChangeUsersCurrentPassword

@ResetPassword @UserAuthentication
Scenario: ResetPassword
Given ResetPassword

@ResetPasswordWithUserQuestions @UserAuthentication
Scenario: ResetPasswordWithUserQuestions
Given ResetPasswordWithUserQuestions

@UserAuthentication @ChangeUsersCurrentPasswordForInvalidpasswordstatus
Scenario: ChangeUsersCurrentPassword_For Invalid password status
Given ChangeUsersCurrentPassword_Using Same old password

@UserAuthentication @authorization @ResetPasswordWitholdpassword
Scenario: ResetPassword_With old password
Given I created secondary admin
And I login as admin
When I verify CheckWhetherTwoAdminsExist
When I reset the password and verify


