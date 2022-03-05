Feature: The solution should have any http client implemented and should be able to send a http
request and assert received response.


Scenario: Should get and validate response from meteo
	Given the city name is Vilnius
	When Make request
	Then Validate that countryCode is LT