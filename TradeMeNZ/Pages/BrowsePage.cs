using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeMeNZ.Pages
{
    public class BrowsePage : CoreFunctions
    {
        protected new IWebDriver Driver { get; }

        public BrowsePage(IWebDriver driver, IWait<IWebDriver> wait) : base(driver, wait)
        {
            Driver = driver;
        }

        //Browse fields

        private readonly By BrowseClick = By.XPath("//button[contains(@class,'tm-browse-dropdown__global-browse-button o-transparent-button2')]");
       // private readonly By BrowseCategory = By.XPath("//div[@class='tm-browse-dropdown__global-browse-heading p-h3']");
        private readonly By BrowseCategoryTitle = By.XPath("//div[@class='tm-browse-dropdown__global-browse-heading p-h3']");
       // private readonly By BrowseList = By.ClassName("tm-browse-dropdown__browse-links");
        private readonly By BrowseList = By.XPath("//div[@class='o-dropdown__pane ng-star-inserted']");
        private readonly By AntiquescollectablesLink = By.XPath("//a[normalize-space(text())='Antiques & collectables']");
        private readonly By AntiquescollectablesTitle = By.XPath("//div[@class='ng-star-inserted']//h1[1]");
        private readonly By AntiquescollectablesResults = By.XPath("//div[@class='tm-marketplace-search-results__container tm-marketplace-search-results__container--sponsored-listings-gallery']");
        private readonly By ArtLink = By.XPath("(//a[@class='h-link-no-visited tm-browse-dropdown__browse-cat-splat-links'])[2]");
        private readonly By ArtTitle = By.XPath("//h1[normalize-space(text())='Art']");
        private readonly By ArtResults = By.ClassName("tm-marketplace-search-results__container");
        private readonly By BabyGearLink = By.XPath("(//a[@class='h-link-no-visited tm-browse-dropdown__browse-cat-splat-links'])[3]");
        private readonly By BabyGearTitle = By.XPath("//h1[normalize-space(text())='Baby gear']");
        private readonly By BabyGearResults = By.ClassName("tm-marketplace-search-results__container");
        private readonly By BooksLink = By.XPath("(//a[@class='h-link-no-visited tm-browse-dropdown__browse-cat-splat-links'])[4]");
        private readonly By BooksTitle = By.XPath("//h1[normalize-space(text())='Books']");
        private readonly By BooksResults = By.ClassName("tm-marketplace-search-results__container");
        private readonly By BuildingrenovationLink  = By.XPath("(//a[@class='h-link-no-visited tm-browse-dropdown__browse-cat-splat-links'])[5]");
        private readonly By BuildingrenovationTitle = By.XPath("//h1[normalize-space(text())='Building & renovation']");
        private readonly By BuildingrenovationResults = By.ClassName("tm-marketplace-search-results__container");
        private readonly By BusinessLink = By.XPath("(//a[@class='h-link-no-visited tm-browse-dropdown__browse-cat-splat-links'])[6]");
        private readonly By BusinessTitle = By.XPath("//h1[normalize-space(text())='Business, farming & industry']");
        private readonly By BusinessResults = By.ClassName("tm-marketplace-search-results__container");
        private readonly By NoResultsMessage = By.XPath("//h2[normalize-space(text())='No results found']");
        private readonly By NavigateToHome = By.XPath("//span[normalize-space(text())='Home']");
        private readonly By HomeScreenMessage = By.XPath("//div[@class='tm-homepage-in-with-new-search-header__header l-container']");
                                                    

        public void ClickBrowsebutton()
        {
            ClickOnElement(BrowseClick);
        }

        public string BrowseCategoryScreen() 
        {
            WaitTillJavascriptLoad();
            // return GetElementText(BrowseCategoryTitle);
            return GetElementText(BrowseCategoryTitle);
        }
        
        public bool BrowseListScreen()
        {
            WaitTillJavascriptLoad();
            // FetchAllDropDownValues(BrowseList);
           return IsElementDisplayed(BrowseList, 5);
        }

       // public void Antiquescollectables()
        //{
       //     GetSelectedValuefromDropDown(AntiquescollectablesLink);
       // }

        public void AntiquescollectablesSelect()
        {
            //FindElementToClick(AntiquescollectablesLink);//
            ClickOnElement(AntiquescollectablesLink);
        }

        public bool AntiquescollectablesOpened()
        {
            WaitTillJavascriptLoad();
            return IsElementDisplayed(AntiquescollectablesTitle, 5);
        }

        public string VerifyAntiqueCollectionTitle()
        {
           return GetElementText(AntiquescollectablesTitle);

        }

        public bool AntiqueCollectionResult()
        {
           return IsElementDisplayed(AntiquescollectablesResults);
        }

       // public List<IWebElement> AntiqueCollectionList()
       // {
         //  return FindElements(AntiquescollectablesResults);
      //  }

        public bool AntiqueCollectionList()
        {
           return IsElementPresent(AntiquescollectablesResults);
        }

        public string NoResultsFoundMessage()
        {
            WaitTillJavascriptLoad();
           IsElementPresent(NoResultsMessage);
          return GetElementText(NoResultsMessage);
        }

        public void NavigateToHomePage()
        {
            WaitTillJavascriptLoad();
            ClickOnElement(NavigateToHome);
        }

        public void IsHomeScreenVisible()
        {
            WaitTillJavascriptLoad();
            IsElementDisplayed(HomeScreenMessage, 5);
        }

        public void ArtSelect()
        {
            //FindElementToClick(ArtLink);
            ClickOnElement(ArtLink);
            
        }

        public bool ArtOpened()
        {
            WaitTillJavascriptLoad();
            return IsElementDisplayed(ArtTitle, 5);
        }

        public string VerifyArtTitle()
        {
            return GetElementText(ArtTitle);

        }

        public bool ArtResult()
        {
            return IsElementDisplayed(ArtResults);
        }

        //  public List<IWebElement> ArtList()
        // {
        //      return FindElements(ArtResults);
        //  }

        public bool ArtList()
        {
            return IsElementPresent(ArtResults);
        }

        public void BabyGearSelect()
        {
            //FindElementToClick(BabyGearLink);
            ClickOnElement(BabyGearLink);
        }

        public bool BabyGearOpened()
        {
            WaitTillJavascriptLoad();
            return IsElementDisplayed(BabyGearTitle, 5);
        }

        public string VerifyBabyGearTitle()
        {
            return GetElementText(BabyGearTitle);

        }

        public bool BabyGearResult()
        {
            return IsElementDisplayed(BabyGearResults);
        }

        // public List<IWebElement> BabyGearList()
        // {
        //      return FindElements(BabyGearResults);
        //   }

        public bool BabyGearList()
        {
            return IsElementPresent(BabyGearResults);
        }

        public void BooksSelect()
        {
           // FindElementToClick(BooksLink);//
            ClickOnElement(BooksLink);
        }

        public bool BooksOpened()
        {
            WaitTillJavascriptLoad();
            return IsElementDisplayed(BooksTitle, 5);
        }

        public string VerifyBooksTitle()
        {
            return GetElementText(BooksTitle);

        }

        public bool BooksResult()
        {
            return IsElementDisplayed(BooksResults);
        }

        //  public List<IWebElement> BooksList()
        // {
        //    return FindElements(BooksResults);
        // }

        public bool BooksList()
        {
            return IsElementPresent(BooksResults);
        }

        public void BuildingrenovationSelect()
        {
           // FindElementToClick(BuildingrenovationLink);
            ClickOnElement(BuildingrenovationLink);
        }

        public bool BuildingrenovationOpened()
        {
            WaitTillJavascriptLoad();
            return IsElementDisplayed(BuildingrenovationTitle, 5);
        }

        public string VerifyBuildingrenovationTitle()
        {
            return GetElementText(BuildingrenovationTitle);

        }

        public bool BuildingrenovationResult()
        {
            return IsElementDisplayed(BuildingrenovationResults);
        }

        // public List<IWebElement> BuildingrenovationList()
        // {
        //    return FindElements(BuildingrenovationResults);
        // }

        public bool BuildingrenovationList()
        {
            return IsElementPresent(BuildingrenovationResults);
        }


        public void BusinessSelect()
        {
            //FindElementToClick(BusinessLink);
            ClickOnElement(BusinessLink);
        }

        public bool BusinessOpened()
        {
            WaitTillJavascriptLoad();
            return IsElementDisplayed(BusinessTitle, 5);
        }

        public string VerifyBusinessTitle()
        {
            return GetElementText(BusinessTitle);

        }

        public bool BusinessResult()
        {
            return IsElementDisplayed(BusinessResults);
        }

        // public List<IWebElement> BusinessList()
        // {
        //    return FindElements(BusinessResults);
        //  }

        public bool BusinessList()
        {
            return IsElementPresent(BusinessResults);
        }

    }


}
