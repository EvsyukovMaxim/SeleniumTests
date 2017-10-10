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
            WebDriverContext.Navigate("vorwand#/id=12829284");

            PageHelper.WaitForMap(() => PageBase.Map.AppliedButton);
            PageBase.ClickAppliedButton();

            PageHelper.WaitForMap(() => PageBase.Map.ReopenButton);
            PageBase.ClickReopenButton();

            PageHelper.WaitForMap(() => PageBase.Map.ReopenApproveButton);
            PageBase.ClickReopenApproveButton();
        }

        protected override string PageUrl => "vorwand#/id=12829284";
    }
}
