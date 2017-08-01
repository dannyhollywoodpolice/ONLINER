namespace Page
{
    using NLog;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using System;

    public static class BrowserFactory
    {
        private static IWebDriver driver = null;

        private static Logger logger = LogManager.GetCurrentClassLogger();

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
                        logger.Debug($"Initializing browser! It is Firefox!");
                    }
                    break;

                case "Chrome":
                    if (Driver == null)
                    {
                        driver = new ChromeDriver();
                        //костыль для хрома
                        //как оказалось, если его не развернешь на полное окно, он не видит некоторых элементов странички
                        driver.Manage().Window.Maximize();
                        logger.Info($"Initializing browser! It is Chrome!");
                    }
                    break;
                default:
                    {
                        logger.Error($"Failed to initialize browser!");
                        throw new NullReferenceException("WebDriver browser name was uncorrect. Try enter Chrome or Firefox! ");    
                    }
            }
        }
        public static void NavigateTo(string URL)
        {
            driver.Navigate().GoToUrl(URL);
            logger.Info($"Navigating to {URL}! ");
        }
        public static void SwitchToDefContentForFirefox()
        {
            driver.SwitchTo().DefaultContent();
            logger.Info($"Switching to default content! ");
        }
        public static void Close()
        {
            logger.Info($"Closing browser!");
            driver.Close();
            driver.Quit();
        }
    }
}


