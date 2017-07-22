using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Page_s.Basic
{
    public class PageBase //исп веб контекст
    {
        public static IWebDriver driver { get; set; }

        public static IWebDriver GetBrowser(string url)
        {
            if (driver != null)
                return driver;

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
            return driver;
        }
        public void EndTest()
        {
            driver.Quit();
        }
    }


}
