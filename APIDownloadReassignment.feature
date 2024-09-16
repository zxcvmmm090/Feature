Feature: APIDownloadReassignment
	DownloadReassignment feature for resassigning data from one patient to another

@UserAuthentication @ReassignDataDownload
Scenario: ReassignDataDownload
Given I create a first patient details
And try to DownloadTherapyData "\Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt"
And I create another patient
And ReassignDataDownload
Then I also verify the activity log

@UserAuthentication @GetReassignmentModelByInteractionId
Scenario: GetReassignmentModelByInteractionId
Given I create a first patient details
And try to DownloadTherapyData "\Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt"
And I create another patient
And I verify the GetReassignmentModelByInteractionId
Then I also verify the activity log

@UserAuthentication @GetReassignmentModelByInteractionId @todo
Scenario: GetReassignmentModelByInteractionId_Negative
Given I create a first patient details
And try to DownloadTherapyData "\Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt"
And I create another patient 
Then I try to GetReassignmentModelByInteractionId without ReassignDataDownload and verify that no interaction exists