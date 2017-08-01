using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Page
{
    public class SearchResultFrame : BasePage
    {
        public SearchResultFrame(IWebDriver browser) : base(browser)
        {
        }

        public IList<IWebElement> ListOfResults => driver.FindElements(By.XPath("//a[contains(@class, 'product__title-link')]"));
        
        public IWebElement containerFrame => driver.FindElement(By.ClassName("modal-iframe"));

        public void GoToTheFirstResult()
        {
            driver.SwitchTo().Frame(containerFrame);
            logger.Info($"Browser switched from frame element to main page!");
            ListOfResults.ElementAt(0).Click();
            logger.Info($"The first link in the list of search resultes was clicked");
        }
    }
}
