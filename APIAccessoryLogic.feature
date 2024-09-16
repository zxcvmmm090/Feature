Feature: APIAccessoryLogic
IAccessoryLogic.GetAccessoriesByPatientId
IAccessoryLogic.GetAccessory
IAccessoryLogic.GetAccessoryList
IAccessoryLogic.GetMaskModelByPatientId
IAccessoryLogic.UnAssign
IAccessoryLogic.Upsert

@ActivityLogging @UserAuthentication @GetActivityLogsByPatientId @Upsert_Accessoryy
Scenario: Upsert_Accessoryy
	Given Upsert accesory to patient
	Then I verify GetActivityLogsByPatientId for accesory assignemnt
	

@ActivityLogging @UserAuthentication @GetActivityLogsByPatientId @Unassign
Scenario: Unassign
	Given Upsert accesory to patient
	And I unassign the accessory	
	Then I verify GetActivityLogsByPatientId for unassigned assignemnt for accesory
	

@ActivityLogging @UserAuthentication @GetAccessory
	Scenario: GetAccessory
	Given : GetAccessory 

@ActivityLogging @UserAuthentication  @GetActivityLogsByPatientId @GetMaskModelByPatientId
Scenario: GetMaskModelByPatientId
	Given Upsert accesory to patient
	Then I verify the MaskModelByPatiendId for accessory assignment 

@ActivityLogging @UserAuthentication @GetAccessoriesByPatientID
Scenario: GetAccessoriesByPatientID
Given GetAccessoriesByPatientId