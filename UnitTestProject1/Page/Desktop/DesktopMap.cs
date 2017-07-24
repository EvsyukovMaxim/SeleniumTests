using OpenQA.Selenium;

namespace Page.Desktop
{
    public class DesktopMap
    {
        private readonly IWebDriver _browser;

        public DesktopMap(IWebDriver browser)
        {
            _browser = browser;
        }

        public IWebElement DropDownShort => _browser.FindElement(By.ClassName("select2-chosen"));

        public IWebElement DropDownProjectArrow => _browser.FindElement(By.ClassName("select2-arrow"));

        public IWebElement DropDownProjectTextBox=> _browser.FindElement(By.CssSelector("#select2-input"));

        public IWebElement UserNameDiv => _browser.FindElement(By.Id("userTablet"));
    }
}
