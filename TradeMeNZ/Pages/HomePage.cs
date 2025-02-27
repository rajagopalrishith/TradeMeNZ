using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeMeNZ.Framework;

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

        private readonly By loginusernamefield = By.XPath("//input[contains(@name,'login')]");

        private readonly By loginpasswordfield = By.XPath("//input[contains(@name,'password')]");

       


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
            Driver.Navigate().GoToUrl("https://buggy.justtestit.org/");
        }





    }
}
