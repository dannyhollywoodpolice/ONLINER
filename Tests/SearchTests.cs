using Logic;
using NUnit.Framework;
using OpenQA.Selenium;
using Page;
using Page.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public class SearchTests 
    {
       
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
            
            Navigation.NavigateTo(browser, ConfigurationManager.AppSettings["mainPageUrl"]);
            SearchActions.EnterWord(browser, ConfigurationManager.AppSettings["searchWord"]);
            SearchActions.GoToTheFirstResult(browser);
            //костыль для нового firefox
            browser.SwitchTo().DefaultContent();
            SearchActions.CheckTitle(browser, ConfigurationManager.AppSettings["searchWord"]);
        }

        [TestFixtureTearDown]
        public static void CloseBrowser()
        {
            browser.Close();
            browser.Quit();
        }
    }
}
