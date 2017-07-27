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

        public IWebElement CheckBoxTaskLeft => _browser.FindElement(By.XPath("//*[@id=\"cld-listTab\"]/table/tbody/tr/td/div/div[1]/table/tbody/tr[1]/td[1]/div/input"));

        public IWebElement CheckBoxTaskRight => _browser.FindElement(By.XPath("//*[@id=\"cld-right-pane\"]/div/table[1]/tbody/tr/td/div/div/table/tbody/tr/td[1]/div/input"));

        public IWebElement TaskToSyncButton => _browser.FindElement(By.Id("TaskToSyncButton"));

        public IWebElement TerritoriesLeftAmount => _browser.FindElement(By.XPath("//*[@id=\"page-calendar\"]/div[2]/table/tbody/tr/td[1]/div/div[1]/div[1]/span/span[1]/span[2]"));

        public IWebElement TerritoriesRightAmount => _browser.FindElement(By.XPath("//*[@id=\"cld-objects-count\"]/tbody/tr/td[1]"));

        public IWebElement InformationRefresher => _browser.FindElement(By.XPath("//*[@id=\"page-calendar\"]/div[2]/table/tbody/tr/td[3]/div[1]/a/i"));

    }
}
