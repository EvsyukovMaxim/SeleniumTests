using System;
using NUnit.Framework;
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

            for (int i = 1; i < 350; i++)
            {
                for (int tabNumber = 0; tabNumber < 10; tabNumber++)
                {
                    Random n = new Random();
                    int nInt = n.Next(10849573, 12849573);
                    WebDriverContext.SwitchTab(tabNumber);
                    WebDriverContext.Navigate("vorwand#/id=" + nInt);
                }
            }
         }

        protected override string PageUrl => "vorwand#/id=12849551";
    }
}
