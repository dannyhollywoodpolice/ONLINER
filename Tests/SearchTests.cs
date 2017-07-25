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
        public static void InitializeBrowser()
        {
            Browser.InitializeBrowser("Chrome");
            browser = Browser.Driver;
        }
        [Test]
        public void VerifyIfSearchIsCorrect()
        {           
            Navigation.NavigateTo(browser, mainPageUrl);
            SearchActions.EnterWord(browser, searchWord);
            SearchActions.GoToTheFirstResult(browser);
            SearchActions.CheckTitle(browser, searchWord);
        }

        [TestFixtureTearDown]
        public static void CloseBrowser()
        {
            browser.Close();
            browser.Quit();
        }
    }
}
