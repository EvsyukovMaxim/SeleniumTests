using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using Page_s.Basic;

namespace Page_s.Login
{
    public class LoginPage : Selectors
    {
        public LoginMap Map => new LoginMap(driver);

        public void LoginButton()
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

        
    }
}
