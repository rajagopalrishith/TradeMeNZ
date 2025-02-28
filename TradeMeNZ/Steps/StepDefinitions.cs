using TradeMeNZ.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TradeMeNZ.steps
{
    [Binding]
    public class StepDefs
    {
        private HomePage HomePage { get; }

        public StepDefs(HomePage HomePage)
        {
            this.HomePage = HomePage;

        }


        [Given("when i have navigated to trademe Home Page")]
        public void GivenWhenIHaveNavigatedToTrademeHomePage()
        {
            HomePage.NavigatetoTradeMe_Home();
        }

        [Then("I verify if home page icon is loaded")]
        public void ThenIVerifyIfHomePageIconIsLoaded()
        {
            Assert.IsTrue(HomePage.TrademeLogoVisible(), "Logo Page is not displayed");
           
        }

    }
}