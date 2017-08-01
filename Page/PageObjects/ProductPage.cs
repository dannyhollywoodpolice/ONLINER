namespace Page
{
    using OpenQA.Selenium;

    public class ProductPage : BasePage
    {
        public ProductPage(IWebDriver browser) : base(browser)
        {
        }

        public IWebElement Title => driver.FindElement(By.XPath("//h1[contains(@class, 'catalog-masthead__title')]"));

        public void CheckTitle(string title)
        {
            Title.Text.Contains(title);
            logger.Info($"Title of article contains needed string {title}! Success!");
        }
    }
}
