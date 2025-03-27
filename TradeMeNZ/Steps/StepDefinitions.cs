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

        [Then("I click on Jobs tab")]
        public void ThenIClickOnJobsTab()
        {
            HomePage.NavigatetoJobsPage();
        }

        [Then("Verify that jobs page is open")]
        public void ThenVerifyThatJobsPageIsOpen()
        {        
            Assert.AreEqual(HomePage.JobsPageURL(), "https://www.tmsandbox.co.nz/a/jobs");

        }

        /*
        [Then("I click on trade me insurance")]
        public void ThenIClickOnTradeMeInsurance()
        {
            HomePage.NavigatetoTrademeInsurance();
        }

        [Then("Verify that insurance page is loaded")]
        public void ThenVerifyThatInsurancePageIsLoaded()
        {
            Assert.IsTrue(HomePage.InsuranceLogoDisplayed(), "Logo is not displayed");
            
        }
        */

        [Then("I click on Marketplace tab")]
        public void ThenIClickOnMarketplaceTab()
        {
            HomePage.NavMarketPlace();
            
        }

        [Then("Verify that Marketplace is loaded")]
        public void ThenVerifyThatMarketplaceIsLoaded()
        {
            Assert.IsTrue(HomePage.isMarketPlaceOpen(), "Page is not open");
        }

        [Then("click on Jobs Search Button")]
        public void ThenClickOnJobsSearchButton()
        {
            HomePage.JobsSearchButton();
        }

        [Then("Verify page displays the jobs")]
        public void ThenVerifyPageDisplaysTheJobs()
        {
            Assert.IsTrue(HomePage.DisplayJobs(), "Showing 51 results");
        }





    }
}