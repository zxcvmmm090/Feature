Feature: APIPatientFeature
API feature to GET & POST resquest/response from COE application endpoint(s)
so that i can create update search paients accordinlgy

#Patient Feature are with IPatientLogic exposed API methods
#Here are the sceanrios/methods are covered with respect to patient management features
#IPatientLogic.CreateOrUpdate() with forceupdate true and false + Duplicate patient + validation
#IPatientLogic.GetPatientById()
#IPatientLogic.GetPatientName()
#IPatientLogic.UpdatePatientStatus()
#IPatientLogic.Search()
#IPatientLogic.SearchPatientByDeviceSerialNumber()

@UserAuthentication @CreateOrUpdate
Scenario: CreateOrUpdate_Success
	Given I create a new patient details

@UserAuthentication @CreateOrUpdate
Scenario: CreateOrUpdate_MandatoryFields_Missing
	Given I try to create a new patient details without mandatory fields
	And I verify that patient is not created
	
#there is no DB resctriction, enhance with server level API in future
@UserAuthentication @CreateOrUpdate @ignore
Scenario: CreateOrUpdate_Exceed_Field_Length
	Given I try to create a new patient details exceeding fields values
	And I verify that patient is not created

@UserAuthentication @CreateOrUpdate @forceCreation
Scenario: CreateOrUpdate_forceCreation
	Given CreateOrUpdate with force

@UserAuthentication @GetPatientById
Scenario: GetPatientById
Given I create a new patient details
	Then I GetPatientById

#When there are no patient exists in the system/db
@UserAuthentication @GetPatientById
Scenario: GetPatientById_Alternative
	Given GetPatientById using non exist patient

@POST @CreatePatient @SearchPatient @GetPatientName @UserAuthentication
Scenario: Search
	Given I create a new patient details
	And I search for that patient using created patient name
	Then I verify API repsonse with contents patient information

@POST @UpdatePatient @Search @UserAuthentication
Scenario Template: CreateOrUpdate_Update
	Given I am an authorized user
	When I create a new patient details
	And I update the patient information in "<field>" to "<value>"
	And submit it to the system
	And I search for that patient using update patient name
	Then I verify API repsonse with contents patient information

Scenarios:
		| description           | field       | value           |
		| Patient ID            | PatientID   | 4KK014M@9       |
		| First Name            | FirstName   | Devdat          |
		| Last Name             | LastName    | Padikal         |
		| Birth Date            | BirthDate   | 01/01/2001      |
		| Gender                | Gender      | Female          |
		| Setup Date            | SetupDate   | 01/01/2022      |
		| External ID           | ExternalID  | 12              |
		| Phone Number          | PhoneNumber | (555)555-1212   |
		| Email                 | Email       | example@pic.com |
		| Address1              | Address1    | 123 PIC Street  |
		| Address2              | Address2    | Prana 21        |
		| City                  | City        | Bengaluru       |
		| State                 | State       | KA              |
		| Postal code           | Zip         | 560001          |
		| Country               | Country     | Bharat          |
		| Start Time Of The Day | stod        | 21              |

@CreatePatient @UpdatePatientStatus @UserAuthentication
Scenario Template: UpdatePatientStatus
	Given I am an authorized user
	When I create a new patient details
	And I will try to update patient status "<patientstatus>"
	Then I verify that patient status is updated

Scenarios:
		| patientstatus |
		| Active        |
		| Inactive      |

@CreatePatient @Duplicatepatient @UserAuthentication
Scenario: CreateOrUpdate_Duplicatepatient
	Given I create a patient details
	When I create another patient with same name details
	Then I verify the duplicate patient warning

@CreatePatient @SearchPatientByDeviceSerialNumber @UserAuthentication
Scenario: SearchPatientByDeviceSerialNumber
	Given I create a new patient details
	And I create a device assignment for the "NirvanaSeries"
	When I search for that patient using device serial number
	Then I verify that dsn search API repsonse with contents patient information

#when dsn is empty, it will create Generic device and verifying the dsn is empty and device name is Generic Empty
@CreatePatient @SearchPatientByDeviceSerialNumber @UserAuthentication
Scenario: SearchPatientByDeviceSerialNumber_Empty
	Given I create a new patient details
	And I create a device assignment for the ""
	When I search for that patient with empty device serial number
	Then I verify that patient dont have assigned any serial number

@SearchPatientByDeviceSerialNumber @UserAuthentication
Scenario: SearchPatientByDeviceSerialNumber_NoDeviceAssignment
	Given I verify that SearchPatientByDeviceSerialNumber contains no patient details