Feature: APIActivityLogging
	When any actions changes are made in the system we want to log those changes accordingly

	#The system shall include equipment assignments in the patient activity log
@ActivityLogging @UserAuthentication @GetActivityLogsByPatientId
Scenario:GetActivityLogsByPatientId
	Given I create a new patient details
	And I create device assignment using device family "Trilogy_100"
	Then I verify GetActivityLogsByPatientId

@ActivityLogging @UserAuthentication @GetActivityLogsByPatientId
Scenario: GetActivityLogsByPatientId_UA_enabled_user
	Given I create a new patient details
	And I create device assignment using device family "Trilogy_200"
	When I verify GetActivityLogsByPatientId 
	Then I also verify the with user details for the interaction

@ActivityLogging @UserAuthentication @GetActivityLogsByPatientId @Unauthorized
Scenario:GetActivityLogsByPatientId_Clinician_user
	Given I login as clinician user
	And I create a new patient details
	And I create device assignment using device family "Trilogy_o2"
	Then I verify GetActivityLogsByPatientId with user details

#To-do this require to build new model & depended with ITherapyDeviceSecurityLogic for PIN and EncryptionLevel
@ActivityLogging @UserAuthentication @GetActivityLogsByPatientId @Unauthorized
Scenario:CreateAuditAndActivityLogForSendToMedia
	Given I login as clinician user
	And I create a new patient details
	And I create device assignment using device family "pinnacleplus"
	When I verify CreateAuditAndActivityLogForSendToMedia with user details
	Then I verify the GetActivityLogsByPatientId for send to media log

#Stod entry in activity log
@ActivityLogging @UserAuthentication @GetActivityLogsByPatientId
Scenario Template: GetActivityLogsByPatientId_Stod
	Given I am an authorized user
	When I create a new patient details
	And I update the patient information in "stod" to "21"
	And submit it to the system
	Then I verify GetActivityLogsByPatientId for stod