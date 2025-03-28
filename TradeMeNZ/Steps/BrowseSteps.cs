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
    public class BrowseSteps
    {
        private HomePage HomePage { get; }
        private BrowsePage BrowsePage { get; set; }

        public BrowseSteps(HomePage HomePage, BrowsePage BrowsePage) 
        {
            this.HomePage = HomePage;
            this.BrowsePage = BrowsePage;
        }

        [When(@"I clicked on Browse option")]
        public void WhenIClickedOnBrowseOption()
        {
            BrowsePage.ClickBrowsebutton();
            HomePage.Waitfor5seconds();
        }

        [Then(@"I should verify Browse categories screen is opened")]
        public void ThenIShouldVerifyBrowseCategoriesScreenIsOpened()
        {
            string expectedTitle = "Browse Marketplace";
            string actualTitle = BrowsePage.BrowseCategoryScreen();
            Assert.IsTrue(actualTitle.Contains(expectedTitle), "Browse categories page is not displayed");
        }

        [Then(@"List of categories should be listed")]
        public void ThenListOfCategoriesShouldBeListed()
        {
            Assert.IsTrue(BrowsePage.BrowseListScreen(), "Categories list is not displayed");
        }

        [Then("I clicked on Antiques & collectables option")]
        public void ThenIClickedOnAntiquesCollectablesOption()
        {
            BrowsePage.AntiquescollectablesSelect();
            HomePage.Waitfor5seconds();
        }

        [Then(@"I should be navigated to Antiques & collectables screen")]
        public void ThenIShouldBeNavigatedToAntiquesCollectablesScreen()
        {
            BrowsePage.AntiquescollectablesOpened();
            
        }

        [Then(@"the screen title should Antiques & collectables")]
        public void ThenTheScreenTitleShouldAntiquesCollectables()
        {
            string expectedlabel = "Antiques & collectables";
            string actuallabel = BrowsePage.VerifyAntiqueCollectionTitle();
            Assert.AreEqual(expectedlabel, actuallabel, "The screen title is Antiques & collectables");
        }

        [Then(@"the list of Antiques & collectables should be available")]
        public void ThenTheListOfAntiquesCollectablesShouldBeAvailable()
        {

            Assert.IsTrue(BrowsePage.AntiqueCollectionResult(), "Antiques & Collectables items list is not displayed");
           // bool recordCount = BrowsePage.AntiqueCollectionList();
           // Assert.Greater(recordCount, 0, "No records found in Antiques & Collectables results screen");
           BrowsePage.AntiqueCollectionResult();
            //BrowsePage.AntiqueCollectionList();
            HomePage.Waitfor5seconds();
        }

     //   [Then(@"A message indicating No results found or similar should be displayed")]
       // public void ThenAMessageIndicatingNoResultsFoundOrSimilarShouldBeDisplayed()
       // {
           // if (!BrowsePage.AntiqueCollectionResult())
          //  {
             //   string expectedMessage = "No results found";
             //   string actualMessage = BrowsePage.NoResultsFoundMessage();
            //    Assert.IsTrue(actualMessage.Contains(expectedMessage), "No results message is not displayed as expected.");
           // }

       //}

        [Then(@"A message indicating No results found or similar should be displayed if there is no results in Antiques & collectables screen")]
        public void ThenAMessageIndicatingNoResultsFoundOrSimilarShouldBeDisplayedIfThereIsNoResultsInAntiquesCollectablesScreen()
        {
            if (!BrowsePage.AntiqueCollectionResult())
            {
                string expectedMessage = "No results found";
                string actualMessage = BrowsePage.NoResultsFoundMessage();
                Assert.IsTrue(actualMessage.Contains(expectedMessage), "No results message is not displayed as expected.");
                //Assert.IsTrue(BrowsePage.NoResultsFoundMessage(), "No results message is not displayed");
            }
        }

        [Then(@"I navigate back to the homepage")]
        public void ThenINavigateBackToTheHomepage()
        {
            HomePage.NavigateToHomeUsingLogo();
        }

        [Then(@"I should be on the Trade Me homepage")]
        public void ThenIShouldBeOnTheTradeMeHomepage()
        {
            BrowsePage.IsHomeScreenVisible();
        }


        [Then("I clicked on Art option")]
        public void ThenIClickedOnArtOption()
        {
            BrowsePage.ArtSelect();
            HomePage.Waitfor5seconds();
        }


        [Then(@"I should be navigated to Art screen")]
        public void ThenIShouldBeNavigatedToArtScreen()
        {
            BrowsePage.ArtOpened();
            HomePage.Waitfor5seconds();
        }

        [Then(@"the screen title should Art")]
        public void ThenTheScreenTitleShouldArt()
        {
            string expectedlabel = "Art";
            string actuallabel = BrowsePage.VerifyArtTitle();
            Assert.AreEqual(expectedlabel, actuallabel, "The screen title is Art");
        }

        [Then(@"the list of Art should be available")]
        public void ThenTheListOfArtShouldBeAvailable()
        {
            Assert.IsTrue(BrowsePage.ArtResult(), "Arts items list is not displayed") ;
            BrowsePage.ArtResult() ;
            //BrowsePage.ArtList();
            HomePage.Waitfor5seconds();
        }

        [Then("A message indicating No results found or similar should be displayed if there is no results in Art screen")]
        public void ThenAMessageIndicatingNoResultsFoundOrSimilarShouldBeDisplayedIfThereIsNoResultsInArtScreen()
        {
            if (!BrowsePage.ArtResult())
            {
                string expectedMessage = "No results found";
                string actualMessage = BrowsePage.NoResultsFoundMessage();
                Assert.IsTrue(actualMessage.Contains(expectedMessage), "No results message is not displayed as expected.");
            }
        }
  

        [Then("I clicked on Baby gear option")]
        public void ThenIClickedOnBabyGearOption()
        {
            BrowsePage.BabyGearSelect();
            HomePage.Waitfor5seconds();
        }



        [Then(@"I should be navigated to Baby gear screen")]
        public void ThenIShouldBeNavigatedToBabyGearScreen()
        {
            BrowsePage.BabyGearOpened();
        }

        [Then(@"the screen title should Baby gear")]
        public void ThenTheScreenTitleShouldBabyGear()
        {
            string expectedlabel = "Baby gear";
            string actuallabel = BrowsePage.VerifyBabyGearTitle();
            Assert.AreEqual(expectedlabel, actuallabel, "The screen title is Baby gear ");
        }

        [Then(@"the list of Baby gear should be available")]
        public void ThenTheListOfBabyGearShouldBeAvailable()
        {
            Assert.IsTrue(BrowsePage.BabyGearResult(), "Babygear items list is not displayed");
            BrowsePage.BabyGearResult();
            HomePage.Waitfor5seconds();
            //BrowsePage.BabyGearList();
        }

        [Then("A message indicating No results found or similar should be displayed if there is no results in Baby gear screen")]
        public void ThenAMessageIndicatingNoResultsFoundOrSimilarShouldBeDisplayedIfThereIsNoResultsInBabyGearScreen()
        {
            if (!BrowsePage.BabyGearResult())
            {
                string expectedMessage = "No results found";
                string actualMessage = BrowsePage.NoResultsFoundMessage();
                Assert.IsTrue(actualMessage.Contains(expectedMessage), "No results message is not displayed as expected.");
            }
        }


        [Then(@"I clicked on Books option")]
        public void WhenIClickedOnBooksOption()
        {
            BrowsePage.BooksSelect();
            HomePage.Waitfor5seconds();
        }

        [Then(@"I should be navigated to Books screen")]
        public void ThenIShouldBeNavigatedToBooksScreen()
        {
            BrowsePage.BooksOpened();
        }

        [Then(@"the screen title should Books")]
        public void ThenTheScreenTitleShouldBooks()
        {
            string expectedlabel = "Books";
            string actuallabel = BrowsePage.VerifyBooksTitle();
            Assert.AreEqual(expectedlabel, actuallabel, "The screen title is Books");
        }

        [Then(@"the list of Books should be available")]
        public void ThenTheListOfBooksShouldBeAvailable()
        {

            Assert.IsTrue(BrowsePage.BooksResult(), "Books items list is not displayed");
            BrowsePage.BooksResult();
            HomePage.Waitfor5seconds();
            // BrowsePage.BooksList();
        }

        [Then("A message indicating No results found or similar should be displayed if there is no results in Books screen")]
        public void ThenAMessageIndicatingNoResultsFoundOrSimilarShouldBeDisplayedIfThereIsNoResultsInBooksScreen()
        {
            if (!BrowsePage.BooksResult())
            {
                string expectedMessage = "No results found";
                string actualMessage = BrowsePage.NoResultsFoundMessage();
                Assert.IsTrue(actualMessage.Contains(expectedMessage), "No results message is not displayed as expected.");
            }
        }




        [Then(@"I clicked on Building & renovation option")]
        public void WhenIClickedOnBuildingRenovationOption()
        {
            BrowsePage.BuildingrenovationSelect();
            HomePage.Waitfor5seconds();
        }

        [Then(@"I should be navigated to Building & renovation screen")]
        public void ThenIShouldBeNavigatedToBuildingRenovationScreen()
        {
            BrowsePage.BuildingrenovationOpened();
        }

        [Then(@"the screen title should Building & renovation")]
        public void ThenTheScreenTitleShouldBuildingRenovation()
        {
            string expectedlabel = "Building & renovation";
            string actuallabel = BrowsePage.VerifyBuildingrenovationTitle();
            Assert.AreEqual(expectedlabel, actuallabel, "The screen title is Building & renovation");
        }

        [Then(@"the list of Building & renovation should be available")]
        public void ThenTheListOfBuildingRenovationShouldBeAvailable()
        {
            //BrowsePage.BuildingrenovationList();
            Assert.IsTrue(BrowsePage.BuildingrenovationResult(), "Buildingrenovation items list is not displayed");
            BrowsePage.BuildingrenovationResult();
            HomePage.Waitfor5seconds();
        }

        [Then("A message indicating No results found or similar should be displayed if there is no results in Building & renovation screen")]
        public void ThenAMessageIndicatingNoResultsFoundOrSimilarShouldBeDisplayedIfThereIsNoResultsInBuildingRenovationScreen()
        {
            if (!BrowsePage.BuildingrenovationResult())
            {
                string expectedMessage = "No results found";
                string actualMessage = BrowsePage.NoResultsFoundMessage();
                Assert.IsTrue(actualMessage.Contains(expectedMessage), "No results message is not displayed as expected.");
            }
        }




        [Then(@"I clicked on Business, farming & industry option")]
        public void WhenIClickedOnBusinessFarmingIndustryOption()
        {
            BrowsePage.BusinessSelect();
            HomePage.Waitfor5seconds();
        }

        [Then(@"I should be navigated to Business, farming & industry screen")]
        public void ThenIShouldBeNavigatedToBusinessFarmingIndustryScreen()
        {
            BrowsePage.BusinessOpened();
        }

        [Then(@"the screen title should Business, farming & industry")]
        public void ThenTheScreenTitleShouldBusinessFarmingIndustry()
        {
            string expectedlabel = "Business, farming & industry";
            string actuallabel = BrowsePage.VerifyBusinessTitle();
            Assert.AreEqual(expectedlabel, actuallabel, "The screen title is Business, farming & industry");
        }

        [Then(@"the list of Business, farming & industry should be available")]
        public void ThenTheListOfBusinessFarmingIndustryShouldBeAvailable()
        {
            //BrowsePage.BusinessList();
            Assert.IsTrue(BrowsePage.BusinessResult(), "Business items list is not displayed");
            BrowsePage.BusinessResult();
            HomePage.Waitfor5seconds();

        }

        [Then("A message indicating No results found or similar should be displayed if there is no results in Business, farming & industry screen")]
        public void ThenAMessageIndicatingNoResultsFoundOrSimilarShouldBeDisplayedIfThereIsNoResultsInBusinessFarmingIndustryScreen()
        {
            if (!BrowsePage.BusinessResult())
            {
                string expectedMessage = "No results found";
                string actualMessage = BrowsePage.NoResultsFoundMessage();
                Assert.IsTrue(actualMessage.Contains(expectedMessage), "No results message is not displayed as expected.");
            }
        }


    }
}
