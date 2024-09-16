Feature: APITherapyDeviceSecurity
	This Interface is used for providing encryption data of pinnacle devices

@UserAuthentication @GetEncryptedTherapyDevicePinModel
Scenario Outline: GetEncryptedTherapyDevicePinModel
Given I create a new patient details
And I create a device assignment for the "<device_family>"
Then GetEncryptedTherapyDevicePinModel 
Scenarios: 
	| device_family | 
	| PinnacleBase |
	| PinnaclePlus |
	
@UserAuthentication @GetTherapyDevicePINs
Scenario Outline: GetTherapyDevicePINs
Given I created clinician user	
And I change the password
And try to force authenticate clinical user
Given I create a new patient details
And I create a device assignment for the "<device_family>"
Then GetTherapyDevicePINs
And I logout as clinical user and login back as admin
Scenarios: 
	| device_family | 
	| PinnacleBase |
	| PinnaclePlus |