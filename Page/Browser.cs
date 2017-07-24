using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page
{
    public static class Browser
    {
        private static IWebDriver driver = null;
        private static readonly object lockObject = new object();

        public static IWebDriver InitializeBrowser(string browserName)
        {
            if (driver == null)
            {
                if (browserName.Equals("Chrome"))
                {
                    driver = new ChromeDriver();
                }
                else if (browserName.Equals("Firefox"))
                {
                    driver = new FirefoxDriver();
                }                
                else
                {
                    throw new NullReferenceException("WebDriver browser name was uncorrect. Try enter Chrome or Firefox! ");
                }
            }
            return driver;
        }
    }    
}
