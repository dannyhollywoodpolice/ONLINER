using Logic;
using NUnit.Framework;
using OpenQA.Selenium;
using Page;
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
        }
        [Test]
        public void test1()
        {           
            Navigation.NavigateTo(browser, mainPageUrl);

            Header header = new Header(browser);
            SearchByWord.EnterWord(header.SearchBox, searchWord); 
        }
    }
}
