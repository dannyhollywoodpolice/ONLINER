namespace Page
{
    using NLog;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using System;

    //базовый класс для каждой странички, в котором мы создаем экземпляр странички
    //со всем набором элементов
    public class BasePage
    {
        public  static Logger logger = LogManager.GetCurrentClassLogger();

        public IWebDriver driver;

        public BasePage(IWebDriver browser)
        {
            this.driver = browser;
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            PageFactory.InitElements(browser, this);
        }
    }
}
