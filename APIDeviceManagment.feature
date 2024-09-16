Feature: APIDeviceManagment
	In order to manage devices associated with patients
	As a user of Tonic
	I want to be able to assign, unassign, and manage devices as they relate to patients

@POST @Upsert @deviceAssignment @UserAuthentication
Scenario: Upsert 
	Given I am an authorized user
	 When I create a new patient details
	  And I create a generic device
	  And assign the generic device to the patient
	 Then the device will be included in the device list for the patient

@POST @Unassign @deviceUnAssignment @UserAuthentication
Scenario:  Unassign
	Given I am an authorized user
	 When I create a new patient details
	  And I create a generic device
	  And assign the generic device to the patient
	  And unassign the generic device to the patient
	 Then the device will be not be included in the device list for the patient

@GetDevicesByPatientId @UserAuthentication	 
Scenario: GetDevicesByPatientId
Given GetDevicesByPatientId

@GetLastAssignedDeviceSerial @UserAuthentication	 
Scenario: GetLastAssignedDeviceSerial
Given GetLastAssignedDeviceSerial

@GetSerialNumbersByPatientId @UserAuthentication	 
Scenario: GetSerialNumbersByPatientId
Given GetSerialNumbersByPatientId

@GetDevicesByPatientIdOrderedByStartDate @UserAuthentication	 
Scenario: GetDevicesByPatientIdOrderedByStartDate
Given GetDevicesByPatientIdOrderedByStartDate

@GetPatientIdOnAssignedDevice @UserAuthentication	 
Scenario: GetPatientIdOnAssignedDevice
Given GetPatientIdOnAssignedDevice

@GetDeviceByInteractionId @UserAuthentication
Scenario Outline: GetDeviceByInteractionId
Given GetDeviceByInteractionId "<device_family>"
Scenarios: 
	| device_family | 
	| NirvanaSeries |
	
@GetDevicesByPatientIdAndSerialNo @UserAuthentication
Scenario Outline: GetDevicesByPatientIdAndSerialNo
Given GetDevicesByPatientIdAndSerialNo "<device_family>"
Scenarios: 
	| device_family | 
	| NirvanaSeries |


@IsCoughAssistDevice @UserAuthentication 
Scenario Outline: IsCoughAssistDevice
Given IsCoughAssistDevice "<dsn>"
Scenarios: 
	| description      | dsn            |
	| GeorgiaNumber    | 1024           |
	| GeorgiaNumber    | ~0013          |
	| GeorgiaNumber    | ~14359         |
	| GeorgiaNumber    | ~0021606       |
	| GeorgiaNumber    | ~0020025       |
	| NonGeorgiaNumber | 85644484845454 |


#Will be automated while automating IPrescriptionLogic cause current method is dependent on prescription modal
@ignore @IsSerialNumberCompatibleWithDevice @UserAuthentication @prescriptionUpdate 
Scenario Outline: IsSerialNumberCompatibleWithDevice
Given IsSerialNumberCompatibleWithDevice "<device_family>"
Scenarios: 
	| device_family | 
	| merlinn       |

@ValidateSerialNumberEx @UserAuthentication
Scenario Outline: ValidateSerialNumberEx
Given ValidateSerialNumberEx "<device_family>"
Scenarios: 
	| device_family | 
	| trilogy_o2    |



	