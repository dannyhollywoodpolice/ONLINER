using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page
{
    public class BasePage
    {

        public  readonly IWebDriver driver;
        
        public BasePage(IWebDriver browser)
        {
            this.driver = browser;
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            PageFactory.InitElements(browser, this);
        }
    }
}
