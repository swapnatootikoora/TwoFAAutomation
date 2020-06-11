Feature: TwoFA Feature Testing 
	In order to access my MOD account
	As a user of the MOD website
	I want to log into the website using TwoFA OTP authentications 


@TwoFAAPIValidateSerials 
Scenario Outline: Verify TWoFA API OTP Authentications
	Given User has valid token for valid credentials
	When User makes request with valid token and for "<Type>" and "<TypeValue>"
	Then User should get valid Code using valid serial
	Examples: 
	| Type  | TypeValue                        |
	| sms	| +447508155256                    |
	| email | swapna.tootikoora@netcompany.com |
	| hotp  | hotp                             |


	@TwoFAAPIValidateOTP
Scenario Outline: Verify the OTP received is correct or not
	Given User has valid token for valid credentials
	When User makes request with valid token and for "<Type>" and "<TypeValue>"
	Then User should get valid Code using valid serial
	Then Verify the OTP received is correct or not
	Examples: 
	| Type  | TypeValue                        |
	| sms   | +447508155256                    |
	| email | swapna.tootikoora@netcompany.com |
	

	@TwoFAUIValidAuthAppOptionPages 
Scenario Outline: Verify TwoFA authentication pages with Authapp
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Token Page	
	Examples:
	| user     | 
	| 2FATest6 |
	


	@TwoFAUIValidateSMSOptionPages 
Scenario Outline: Verify TwoFA authentication pages with SMS option
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Token Page	
	Examples:
	| user     | 
	| 2FATest2 | 
	



	@TwoFAUIValidateEmailOptionPages 
Scenario Outline: Verify TwoFA authentication pages with Email option
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Token Page	
	Examples:
	| user     | 
	| 2FATest5 |




	@TwoFAUIValidateLogin_viaSMSApp_AlreadyEnrolled
Scenario Outline: OTP on SMS app authentication for login in to the application
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Token Page	
	Then Enter received OTP 
	Then Click on Submit
	Then Verify user should reach to Dashboard Page
	Examples:
	| user     |   
	| 2FATest2 | 
	


	@TwoFAUIValidateLogin_viaEmailApp_AlreadyEnrolled
Scenario Outline: OTP on Email app authentication for login in to the application
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Token Page	
	Then Enter received OTP 
	Then Click on Submit
	Then Verify user should reach to Dashboard Page
	Examples:
	| user     | 
	| 2FATest5 | 
	

	@TwoFAUIValidateLogin_viaAuthApp_AlreadyEnrolled 
Scenario Outline: OTP on auth app authentication for login in to the application
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Token Page	
	Then Enter received OTP 
	Then Click on Submit
	Then Verify user should reach to Dashboard Page
	Examples:
	| user     |
	| 2FATest5 | 
	


	@TwoFAUIValidateLogin_OTP_Newuser_SYOPS
Scenario Outline: OTP on different  authentication options for login in to the application
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Two Factor Authentication screen according to "<AlreadyEnrolled>" condition
	Then Select the TwoFA Authentication Option "<Option>" and enter "<OptionValue>" if required
	Then Click Submit on Enrollment Page
	Then Verify Token Page	
	Then Enter received OTP 
	Then Click on Submit
	Then Verify Revised SyOPs signup screen and click SyOPs and JSP740 Checkbox as true
	Then Click Save Details on Syops signup page
	Then Verify the updated account renewal page
	Then Click on Continue
	Then Verify user should reach to Dashboard Page
	Examples:
	| user     | Option | OptionValue   | AlreadyEnrolled | 
	| 2FATest10 | SMS    | +447508155256 | No             |
	| 2FATest9 | Email  | swapna.tootikoora@netcompany.com | No             |  
	| 2FATest8 | authapp    | novalue | No  |




	@TwoFAUIValidateLogin_ResendOTP_EnrolledUser
Scenario Outline: Re-Send OTP on different options authentication for login in to the application
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Token Page	
	Then Click on ResendToken button to receive another token
	Then Enter received OTP 
	Then Click on Submit
	Then Verify user should reach to Dashboard Page
	Examples:
	| user     | Option  |
	| 2FATest5 | email   |
	| 2FATest3 | sms     |
	| 2FATest4 | AuthApp |



		@TwoFAUIValidateLogin_NewUser_SyOPS_ResendOTP 
Scenario Outline: Re-Send OTP on New User authentication for login in to the application
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Two Factor Authentication screen according to "<AlreadyEnrolled>" condition
	Then Select the TwoFA Authentication Option "<Option>" and enter "<OptionValue>" if required
	Then Click Submit on Enrollment Page
	Then Verify Token Page	
	Then Click on ResendToken button to receive another token
	Then Enter received OTP 
	Then Click on Submit
	Then Verify Revised SyOPs signup screen and click SyOPs and JSP740 Checkbox as true
	Then Click Save Details on Syops signup page
	Then Verify the updated account renewal page
	Then Click on Continue
	Then Verify user should reach to Dashboard Page
	Examples:
	| user     | Option  | OptionValue                      | AlreadyEnrolled |
	| 2FATest2 | SMS     | +447508155256                    | No              |
	| 2FATest6 | Email   | swapna.tootikoora@netcompany.com | No              |
	| 2FATest8 | authapp | novalue                          | No              |


	
	
	@TwoFAUIValidateSMSOptionPages_Change_the_phone_number
Scenario Outline: Verify TwoFA authentication pages with updated phone number
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Token Page	
	Then Click on ChangePhoneNumber button 
	Then Verify the email message
	#Then Verify the Secret Question Page
	#Then Enter the Security Answer with "<SecurityAnswer>"
	#Then Click on Submit
	#Then Enter the phone phone number with "<MobileNumber>"
	#Then Click on Save button
	#Then Verify the update phone number page
 
Examples:
	| user     | SecurityAnswer | MobileNumber  |
	| 2FATest2 | test           | +447979861841 |


	@TwoFAUISMSOptionPage_Change_the_phone_number
Scenario Outline: Verify TwoFA authentication pages with change phone number
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Two Factor Authentication screen according to "<AlreadyEnrolled>" condition
	Then Click on ChangeMyPhoneNumber button 
	#Then Verify the email notification message
	
Examples:
	| user     |    AlreadyEnrolled|
	| twofatest4 |        No              |
	
	


	






