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
    public class Browser
    {
        private static IWebDriver driver = null;

        public static IWebDriver Driver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
        public static void InitializeBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (Driver == null)
                    {
                        driver = new FirefoxDriver();
                    }
                    break;

                case "Chrome":
                    if (Driver == null)
                    {
                        driver = new ChromeDriver();
                    }
                    break;
                default:
                    {
                        throw new NullReferenceException("WebDriver browser name was uncorrect. Try enter Chrome or Firefox! ");
                    }
            }
        }
    }
}


