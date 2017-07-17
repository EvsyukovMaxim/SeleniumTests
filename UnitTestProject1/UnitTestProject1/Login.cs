using System;
using System.Reflection;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Page_s;

namespace UnitTestProject1
{
    [TestClass]
    public class Test1 : Page
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = GetBrowser("http://uk-youla-iis/login");
            var login = driver.FindElement(By.Id("username"));
            var password = driver.FindElement(By.Id("password"));
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            login.SendKeys("local"+"\\"+"a");
            password.SendKeys("a");
            driver.FindElement(By.ClassName("button-login")).Click();
            var element = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//html/body/div[1]/div/div/div/ul/li[4]/a/span[1]")));

            var loggedUser = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/ul/li[4]/a/span[1]"));
            Assert.AreEqual("a",Convert.ToString(loggedUser.Text));

            driver.Quit();
        }

        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uk-youla-iis/login";

            driver.FindElement(By.CssSelector("a[href*='#']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var element = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//html/body/div[1]/div/div/div/ul/li[4]/a/span[1]")));

            var loggedUser = driver.FindElement(By.XPath("//html/body/div[1]/div/div/div/ul/li[4]/a/span[1]"));

            Assert.AreEqual("Евсюков Максим Владимирович", Convert.ToString(loggedUser.Text));

            driver.Quit();
        }
    }
}