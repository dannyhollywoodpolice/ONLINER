namespace Test
{
    using Business.BusinessObjects;
    using NUnit.Framework;
    using Page;
    using System.Configuration;
    using Tests;

    [TestFixture]
    public class SearchTests : BaseTestClass
    {
        public string mainPageUrl = ConfigurationManager.AppSettings["mainPageUrl"];
        public string searchWord = ConfigurationManager.AppSettings["searchWord"];
       

        [Test]
        public void VerifyIfTitleOfArticleContainsEnteredWord()
        {
            SearchBO search = new SearchBO(browser);
            BrowserFactory.NavigateTo(mainPageUrl);

            search.Header.EnterWordToFind(searchWord);
            Assert.IsTrue(search.Header.SearchBox.GetAttribute("value") == searchWord);

           
            search.SearchResultFrame.GoToTheFirstResult();          
            Assert.IsTrue(search.ProductPage.Title.Text == "Смартфон Apple iPhone 7 32GB Black");
               
            search.ProductPage.CheckTitle(searchWord);
            Assert.IsTrue(search.ProductPage.Title.Text.Contains(searchWord)); 
        }
    }
}
