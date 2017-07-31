using NLog;
using OpenQA.Selenium;
using Page;
using System.Linq;

namespace Busines.BusinessObjects
{
    public class SearchResultFrameBO
    {
        private IWebDriver browser;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public SearchResultFrameBO(IWebDriver driver)
        {
            this.browser = driver;
        }      
        //кликаем первую линку в списке результатов поиска
        public void GoToTheFirstResult()
        {
            SearchResultFrame searchResultFrame = new SearchResultFrame(browser);
            browser.SwitchTo().Frame(searchResultFrame.containerFrame);
            logger.Info($"Browser switched from frame element to main page!");
            searchResultFrame.ListOfResults.ElementAt(0).Click();
            logger.Info($"The first link in the list of search resultes was clicked");
        }
    }
}
