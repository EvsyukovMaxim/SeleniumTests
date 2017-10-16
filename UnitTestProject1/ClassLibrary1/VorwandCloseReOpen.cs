using NUnit.Framework;
using Page.Basic;
using Page.Vorwands;

namespace ClassLibrary1
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
