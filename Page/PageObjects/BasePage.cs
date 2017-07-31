using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Page
{
    //базовый класс для каждой странички, в котором мы создаем экземпляр странички
    //со всем набором элементов
    public class BasePage
    {
        public IWebDriver driver;

        public BasePage(IWebDriver browser)
        {
            this.driver = browser;
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            PageFactory.InitElements(browser, this);
        }
    }
}
