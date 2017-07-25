using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page.PageObjects
{
    public class SearchResultFrame : BasePage
    {
        public SearchResultFrame(IWebDriver browser) : base(browser)
        {
        }

        public IList<IWebElement> ListOfResults => driver.FindElements(By.XPath("//a[contains(@class, 'product__title-link')]"));
        
        public IWebElement containerFrame => driver.FindElement(By.ClassName("modal-iframe"));
    }
}
