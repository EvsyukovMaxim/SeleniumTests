using NUnit.Framework;
using OpenQA.Selenium;

namespace Page.Desktop
{
    public class DesktopProjectValidator
    {
        private readonly IWebDriver _browser;

        public DesktopProjectValidator(IWebDriver browser)
        {
            _browser = browser;
        }

        public DesktopMap Map => new DesktopMap(_browser);

        public void UserProjectIs(string expectedUserProject)
        {
            StringAssert.Contains(Map.DropDownProject.Text, expectedUserProject, 
                "The results DIV doesn't contains the specified text.");
        }
    }
}
