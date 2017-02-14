using System;
using TechTalk.SpecFlow;
using domainLoadValidation.PageObjects;
namespace domainLoadValidation.StepDefinitions
{
    [Binding]
    public class DomainLoadingSteps
    {
        DomainHomePage homePage=new DomainHomePage();

        [Given(@"I open the domain url")]
        public void GivenIOpenTheDomainUrl()
        {

            homePage.OpenDomainInChrome();

        }
        
        [When(@"I click the '(.*)' menu")]
        public void WhenIClickTheMenu(string menutoselect)
        {
            homePage.ClickMenu(menutoselect);
        }
        
        [Then(@"the '(.*)' page is loaded")]
        public void ThenThePageIsLoaded(string menuselected)
        {
            
            homePage.PageLoaded(menuselected);
        }
    }
}
