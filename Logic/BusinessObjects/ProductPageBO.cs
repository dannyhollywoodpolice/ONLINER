using NLog;
using OpenQA.Selenium;
using Page;

namespace Business.BusinessObjects
{
    public class ProductPageBO
    {
        private IWebDriver browser;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ProductPageBO(IWebDriver driver)
        {
            this.browser = driver;
        }
        //проверям если заголовок статьи содержит некоторую строку
        public void CheckTitle(string title)
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.Title.Text.Contains(title);
            logger.Info($"Title of article contains needed string {title}! Success!");
        }
    }
}
