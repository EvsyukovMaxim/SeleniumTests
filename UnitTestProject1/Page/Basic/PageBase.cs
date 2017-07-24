﻿using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Page.Basic
{
    public class PageBase
    {
        protected readonly IWebDriver Driver;

        public PageBase()
        {
            Driver = WebDriverContext.GetInstance().Driver;
            PageFactory.InitElements(Driver, this);
            Driver.Manage().Window.Maximize();
        }


        public bool IsAuthorized => !Driver.FindElements(By.Id("boxcontent")).Any();

    }
}