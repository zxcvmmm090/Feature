Feature: APIPatientDownloadsLogic
	Get the therapy downloads for a patients

#IPatientDownloadsLogic
@UserAuthentication @GetPatientDownloads
Scenario: GetPatientDownloads
	Given I create a new patient details
	And DownloadTherapyData "\Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt"
	Then I verify GetPatientDownloads

Scenario: GetPatientDownloads_Nodownloads
	Given I create a new patient details
	Then I verify that no downloads using GetPatientDownloads