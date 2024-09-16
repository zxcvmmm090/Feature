Feature: APIDownloadProcessor
	This Interface is used for downloading therapy data for patients

#need stream data for partial_sucess & notherapydata
#encrypted / opt-in data evo for edf
@UserAuthentication @DownloadTherapyData
Scenario Outline: DownloadTherapyData
Given I create a new patient details
And DownloadTherapyData "<DataPath>"
And I verify the interaction for the download
@ignore
Scenarios: 
| Description    | DataPath                                                    |
| Sucess_udfdata | \Philips.Tonic.APITests\TestData\UDFData\Pseries.txt        |
| Failure        | \Philips.Tonic.APITests\TestData\UDFData\PseriesFailure.txt |
| NoTherapyData  | \Philips.Tonic.APITests\TestData\UDFData\NoTherapyData.txt  |
| PartialSucess  | \Philips.Tonic.APITests\TestData\UDFData\PartialSucess.txt  |

@UserAuthentication @GetDownloadStatus
Scenario Outline: GetDownloadStatus
Given I create a new patient details
And DownloadTherapyData "<DataPath>"
Then GetDownloadStatus
Scenarios: 
| Description    | DataPath                                                    |
| Sucess_edfdata | \Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt        |
