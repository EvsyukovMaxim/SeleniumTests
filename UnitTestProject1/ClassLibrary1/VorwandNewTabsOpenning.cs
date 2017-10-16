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
            for (int e = 1; e < 10; e++)
            {
                WebDriverContext.OpenNewTab();
            }

            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Random n = new Random();
                    int nInt = n.Next(10849573, 12849573);
                    WebDriverContext.SwitchTab(j);
                    WebDriverContext.Navigate("vorwand#/id=" + nInt);
                }
            }
         }

        protected override string PageUrl => "vorwand#/id=12849551";
    }
}
