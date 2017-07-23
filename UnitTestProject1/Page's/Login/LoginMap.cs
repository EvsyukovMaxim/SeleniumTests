using OpenQA.Selenium;
using Page_s.Basic;

namespace Page_s.Login
{
    public class LoginMap
    {
        private readonly IWebDriver _browser;

        public LoginMap(IWebDriver browser)
        {
            _browser = browser;
        }

        public IWebElement LoginTextBox => _browser.FindElement(By.Id("username"));

        public IWebElement PasswordTextBox => _browser.FindElement(By.Id("password"));

        public IWebElement LoginButton => _browser.FindElement(By.Id("button-login"));

        public IWebElement UserNameDiv => _browser.FindElement(By.Id("userTablet"));
    }
}
