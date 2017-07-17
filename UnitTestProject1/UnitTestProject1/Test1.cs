using System;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uk-youla-iis/login";
            var login = driver.FindElement(By.Id("username"));
            var password = driver.FindElement(By.Id("password"));
            login.SendKeys("local"+"\\"+"a");
            password.SendKeys("a");
            driver.FindElement(By.ClassName("btn btn-primary")).Click();
            Assert.AreEqual("a", driver.FindElement(By.ClassName("btn dropdown-toggle")));
            driver.Quit();
        }

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "http://uk-youla-iis/login";
        //    driver.FindElement(By.CssSelector("a[href*='#']")).Click();
        //    //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    //IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Id("someDynamicElement")));
        //    Assert.AreEqual("Территориальное деление", driver.FindElement(By.ClassName("a[href*='/territories']")));
        //}
    }
}