Feature: APIConfigureableSetting
This Configurable setting Api's are for updating and to get the default and updated settings

@GetDefaultConfigurableSettingsModel @IConfigureableSettingLogic
Scenario: GetDefaultConfigurableSettingsModel
Given GetDefaultConfigurableSettingsModel

@GetConfigurableSettingsModel @IConfigureableSettingLogic
Scenario: GetConfigurableSettingsModel
Given GetConfigurableSettingsModel
Then Verify the configureable settings

@SaveSettings @IConfigureableSettingLogic
Scenario: SaveSettings
Then Verify the configureable settings

#Here Report setting values are provide without Name textfield which in result it should not return other following report setting values
@SaveSettings_Negative
Scenario: SaveSettings_Negative
Given Save the Settings

@UserAuthentication @Unauthorized  @SaveSettingsupdatedconfigurablesettingasclinicianuser
Scenario: SaveSettings updated configurable setting as clinician user
Given I created clinician user
And I change the password
And try to force authenticate clinical user
Then Save the Settings

@UserAuthentication @SaveSettingsupdatedconfigurablesettingasadminuser
Scenario: SaveSettings updated configurable setting as admin user
Then Save the Settings
	