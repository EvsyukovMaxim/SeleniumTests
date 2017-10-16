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
    public class VorwandCloseReOpen : WebDriverTestsBase<VowandsPage>
    {
        [Test]
        public void OpenCLoseReOpenVorwand()
        {
                WebDriverContext.Navigate("vorwand#/id=12849551");
                PageHelper.WaitForMap(() => PageBase.Map.AppliedButton);
                PageBase.ClickAppliedButton();

                PageHelper.WaitForMap(() => PageBase.Map.ReopenButton);
                PageBase.ClickReopenButton();

                PageHelper.WaitForMap(() => PageBase.Map.ReopenApproveButton);
                PageBase.ClickReopenApproveButton();
         }

        protected override string PageUrl => "vorwand#/id=12849551";
    }
}
