using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace UnitTestProjectYouLa
{
    [TestClass]
    public class Desktop : DesktopPage
    {
        [TestMethod]
        public void ChooseProject()
        {
            //var logIn = new Login();
            //logIn.LoggingDomenUser();
            //driver.Navigate().GoToUrl("http://uk-youla-iis/calendar#/calendar");
            GetBrowser("http://youla.dev:8080/calendar#/calendar/cycle=13");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/div[1]/div/div/div/ul/li[4]/a/span[1]")));
            ByClassName("select2-chosen").Click();
            SelectElement dropDown = new SelectElement(ByClassName("select2-results"));
            dropDown.SelectByText("Новосибирск");
            EndTest();
        }
    }
}
