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

        public IWebElement DropDownProject => _browser.FindElement(By.ClassName("select2-chosen"));

        public IWebElement DropDownProjectArrow => _browser.FindElement(By.ClassName("select2-arrow"));

        public IWebElement OpenedDropDownProjectTextBox=> _browser.FindElement(By.XPath("/html[@class=\'k-webkit k-webkit59\']/body/div[@id=\'select2-drop\']/div[@class=\'select2-search\']/input[@class=\'select2-input select2-focused\']"));

        public IWebElement UserNameDiv => _browser.FindElement(By.Id("userTablet"));

        public IWebElement CheckBoxTask => _browser.FindElement(By.XPath("//*[@id=\"cld-listTab\"]/table/tbody/tr/td/div/div[1]/table/tbody/tr[1]/td[1]/div/input"));

        public IWebElement TaskToSyncButton => _browser.FindElement(By.ClassName("fa-arrow-right"));

    }
}
