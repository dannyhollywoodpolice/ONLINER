using NLog;
using OpenQA.Selenium;
using Page;

namespace Business.BusinessObjects
{
    public class SearchBO
    {
        private  IWebDriver browser;

        public SearchBO(IWebDriver driver)
        {
            this.browser = driver;
        }

        public void EnterWordInSearchBoxClickOnTheFirstLink(string word)
        {
            Header head = new Header(browser);
            ProductPage article = new ProductPage(browser);
            SearchResultFrame frame = new SearchResultFrame(browser);

            head.EnterWordToFind(word);
            frame.GoToTheFirstResult();
            BrowserFactory.SwitchToDefContentForFirefox();
            article.CheckTitle(word);          

        }
        
    }
}
