Feature: opens a browser, navigates to web and asserts

Scenario: navigate to pigu.lt and validate element
	Given open chrome browser and navigate to pigu.lt
	Then search fot product dešra
	Then add item to card
	Then validate item is in card