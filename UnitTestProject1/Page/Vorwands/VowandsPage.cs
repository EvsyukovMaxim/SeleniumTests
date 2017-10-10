using Page.Basic;

namespace Page.Vorwands
{
    public class VowandsPage : PageBase
    {
        private VorwandsMap _map;
        public VorwandsMap Map => _map ?? (_map = new VorwandsMap(Driver));

        public void ClickAppliedButton()
        {
            Map.AppliedButton.Click();
        }

        public void ClickReopenButton()
        {
            Map.ReopenButton.Click();
        }

        public void ClickReopenApproveButton()
        {
            Map.ReopenApproveButton.Click();
        }
    }
}
