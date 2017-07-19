using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;

namespace Page_s.Basic
{
    public class PageBase
    {
        public IWebDriver driver { get; set; }

        public IWebDriver GetBrowser(string url)
        {
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
