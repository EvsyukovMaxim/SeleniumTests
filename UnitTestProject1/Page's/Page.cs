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

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://youla.2gis.local/login";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }

        //public IWebDriver ByXPath(string path)
        //{
        //    driver.FindElement(By.XPath(path));
        //    return driver;
        //}
        public string ByXPath(string path)
        {
            var element = Convert.ToString(driver.FindElement(By.XPath(path)).Text);
            return element;
        }
    }
}
