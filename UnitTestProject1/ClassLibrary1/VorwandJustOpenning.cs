using System;
using System.Threading;
using System.Windows.Forms;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Page.Basic;
using Page.Vorwands;

namespace UnitTestProject1
{
    [TestFixture]
    public class VorwandJustOpenning : WebDriverTestsBase<VowandsPage>
    {
        [Test]
        public void JustOpenVorwand()
        {
            for (int i = 1; i < 3; i++)
            {
                Random n = new Random();
                int nInt = n.Next(10849573, 12849573);
                WebDriverContext.Navigate("vorwand#/id=" + nInt);
                Thread.Sleep(3000);
            }
         }

        protected override string PageUrl => "vorwand#/id=12849551";
    }
}
