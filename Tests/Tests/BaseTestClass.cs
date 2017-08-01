using NUnit.Framework;
using OpenQA.Selenium;
using Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class BaseTestClass
    {
        public static IWebDriver browser;

        [SetUp]
        public virtual void SetUp()
        {
            BrowserFactory.InitializeBrowser("Chrome");
            browser = BrowserFactory.Driver;
        }

        [TearDown]
        public static void TearDown()
        {
            BrowserFactory.Close();
        }
    }
}
