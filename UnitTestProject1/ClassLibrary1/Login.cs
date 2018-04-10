using NUnit.Framework;
using Page.Basic;
using Page.Login;

namespace ClassLibrary1
{
    [TestFixture]
    public class Login : WebDriverTestsBase<LoginPage>
    {

        [Test]
        public void LoggingLocalA()
        {
            WebDriverContext.Navigate("login");
            PageHelper.WaitForMap(() => PageBase.Map.LoginTextBox);
            PageBase.FillAuthForm("local\\a", "a");
            PageBase.ClickLoginButton();
            PageHelper.WaitForMap(() => PageBase.Map.UserNameDiv);
            PageBase.Validate().UserNameIs("a");
        }

        [Test]
        public void LoggingLocalB()
        {
            WebDriverContext.Navigate("login");
            PageHelper.WaitForMap(() => PageBase.Map.LoginTextBox);
            PageBase.FillAuthForm("local\\b", "b");
            PageBase.ClickRememberMeButton();
            PageBase.ClickLoginButton();
            PageHelper.WaitForMap(() => PageBase.Map.UserNameDiv);
            PageBase.Validate().UserNameIs("b");
        }
        protected override string PageUrl { get; }
    }
}