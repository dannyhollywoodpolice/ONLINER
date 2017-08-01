namespace Tests
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using Page;
    using System.Configuration;

    [TestFixture]
    public class BaseTestClass
    {
        public static IWebDriver browser;
        public string Chrome =  ConfigurationManager.AppSettings["Chrome"];

        [SetUp]
        public void SetUp()
        {
            BrowserFactory.InitializeBrowser(Chrome);
            browser = BrowserFactory.Driver;
        }

        [TearDown]
        public static void TearDown()
        {
            BrowserFactory.Close();
        }
    }
}
