using OpenQA.Selenium;
using Page;
using Page.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class SearchActions
    {
        public static void EnterWord(IWebDriver driver, string word)
        {
            Header header = new Header(driver);
            header.SearchBox.SendKeys(word);
        }
        public static void GoToTheFirstResult(IWebDriver driver)
        {
            SearchResultFrame frame = new SearchResultFrame(driver);
            driver.SwitchTo().Frame(frame.containerFrame);
            frame.ListOfResults.ElementAt(0).Click();
        }
        public static void CheckTitle(IWebDriver driver, string title)
        {
            ProductPage productPage = new ProductPage(driver);
            productPage.Title.Text.Contains(title);
        }
    }
}
