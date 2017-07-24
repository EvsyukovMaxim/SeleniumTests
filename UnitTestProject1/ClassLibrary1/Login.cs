using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Page.Basic;
using Page.Login;

namespace UnitTestProject1
{
    [TestFixture]
    public class Login : WebDriverTestsBase<LoginPage>
    {

        [Test]
        public void LoggingLocalA()
        {
            PageBase.FillAuthForm("local\\a", "a");
            PageBase.ClickLoginButton();
            PageHelper.WaitForMap(() => PageBase.Map.UserNameDiv);
            PageBase.Validate().UserNameIs("a");
        }

        [Test]
        public void LoggingLocalB()
        {
            PageBase.FillAuthForm("local\\b", "b");
            PageBase.ClickRememberMeButton();
            PageBase.ClickLoginButton();
            PageHelper.WaitForMap(() => PageBase.Map.UserNameDiv);
            PageBase.Validate().UserNameIs("b");
        }
        protected override string PageUrl { get; }
    }
}