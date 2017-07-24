using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page.PageObjects
{
    public class SearchResultPage
    {
        private readonly IWebDriver driver;

        public SearchResultPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }

        public IList<IWebElement> ListOfResults => driver.FindElements(By.XPath("//a[contains(@target, '_parent')]"));
      
        public IWebElement Res => driver.FindElement(By.XPath("//a[contains(@class, 'product__title-link')]"));
    }
}
