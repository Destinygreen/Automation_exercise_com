Feature: Register_User

Background:
        Given Launch browser
	    When Navigate to url 'http://automationexercise.com'
	        
@Register_User
Scenario Outline: RegisterUser
	Then Verify that home page is visible successfully
	Then Click on 'Signup / Login' button
	Then Verify 'New User Signup!' is visible
	When Enter name and email address
	When Click 'Signup' button
	Then Verify that 'ENTER ACCOUNT INFORMATION' is visible
	Then Fill details: Title, Name, Email, Password, Date of birth
	Then Select checkbox 'Sign up for our newsletter!'
	   And Select checkbox 'Receive special offers from our partners!'
	Then Fill details: First name, Last name, Company, Address, Address2, Country, State, City, Zipcode, Mobile Number
	When Click 'Create Account button'
	Then Verify that 'ACCOUNT CREATED!' is visible
	   And Click 'Delete Account' button
	Then Verify that 'ACCOUNT DELETED!' is visible and click 'Continue' button




