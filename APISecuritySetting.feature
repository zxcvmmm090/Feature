Feature: APISecuritySetting
	
 
@UserAuthentication @GetSecuritySettingModel @ISecuritySettingLigic 
Scenario: GetSecuritySettingModel
When GetSecuritySettingModel
Then Verify the security settings 

@SaveSettings @ISecuritySettingLigic 
Scenario: SaveSettings
Then Verify the security settings 

# Here the saving the Security settings with values which are out of acceptable range
@SaveSecuritySettingwithoutofrangevalues @UserAuthentication
Scenario: SaveSecuritySetting with out of range values
Given Save security setting with out of range values

# Here the saving the Security settings as a clinician which should not be allowed
@SaveSettingsasaclinicianuser @UserAuthentication @Unauthorized
Scenario: SaveSettings as a clinician user
Given I created clinician user
And I change the password
And try to force authenticate clinical user
Then Save security settings as clinician "Unauthorized"

@SaveSecuritySettingwithdifferentcombinations
Scenario: Save Security Setting with different combinations
Given Save security settings with different combinations of parameters 
