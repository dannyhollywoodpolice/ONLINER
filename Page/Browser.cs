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
    public sealed class Browser
    {
        private static IWebDriver driver = null;
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
       
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
            if (Driver == null)
            {
                if (browserName.Equals("Chrome"))
                {
                    Driver = new ChromeDriver();
                    Driver.Manage().Window.Maximize();
                    Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    Drivers.Add("Chrome", Driver);
                }
                else if (browserName.Equals("Firefox"))
                {
                    Driver = new FirefoxDriver();
                    Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    Drivers.Add("Firefox", Driver);

                }
                else
                {
                    throw new NullReferenceException("WebDriver browser name was uncorrect. Try enter Chrome or Firefox! ");
                }
            }
        }
    }

}

