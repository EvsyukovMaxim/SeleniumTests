using Page.Basic;

namespace Page.Desktop
{
    public class DesktopPage : PageBase
    {
        private DesktopMap _map;
        public DesktopMap Map => _map ?? (_map = new DesktopMap(Driver));

        public void ClickDropDownProject()
        {
            Map.DropDownProjectArrow.Click();
        }

    }
}
