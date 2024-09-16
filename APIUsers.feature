# use @UserAuthentication for any test/scenarios to authenticate with adminuser
# use @Unauthorized for any cases end with exception- This will re-login to the existing admin user for seamless test execution
# use @UnauthorizedUser for any cases end with exception- This will create new admin & login as admin user for seamless test execution

#IUserLogic all avaliable operational contractors (methods) are covered as scenarios in this feature file
#InsertAdminUser
#GetUserById
#InsertUser
#CheckDuplicateUserName
#GetMappedUserId-todo
#UpdateUser
#GetUsers
#GetUser
#Logout
#ForceLogout
#GetAllUserSession
#GetUserManagementWarningLevel
#CheckWhetherTwoAdminsExist

Feature: APIUsers
	As a COE user
	I want to be able to add And validate admin user records using IUserLogic interface
	in order to do my job efficiently

@authorization @UserAuthentication
Scenario: InsertAdminUser
	Given I created admin user
	And I login user details have user details
	Then the verify that user details will successfully be created

@authorization @UserAuthentication
Scenario: InsertUser
	Given I created clinician user
	And I change the password
	When try to login with the clinician user
	Then the verify that user details will successfully be created

@duplicateuser @CheckDuplicateUserName @UserAuthentication
Scenario: CheckDuplicateUserName
	Given I created admin user
	And try to authenticate default user
	When I create another user with same values as first admin user
	Then system to gave warning about the duplicate admin username

# dependency with migrated users to verify this api call, This will be cover as part of datamigration api tests
@authorization @GetMappedUserId @UserAuthentication @ignore
Scenario: GetMappedUserId
	Given I created clinician user
	And I change the password
	When try to login with the clinician user
	Then I will get the mapped user id and verify the user details mapped or not

@authorization @UpdateUser @UserAuthentication
Scenario: UpdateUser
	Given I created clinician user
	When I will try to update clinician user details
	Then I will verify the user details 

@authorization @GetUsers @UserAuthentication
Scenario: GetUsers
	Given I will verify the getusers list

@authorization @GetUserById @UserAuthentication
Scenario: GetUserById
	Given I will verify the GetUserById

@authorization @GetUser @UserAuthentication
Scenario: GetUser
	Given I will verify the GetUser

@authorization @Logout @UserAuthentication
Scenario: Logout
	Given I created clinician user
	And I change the password
	When try to login with the clinician user
	Then I will verify that user able to logout or not

@authorization @ForceLogout @UserAuthentication
Scenario: ForceLogout
	Given I created secondary admin
	And I login as admin
	Then I will verify that user able to forcelogout or not

@authorization @GetUserManagementWarningLevelAdmin @UserAuthentication
Scenario: GetUserManagementWarningLevel for admin
	Given I created admin user
	Then I will verify the proper warning message displayed

@authorization @GetUserManagementWarningLevelUser @UserAuthentication
Scenario: GetUserManagementWarningLevel for User
	Given I created clinician user
	Then I will verify the proper warning message displayed

@authorization @GetUserManagementWarningLevelUserAndAdmin @UserAuthentication
Scenario: GetUserManagementWarningLevel no warning
	Given I created secondary admin
	And I created clinician user
	Then I will verify the proper warning message displayed

@authorization @GetAllUserSession
Scenario: GetAllUserSession
	Given I created secondary admin
	And I login as admin
	When I will try to update user details
	Then I will verify the get all the user sessions

@authorization @GetAllUserSession @UserAuthentication @negative @Unauthorized
Scenario: GetAllUserSession_negative
	Given I created clinician user
	And I change the password
	When try to login with the clinician user
	Then I will try to the get all the user sessions then user get "Unauthorized" access

@authorization @CheckWhetherTwoAdminsExist @UserAuthentication
Scenario:CheckWhetherTwoAdminsExist_singleadmin
	Given I verify CheckWhetherTwoAdminsExist

@authorization @CheckWhetherTwoAdminsExist @UserAuthentication
Scenario:CheckWhetherTwoAdminsExist_multipleadmin
Given I created secondary admin
	And I login as admin
	When I verify CheckWhetherTwoAdminsExist

#updateuser from clinician should throws unauthorized exception
@authorization @UserAuthentication @negative @Unauthorized
Scenario:UpdateUser_Negative
	Given I created clinician user
	And I change the password
	And try to force authenticate clinical user
	When I try to UpdateUsers
	Then I verify "Unauthorized" exception message displays

#withoutAdmin clinical login should fail
#UA enabled only will checkaccess not for default domain user(default all access exists), hence this scenario not require negative check 
@authorization @CheckWhetherTwoAdminsExist @negative @UnauthorizedUser @ignore
Scenario:CheckWhetherTwoAdminsExist_noadmin_negative
	Given I verify CheckWhetherTwoAdminsExist
	And I created clinician user
	And I change the password
	When try to login with the clinician user when no admin exists
	Then I verify "Unauthorized" exception message displays

#UA enabled not done, checkaccess is not for default domain user(default all access exists), hence this scenario not consistent for negative check 
@authorization @createclinicianwithoutadmin @UnauthorizedUser @ignore
Scenario: AuthFailedUnknownError
	Given I check no admin exists
	And I created clinician user
	And I change the password
	When try to authenticate clinical user
	Then the verify that user ïs not logged in

@authorization @KeepAlive @UserAuthentication
Scenario: GetServerSessionKeepAlive
	Given I verify that user session is kept alive