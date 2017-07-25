using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Page.PageObjects
{
    public class ProductPage : BasePage
    {
        public ProductPage(IWebDriver browser) : base(browser)
        {
        }

        public IWebElement Title => driver.FindElement(By.XPath("//h1[contains(@class, 'catalog-masthead__title')]"));
    }
}
