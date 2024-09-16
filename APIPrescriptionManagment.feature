Feature: APIPrescriptionManagment
	In order to safely create prescriptions
	as a user of the system
	I want to be able set and edit prescritions correctly

#Background: 
#Given I create a new patient details

@prescription @UserAuthentication
Scenario Outline: The system shall show the device that are assigned to patient in prescriptions 
	Given I am an authorized user
	 When I create a new patient details
	 And I create a device assignment using a valid device serial number from the device family "<device_family>"
	 And I access the prescription page which should contain all assigned devices to the patient
	Then it will display any devices for that patient in prescription with "<device_display_name>"
Scenarios: 
	| device_family | device_display_name |
	| NirvanaSeries | DreamStation        |
	| MerlinEFL     | BiPAP A40 EFL       |

@inprogress @prescriptionCreate @UserAuthentication @ignore @todo
Scenario: The system shall able to create prescription
	Given I am an authorized user
	 When I create a new patient details
	 And I create a device assignment using a valid device serial number from the device family "Helix"
	 And I can create a prescription for that device
	 Then prescription is saved

@inprogress @prescriptionUpdate @UserAuthentication @ignore @todo
Scenario: The system shall update prescription
	Given I am an authorized user
	 When I access a previously created patient record where patient having prescription
	 And I can update a prescription for that device
	 Then verify prescription is updated