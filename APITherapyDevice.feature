Feature: APITherapyDevice
	

@GetDeviceCodes @UserAuthentication
Scenario: GetDeviceCodes
Given GetDeviceCodes

@GetTherapyDeviceByDeviceCode @UserAuthentication
Scenario: GetTherapyDeviceByDeviceCode
Given GetTherapyDeviceByDeviceCode

# This Method will be covered once Prescription modal is Completed
@ignore @GetTherapyDeviceById @UserAuthentication
Scenario: GetTherapyDeviceById
Given GetTherapyDeviceById
