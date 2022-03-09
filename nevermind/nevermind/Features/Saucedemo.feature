Feature: saucedemo

@mytag
Scenario: Add two numbers
	Given  open chrome browser and navigate to saucedemo.com/
	And username is- standard_user-standard_user and password id-secret_sauce
	When select cheapest item form inventory
	Then add item to cart
	Then Navigate to cart
	Then Chechout
	Then Add Firdt name - , Last name - , ZipCode - 
	Then in checkout-step-two press Finish
	Then validate checkout-complete page message
