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

        private readonly By TradeMeLogo = By.XPath("//img[@title='Trade Me - Life lives here']");
        private readonly By JobsTab = By.XPath("//a[@routerlink='/jobs']");
        private readonly By Insurance = By.XPath("//a[contains (text(), \" Trade Me Insurance\" )]");
        private readonly By InsuranceLogo = By.ClassName("font-2625-rem");

        private readonly By MarketPlace = By.XPath("//a[@routerlink=\"/marketplace\"]");
        private readonly By MarketPlaceText = By.XPath("//h1[contains(text(), \" Shop our unique range of new & used.\")]");
        
        private readonly By SearchButton = By.XPath("(//button[text()= ' Search jobs '])[2]");
        private readonly By JobsNum = By.XPath("//h3[contains(text(), 'Showing 51 results')]");



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

        public void NavigatetoJobsPage()
        {
            ClickOnElement(JobsTab);
            Waitfor2seconds();
        }

        public string JobsPageURL()
        {
            return Driver.Url;
           
        }

        /*
        
        public void NavigatetoTrademeInsurance()
        {
            ClickOnElement(Insurance);
        }



        public bool InsuranceLogoDisplayed()
        {
            return IsElementDisplayed(InsuranceLogo);
        }
        */


        public void NavMarketPlace()
        {
            ClickOnElement(MarketPlace);
        }

        public bool isMarketPlaceOpen()
        {
            return IsElementDisplayed(MarketPlaceText);
        }

        public void JobsSearchButton()
        {
            ClickOnElement(SearchButton);
            Waitfor5seconds();
        }

        public bool DisplayJobs()
        {
            return IsElementDisplayed(JobsNum);
        }


    }
}
