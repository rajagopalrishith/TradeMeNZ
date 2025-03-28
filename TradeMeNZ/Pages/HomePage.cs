using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeMeNZ.Pages
{
    public class HomePage : CoreFunctions
    {
        protected new IWebDriver Driver { get; }


        public HomePage(IWebDriver driver, IWait<IWebDriver> wait) : base(driver, wait)
        {
            Driver = driver;
        }

        //Login Page Fields

        //private readonly By TradeMeLogo = By.XPath("//img[@title='Trade Me - Life lives here'])");
        private readonly By TradeMeLogo = By.XPath("(//img[@title='Trade Me - Life lives here'])[1]");
        private readonly By Loginlink = By.XPath("(//a[text()=' Log in '])");
        private readonly By Registerlink = By.XPath("(//a[@frendlink='/register'])[1]");
        private readonly By BrowseDropDown = By.XPath("(//button[@type='button'])[1]");
        private readonly By WatchlistLink = By.XPath("(//span[@class='tm-shell-main-nav__member-options-link--text'])[1]");
        private readonly By FavouritesLink = By.XPath("//span[normalize-space(text())='Favourites']");
        private readonly By StartAListingLink = By.XPath("//span[normalize-space(text())='Start a listing']");
        private readonly By MyTradeMeLink = By.XPath("//a[@frendlink='/my-trade-me']");
        private readonly By SearchBar = By.XPath("//form[@role='search']");
        private readonly By MarketPlacetab = By.XPath("//a[@class='tm-homepage-search-header__vertical-links-link tm-homepage-search-header__vertical-links-link--marketplace']");
        private readonly By Jobstab = By.XPath("//a[@class='tm-homepage-search-header__vertical-links-link tm-homepage-search-header__vertical-links-link--jobs']");
        private readonly By Motorstab = By.XPath("//a[@class='tm-homepage-search-header__vertical-links-link tm-homepage-search-header__vertical-links-link--motors']");
        private readonly By Propertytab = By.XPath("//a[@class='tm-homepage-search-header__vertical-links-link tm-homepage-search-header__vertical-links-link--property']");
        private readonly By Servicestab = By.XPath("//a[@class='tm-homepage-search-header__vertical-links-link tm-homepage-search-header__vertical-links-link--services']");

        public bool TrademeLogoVisible()
        {
            return IsElementDisplayed(TradeMeLogo);

        }


        //Login Page Methods
        public void CloseApplication()

        {

            Driver.Dispose();
        }


        public void Waitfor5seconds()
        {
            System.Threading.Thread.Sleep(5000);
        }


        public void Waitfor2seconds()
        {
            System.Threading.Thread.Sleep(2000);
        }

        public void NavigatetoTradeMe_Home()
        {
            Driver.Navigate().GoToUrl("https://www.tmsandbox.co.nz/a/");
        }

        public bool LoginOptionVisible()
        {
           return IsElementDisplayed(Loginlink);
        }

        public bool RegisterOptionVisible()
        {
            return IsElementDisplayed(Registerlink);
        }

        public bool BrowseDropDownVisible() 
        {
            return IsElementDisplayed(BrowseDropDown);
            
        }

        public bool WatchListLinkVisible()
        {  
            return IsElementDisplayed(WatchlistLink);
        }

        public bool FavouriteLinkVisible() 
        {
            return IsElementDisplayed(FavouritesLink);
        }

       public bool StartAListingLinkVisible()
        {
            return IsElementDisplayed(StartAListingLink);
        }

        public bool MyTradeLinkVisible()
        {
            return IsElementDisplayed(MyTradeMeLink);
        }

        public bool SearchBarLinkVisible()
        {
            return IsElementDisplayed(SearchBar);
        }
        public bool SearchBarVisible()
        {
            return IsElementDisplayed(SearchBar);
        }
        public void MarketPlacetabavailable()
        {
            IsElementDisplayed(MarketPlacetab);
        }

        public void Jobstabtabavailable()
        {
            IsElementDisplayed(Jobstab);
        }

        public void Motorstabavailable()
        {
            IsElementDisplayed(Motorstab);
        }

        public void Propertytabavailable()
        {
            IsElementDisplayed(Propertytab);
        }

        public void Servicestabavailable()
        {
            IsElementDisplayed(Servicestab);
        }

        public void NavigateToHomeUsingLogo()
        {
            ClickOnElement(TradeMeLogo);
        }

    }
}
