using System;
using System.Threading;
using System.Windows.Forms;
using NUnit.Framework;
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
            for (int  i =1; i < 10000; i++)
                {
                    Random n = new Random();
                    int nInt = n.Next(10849573, 12849573);
                    WebDriverContext.Navigate("vorwand#/id="+nInt);

                    //PageHelper.WaitForMap(() => PageBase.Map.AppliedButton);
                    //PageBase.ClickAppliedButton();

                    //PageHelper.WaitForMap(() => PageBase.Map.ReopenButton);
                    //PageBase.ClickReopenButton();

                    //PageHelper.WaitForMap(() => PageBase.Map.ReopenApproveButton);
                    //PageBase.ClickReopenApproveButton();
                    Thread.Sleep(3000);
                }
         }

        protected override string PageUrl => "vorwand#/id=12849551";
    }
}
