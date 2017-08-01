using Business.BusinessObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using Page;
using System.Configuration;
using Tests;

namespace Test
{
    [TestFixture]
    public class SearchTests : BaseTestClass
    {
        [Test]
        public void VerifyIfTitleOfArticleContainsEnteredWord()
        {
            SearchBO search = new SearchBO(browser);
            BrowserFactory.NavigateTo(ConfigurationManager.AppSettings["mainPageUrl"]);

            search.EnterWordInSearchBoxClickOnTheFirstLink(ConfigurationManager.AppSettings["searchWord"]);          
        }
    }
}
