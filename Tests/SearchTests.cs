using Busines.BusinessObjects;
using Business.BusinessObjects;
using NLog;
using NUnit.Framework;
using OpenQA.Selenium;
using Page;
using System.Configuration;

namespace Test
{
    [TestFixture]
    public class SearchTests 
    {
        private static IWebDriver browser;    

        [TestFixtureSetUp]
        public static void InitializeBrowser()
        {
            BrowserFactory.InitializeBrowser("Chrome");           
            browser = BrowserFactory.Driver;
        }
        [Test]
        public void VerifyIfSearchIsCorrect()
        {
            //создаем экземпляры бизнес-объектов
            HeaderBO headerBO = new HeaderBO(browser);
            ProductPageBO productPageBO = new ProductPageBO(browser);
            SearchResultFrameBO searchResultFrameBO = new SearchResultFrameBO(browser);

            //операции, выполняемые браузером типа навигация, закрытие и переключение окон
            //перемещены в класс, отвечающий за действия с браузером
            BrowserFactory.NavigateTo(ConfigurationManager.AppSettings["mainPageUrl"]);

            headerBO.EnterWordToFind(ConfigurationManager.AppSettings["searchWord"]);

            searchResultFrameBO.GoToTheFirstResult();
            
            //к сожалению костыль для лисы не смогла убрать
            BrowserFactory.SwitchToDefContentForFirefox();

            productPageBO.CheckTitle(ConfigurationManager.AppSettings["searchWord"]);
        }

        [TestFixtureTearDown]
        public static void CloseBrowser()
        {
            BrowserFactory.Close();
        }
    }
}
