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

Scenario: Domain Pages loaded for the 'Commercial' menu
When I click the 'commercial' menu
Then the 'commercial' page is loaded

Scenario: Domain Pages loaded for the 'News' menu
When I click the 'news' menu
Then the 'news' page is loaded

Scenario: Domain Pages loaded for the 'Advice' menu
When I click the 'advice' menu
Then the 'advice' page is loaded

Scenario: Domain Pages loaded for the 'Agents' menu
When I click the 'agents' menu
Then the 'agents' page is loaded