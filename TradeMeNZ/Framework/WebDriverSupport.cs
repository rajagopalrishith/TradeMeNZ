
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace TradeMeNZ.Framework
{ 
 [Binding]
public class WebDriverSupport : IDisposable
{
    private IWait<IWebDriver> _defaultWait = null;
    private IWebDriver Driver = null;

    [BeforeScenario]
    public void InitializeWebDriver()
    {

        {
            Driver = new ChromeDriver();

        }
        ;
        int timeout = 5000;
        int pollInterval = 10000;
        _defaultWait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout))
        {
            PollingInterval = TimeSpan.FromMilliseconds(pollInterval)
        };
    }

    [AfterScenario]
    public void Dispose()
    {
        if (Driver != null)
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
}
