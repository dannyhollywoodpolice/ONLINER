using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page
{
    public class Header
    {
        private readonly IWebDriver driver;

        public Header(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }

        public IWebElement SearchBox => driver.FindElement(By.XPath("//input[contains(@name, 'query')]"));

        public IList<IWebElement> ListOfResults => driver.FindElements(By.TagName("a"));
        //*[@class='MyClassName']
        public IWebElement Res => driver.FindElement(By.XPath("//*[@class='product__title-link']"));
    }
}
