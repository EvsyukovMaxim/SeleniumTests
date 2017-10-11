using OpenQA.Selenium;

namespace Page.Vorwands
{
    public class VorwandsMap
    {
        private readonly IWebDriver _browser;

        public VorwandsMap(IWebDriver browser)
        {
            _browser = browser;
        }

        public IWebElement AppliedButton => _browser.FindElement(By.CssSelector("#page-vorwand-form > div:nth-child(5) > div:nth-child(2) > div:nth-child(5) > div > a"));

        public IWebElement ReopenButton => _browser.FindElement(By.XPath("//a[contains(text(),\'Переоткрыть\')]"));

        public IWebElement ReopenApproveButton => _browser.FindElement(By.CssSelector("#reopenVorwandModal > div.modal-footer > input"));
    }
}
