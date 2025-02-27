using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TradeMeNZ.Pages;

namespace TradeMeNZ.Steps
{
    [Binding]
    class StepDefinitions
    {
        
        private HomePage _HomePage { get; }

        public StepDefinitions(HomePage HomePage)
        {
            _HomePage = HomePage;

        }
        [Given("when i have navigated to trademe Home Page")]
        public void GivenWhenIHaveNavigatedToTrademeHomePage()
        {
            _HomePage.NavigatetoTradeMe_Home();
        }

        [Then("I verify if home page icon is loaded")]
        public void ThenIVerifyIfHomePageIconIsLoaded()
        {
            throw new PendingStepException();
        }

    }
}