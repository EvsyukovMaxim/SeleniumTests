using OpenQA.Selenium;
using Page_s.Basic;

namespace Page_s.Login
{
    public class LoginMap : PageBase
    {
        public LoginMap(IWebDriver browser)
        {
            driver = browser;
        }

        public IWebElement LoginTextBox => driver.FindElement(By.Id("username"));

        public IWebElement PasswordTextBox => driver.FindElement(By.Id("password"));

        public IWebElement LoginButton => driver.FindElement(By.TagName("button"));

        public IWebElement UserNameDiv => driver.FindElement(By.CssSelector("body > div.navbar > div > div > div > ul > li.dropdown > a > span:nth-child(2)"));
    }
}
