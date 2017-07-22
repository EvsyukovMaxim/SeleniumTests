using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Page_s.Basic;
using Page_s.Login;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProjectYouLa
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
            var loggedUser = driver.ByXPath("/html/body/div[1]/div/div/div/ul/li[4]/a/span[1]");
            Assert.AreEqual("a", loggedUser.Text);
            EndTest();
        }

        [TestMethod]
        public void LoggingDomenUser()
        {
            GetBrowser("http://uk-youla-iis/login");

            driver.ByCssSelector("a[href*='#']").Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//html/body/div[1]/div/div/div/ul/li[4]/a/span[1]")));

            var loggedUser = driver.ByXPath("//html/body/div[1]/div/div/div/ul/li[4]/a/span[1]");

            Assert.AreEqual("Евсюков Максим Владимирович", loggedUser.Text);
            
            //EndTest();
        }
    }
}