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

namespace TradeMeNZ.Steps
{
    [Binding]
    public class StepDefs
    {
        private HomePage HomePage { get; }

        public StepDefs(HomePage HomePage)
        {
            this.HomePage = HomePage;

        }


        [Given(@"when i have navigated to trademe Home Page")]
        public void GivenWhenIHaveNavigatedToTrademeHomePage()
        {
            HomePage.NavigatetoTradeMe_Home();
        }

        [Then(@"I verify if home page icon is loaded")]
        public void ThenIVerifyIfHomePageIconIsLoaded()
        {
            Assert.IsTrue(HomePage.TrademeLogoVisible(), "Logo Page is not displayed");
           
        }

        [Then(@"I should verify Login link is visible")]
        public void ThenIShouldVerifyLoginLinkIsVisible()
        {
           HomePage.LoginOptionVisible();
           Assert.IsTrue(HomePage.LoginOptionVisible(), "Login link is not visible");
            Console.WriteLine("Login Link Name: " + HomePage.LoginOptionVisible());
        }

        [Then(@"I should verify Register link is visible")]
        public void ThenIShouldVerifyRegisterLinkIsVisible()
        {
            HomePage.RegisterOptionVisible();
            Assert.IsTrue(HomePage.RegisterOptionVisible(), "Register link is not visible");
            Console.WriteLine("Register Link Name: " + HomePage.RegisterOptionVisible());
        }

        [Then(@"I should verify Browse link is available")]
        public void ThenIShouldVerifyBrowseLinkIsAvailable()
        {
            HomePage.BrowseDropDownVisible();
            Assert.IsTrue(HomePage.BrowseDropDownVisible(), "Browse DropDown is not visible");
            Console.WriteLine("Browse DropDown Name: " + HomePage.BrowseDropDownVisible());
        }

        [Then(@"I should verify Watchlist, Favourites, Start a listing,My Trade Me links are available")]
        public void ThenIShouldVerifyWatchlistFavouritesStartAListingMyTradeMeLinksAreAvailable()
        {
            HomePage.WatchListLinkVisible();
            Assert.IsTrue(HomePage.WatchListLinkVisible(), "WatchList Link is not visible");
            Console.WriteLine("WatchList Link Name: " + HomePage.WatchListLinkVisible());
            HomePage.FavouriteLinkVisible();
            Assert.IsTrue(HomePage.FavouriteLinkVisible(), "Favourite Link is not visible");
            Console.WriteLine("Favourite Link Name: " + HomePage.FavouriteLinkVisible());
            HomePage.StartAListingLinkVisible();
            Assert.IsTrue(HomePage.StartAListingLinkVisible(), "Start A Listing Link is not visible");
            Console.WriteLine("Start A Listing Link Name: " + HomePage.StartAListingLinkVisible());
            HomePage.MyTradeLinkVisible();
            Assert.IsTrue(HomePage.MyTradeLinkVisible(), "MyTrade Link is not visible");
            Console.WriteLine("MyTrade Link Name: " + HomePage.MyTradeLinkVisible());
        }

        [Then(@"I should verify Search Bar is available")]
        public void ThenIShouldVerifySearchBarIsAvailable()
        {
            HomePage.SearchBarLinkVisible();
            HomePage.SearchBarVisible();
        }

        [Then(@"I should verify Marketplace tab is visible")]
        public void ThenIShouldVerifyMarketplaceTabIsVisible()
        {
            HomePage.MarketPlacetabavailable();
        }

        [Then(@"I should verify Jobs tab is visible")]
        public void ThenIShouldVerifyJobsTabIsVisible()
        {
            HomePage.Jobstabtabavailable();
        }

        [Then(@"I should verify Motors tab is visible")]
        public void ThenIShouldVerifyMotorsTabIsVisible()
        {
            HomePage.Motorstabavailable();
        }

        [Then(@"I should verify Property tab is visible")]
        public void ThenIShouldVerifyPropertyTabIsVisible()
        {
            HomePage.Propertytabavailable();
        }

        [Then(@"I should verify Services tab is visible")]
        public void ThenIShouldVerifyServicesTabIsVisible()
        {
            HomePage.Servicestabavailable();
        }

        


    }
}