using Logic;
using NLog;
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
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static IWebDriver browser;

        [TestFixtureSetUp]
        public static void InitializeBrowser()
        {
            Browser.InitializeBrowser("Chrome");
            logger.Debug($"Initializing browser!");
            browser = Browser.Driver;
            logger.Debug($"Starting browser!");
        }
        [Test]
        public void VerifyIfSearchIsCorrect()
        {
            
            Navigation.NavigateTo(browser, ConfigurationManager.AppSettings["mainPageUrl"]);
            logger.Info($"Navigating to '{ ConfigurationManager.AppSettings["mainPageUrl"]}!'"); 
                       
            SearchActions.EnterWord(browser, ConfigurationManager.AppSettings["searchWord"]);
            logger.Info($"Entering word '{ ConfigurationManager.AppSettings["searchWord"]}' in search box!");

            SearchActions.GoToTheFirstResult(browser);
            logger.Info($"Clicking the first link in list of search results and get article!");
            //костыль для нового firefox
            browser.SwitchTo().DefaultContent();
            logger.Info($"Checking if title of article contains '{ConfigurationManager.AppSettings["searchWord"]}'!");
            SearchActions.CheckTitle(browser, ConfigurationManager.AppSettings["searchWord"]);
           
        }

        [TestFixtureTearDown]
        public static void CloseBrowser()
        {
            logger.Debug($"Closing browser!");
            browser.Close();
            browser.Quit();
        }
    }
}
