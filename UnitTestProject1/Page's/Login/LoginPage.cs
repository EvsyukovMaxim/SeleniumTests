using Page_s.Basic;

namespace Page_s.Login
{
    public class LoginPage : PageBase
    {
        private LoginMap _map;
        public LoginMap Map => _map ?? (_map = new LoginMap(Driver));

        public void ClickLoginButton()
        {
            Map.LoginButton.Click();
        }

        public void FillAuthForm(string login, string password)
        {
            Map.LoginTextBox.Clear();
            Map.PasswordTextBox.Clear();
            Map.LoginTextBox.SendKeys(login);
            Map.PasswordTextBox.SendKeys(password);
        }

        public LoginPageValidator Validate ()
        {
            return new LoginPageValidator(Driver);
        }

    }
}
