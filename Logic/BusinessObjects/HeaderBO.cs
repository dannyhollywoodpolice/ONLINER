using NLog;
using OpenQA.Selenium;
using Page;

namespace Business.BusinessObjects
{
    public class HeaderBO
        //логгер у меня размазан по всему фреймворку, не знаю правильно ли это
    {
        private  IWebDriver browser;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        //В конструкторе передаем нужный браузер, чтобы обеспечить возможность работы одного бизнес-объекта
        //с разными браузерами
        public HeaderBO(IWebDriver driver)
        {
            this.browser = driver;
        }
        //Header header = new Header(browser);
        //Не удалось создать страничку одну на весь бизнес-объект из-за того, что 
        //браузер будет инициализирован лишь во время выполнения теста
        public void EnterWordToFind(string wordToSearch)
        {
            Header header = new Header(browser);
            header.SearchBox.SendKeys(wordToSearch);
            logger.Info($"Entering the search word {wordToSearch} into search box");
        }
        
    }
}
