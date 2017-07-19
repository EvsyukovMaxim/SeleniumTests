using System;
using System.Reflection;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using Page_s.Login;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestClass]
    public class Login : LoginPage
    {
        [TestMethod]
        public void LoggingLocalA()
        {
            GetBrowser("http://youla.dev:8080/login");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            FillAuthForm("local\\a","a");
            LoginButton();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/div[1]/div/div/div/ul/li[4]/a/span[1]")));
            var loggedUser = ByXPath("/html/body/div[1]/div/div/div/ul/li[4]/a/span[1]");

            Assert.AreEqual("a", TextedSelector(loggedUser));
            EndTest();
        }

        [TestMethod]
        public void LoggingDomenUser()
        {
            GetBrowser("http://youla.2gis.local/login");

            ByCssSelector("a[href*='#']").Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//html/body/div[1]/div/div/div/ul/li[4]/a/span[1]")));

            var loggedUser = ByXPath("//html/body/div[1]/div/div/div/ul/li[4]/a/span[1]");

            Assert.AreEqual("Евсюков Максим Владимирович", TextedSelector(loggedUser));

            EndTest();
        }
    }
}