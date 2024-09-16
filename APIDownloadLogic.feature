Feature: APIDownloadLogic
This Api's is used get Firmware of devices and therapy download Time

@UserAuthentication @GetDownloadModelByInteractionId
Scenario: GetDownloadModelByInteractionId
Given I create a first patient details
And try to DownloadTherapyData "\Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt"
And GetDownloadModelByInteractionId

@UserAuthentication @GetPatientDownloadFirmware
Scenario Outline: GetPatientDownloadFirmware
Given I create a first patient details
And Download thearpy data  "\Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt"
And GetPatientDownloadFirmware of "<device>" and verify "<firmware>"
Scenarios: 
	| device      | firmware |
	| trilogy_100 | 14.2.04  |

@UserAuthentication @GetLastEdfTimestampUtc
Scenario: GetLastEdfTimestampUtc
Given I create a first patient details
And try to DownloadTherapyData "\Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt"
And GetLastEdfTimestampUtc "4/5/2023 6:55:34 AM"

@UserAuthentication @GetLatestAppSessionId
Scenario: GetLatestAppSessionId
Given I create a first patient details
And try to DownloadTherapyData "\Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt"
And GetLatestAppSessionId

@UserAuthentication @authorization @UnauthorizedUser @GetDeviceFirmwareVersion
Scenario: GetDeviceFirmwareVersion
Given I create a first patient details
And Download thearpy data  "\Philips.Tonic.APITests\TestData\RemstarData\Remstar.txt"
And GetDeviceFirmwareVersion and verify "B3.04f"

@UserAuthentication @GetFirmwareFromSerialNumber
Scenario: GetFirmwareFromSerialNumber
Given I create a first patient details
And Download thearpy data  "\Philips.Tonic.APITests\TestData\EDFData\Trilogy.txt"
And GetFirmwareFromSerialNumber


@UserAuthentication @GetFirmwareFromSerialNumberwithRemstar
Scenario Outline: GetFirmwareFromSerialNumber with Remstar
Given I create a first patient details
And Download thearpy data  "\Philips.Tonic.APITests\TestData\RemstarData\Remstar.txt"
And GetFirmwareFromSerialNumber verify "<firmware>"
Scenarios: 
| firmware |
| 3.04  |

