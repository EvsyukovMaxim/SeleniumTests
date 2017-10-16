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
    public class VorwandOpenning : WebDriverTestsBase<VowandsPage>
    {
        [Test]
        public void OpenVorwand()
        {
            for (int i = 1; i < 3; i++)
            {
                Random n = new Random();
                int nInt = n.Next(10849573, 12849573);
                for (int t = 1; t < 11; t++)
                {
                    WebDriverContext.OpenNewTab();
                    WebDriverContext.Navigate("vorwand#/id=" + nInt);
                }
                //WebDriverContext.OpenNewTab();
                //PageHelper.WaitForMap(() => PageBase.Map.AppliedButton);
                //PageBase.ClickAppliedButton();

                //PageHelper.WaitForMap(() => PageBase.Map.ReopenButton);
                //PageBase.ClickReopenButton();

                //PageHelper.WaitForMap(() => PageBase.Map.ReopenApproveButton);
                //PageBase.ClickReopenApproveButton();
                WebDriverContext.CloseTab();
            }
         }

        protected override string PageUrl => "vorwand#/id=12849551";
    }
}
