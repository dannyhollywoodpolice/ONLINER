namespace Business.BusinessObjects
{
    using OpenQA.Selenium;
    using Page;

    public class SearchBO
    {
        private IWebDriver browser;

        public SearchBO(IWebDriver driver)
        {
            this.browser = driver;
        }


        private Header _header;

        public Header Header
        {
            get
            {
                return _header ?? (_header = new Header(browser));
            }
        }

        private ProductPage _productPage;

        public ProductPage ProductPage
        {
            get
            {
                return _productPage ?? (_productPage = new ProductPage(browser));
            }
        }

        private SearchResultFrame _searchResultFrame;


        public SearchResultFrame SearchResultFrame
        {
            get
            {
                return _searchResultFrame ?? (_searchResultFrame = new SearchResultFrame(browser));
            }
        }
    }
}
