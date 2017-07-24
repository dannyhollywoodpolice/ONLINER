using Logic;
using NUnit.Framework;
using OpenQA.Selenium;
using Page;
using Page.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public class SearchTests
    {
        private string searchWord = "iPhone";
        private string mainPageUrl = "https://www.onliner.by/";
        private static IWebDriver browser;

        [TestFixtureSetUp]
        public static void Maximise()
        {
            browser = Browser.InitializeBrowser("Chrome");
            browser.Manage().Window.Maximize();
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
        [Test]
        public void test1()
        {           
            Navigation.NavigateTo(browser, mainPageUrl);

            Header header = new Header(browser);
           

            SearchByWord.EnterWord(header.SearchBox, searchWord);

            SearchResultPage resultPage = new SearchResultPage(browser);
            //header.ListOfResults.ElementAt(0).Click();
            browser.SwitchTo().Frame(0);
            IWebElement a = browser.FindElement(By.PartialLinkText("Apple iPhone 7 32GB Black"));
             a.Click();
           
        Assert.AreEqual("Apple iPhone 7 32GB Black", a.Text);

        }
    }
}
