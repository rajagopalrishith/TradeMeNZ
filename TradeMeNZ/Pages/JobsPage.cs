using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TradeMeNZ.Pages
{
    public class JobsPage : CoreFunctions
    {
        public JobsPage(IWebDriver driver, IWait<IWebDriver> wait) : base(driver, wait)
        {
            
        }
    }
}
