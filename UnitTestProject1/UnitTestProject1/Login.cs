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
        public void LoggingDomenUser()
        {
            var driver =  WebDriverContext.GetInstance().Driver; //подумай - как это отсюда убрать!!!
            

            //public void GivenStartWith(string p0, string p1)
            //{
            //    PageHelper.WaitForMap(() => PageBase.Map.LoginButton);
            //}
        }
        protected override string PageUrl { get; }
    }
}