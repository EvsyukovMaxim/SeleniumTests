using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using Page.Basic;
using Page.Vorwands;

namespace ClassLibrary1
{
    [TestFixture]
    public class VorwandNewTabsOpenning : WebDriverTestsBase<VowandsPage>
    {
        [Test]
        public void OpenNewTabVorwand()
        {
            Random n = new Random();
            int nInt = n.Next(10849573, 12849573);
            for (int e = 1; e < 10; e++)
            {
                WebDriverContext.OpenNewTab();
            }

            for (int i = 1; i < 3; i++)
            {
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[0]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[1]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[2]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[3]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[4]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[5]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[6]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[7]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[8]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                WebDriverContext.GetInstance().Driver.SwitchTo().Window(WebDriverContext.GetInstance().Driver.WindowHandles[9]);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
            }
         }

        protected override string PageUrl => "vorwand#/id=12849551";
    }
}
