Feature: domainLoading
As a Domain User
I want to open domain page menus
So that I can confirm that the pages loaded

Background: 
Given I open the domain url

Scenario: Domain Pages loaded for the 'Buy' menu
When I click the 'buy' menu
Then the 'buy' page is loaded

Scenario: Domain Pages loaded for the 'Rent' menu
When I click the 'rent' menu
Then the 'rent' page is loaded

Scenario: Domain Pages loaded for the 'Sold' menu
When I click the 'sold' menu
Then the 'sold' page is loaded

Scenario: Domain Pages loaded for the 'New Home' menu
When I click the 'newhome' menu
Then the 'newhome' page is loaded