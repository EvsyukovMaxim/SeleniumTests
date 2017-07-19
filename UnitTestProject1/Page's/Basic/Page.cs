using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;

namespace Page_s
{
    public class Page : PageBase
    {

        public IWebDriver GetBrowser (string url)
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

        public IWebElement ByXPath(string path)
        {
            var element = driver.FindElement(By.XPath(path));
            return element;
        }

        public IWebElement ByCssSelector(string path)
        {
            var element = driver.FindElement(By.CssSelector(path));
            return element;
        }

        public string TextedSelector(IWebElement selector)
        {
            var element = selector.Text;
            return element;
        }

        public void AuthForm()
        {
            Map.LoginButton.Click();
        }

    }
}
