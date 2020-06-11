Feature: TwoFANegativeTests
	
	As a developer 
	I want to test the 2FA application  with invalid data
	So that I can verify the output

	@NegativeTest_TwoFAAPIInValidUser
Scenario Outline: Verify Email API Authentications with unknown username in realm
	Given User has valid token for valid credentials
	When User makes request with valid token and invalid user as "<User>"
	Then User should get error message
	Examples: 
	| User |
	|  swapnatootikoora     |

@NegativeTest_TwoFAUI_InValidCredentials
  Scenario Outline: Verify the TwoFA Application with invalid username
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<Invaliduser>"
	Then Click on Login
	And Verify the notification error in the login page
	Examples:
	| Invaliduser | 
	|   test  |   

	
@NegativeTest_TwoFAUI_InValidCredentials
Scenario Outline: Verify the TwoFA Application with invalid pwd
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then Enter Wrong password for "<Validuser>" user as "<wrongPsw>"
	Then Click on Login 
	And Verify the notification error in the login page
	Examples:
	| Validuser  | wrongPsw |
	| TwoFATest2 | xyz      |

	@NegativeTest_TwoFAUI_InValidOTP 
	Scenario Outline: Verify the TwoFA Application with invalid OTP
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Token Page
	Then Enter wrong OTP 
	Then Click on Submit
	And Verify the token notification error in the login page
	
	Examples:
	| user     | 
	| 2FATest1 | 


	@NegativeTest_TwoFAUI_InValidAuthOptions 
Scenario Outline: Verify TwoFA authentication pages with invalid option values
	Given Launch TwoFA Application and verify homescreen
	Then Verify Login page
	Then  Login with "<user>"
	Then Click on Login
	Then Verify Two Factor Authentication screen
	Then Select the TwoFA Authentication Option "<Option>" and enter "<OptionValue>" if required
	Then Click Submit on Enrollment Page
	Then Verify the notification error in the enrollment Page for "<Option>"
	Examples:
	| user       | Option | OptionValue   |
	| 2FATest6 | SMS    | 07508155256 |
	| 2FATest6 | SMS    | xyzhejt |
	| 2FATest6 | SMS    | 9767854345325654 |
	| 2FATest6 | email    | swapna.tootikooranetcompany.com |
	| 2FATest6 | email    | swapna.tootikoora@netcompanycom |
	| 2FATest6 | email    | 123432 |

	



	




