using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace Page_s.Login
{
    public class LoginPageValidator
    {
        private readonly IWebDriver _browser;

        public LoginPageValidator(IWebDriver browser)
        {
            _browser = browser;
        }

        private LoginMap Map => new LoginMap(_browser);

        public void UserNameIs(string expectedUserName)
        {
            StringAssert.Contains(Map.UserNameDiv.Text, expectedUserName,
                "The results DIV doesn't contains the specified text.");
        }
    }
}
