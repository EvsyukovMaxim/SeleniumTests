using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Page_s.Basic;
using Page_s.Login;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProjectYouLa
{
    [TestClass]
    public class Login : WebDriverTestsBase<LoginPage>
    {
        [TestMethod]
        public void LoggingLocalUser()
        {
            BeforeScenario();
            
            PageBase.FillAuthForm("local\\a", "a");
            PageBase.ClickLoginButton();
            PageHelper.WaitForMap(() => PageBase.Map.UserNameDiv);
            PageBase.Validate().UserNameIs("a");
            AfterFeature();
        }
        protected override string PageUrl { get; }
    }
}