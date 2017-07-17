using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;

namespace Page_s
{
    public class Page
    {
        public IWebDriver GetBrowser (string url)
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
            return driver;
        }


    }
}
