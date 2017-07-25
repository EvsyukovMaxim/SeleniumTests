using System.Linq;
using OpenQA.Selenium;
using Page.Basic;

namespace Page.Desktop
{
    public class DesktopPage : PageBase
    {
        private DesktopMap _map;
        public DesktopMap Map => _map ?? (_map = new DesktopMap(Driver));

        public void ClickProjectDropDownToOpen()
        {
            Map.DropDownProjectArrow.Click();
        }

        public DesktopProjectValidator ValidateProject()
        {
            return new DesktopProjectValidator(Driver);
        }
    }
}
