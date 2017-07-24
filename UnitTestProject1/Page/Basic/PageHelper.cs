using System;
using System.Linq.Expressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Page.Basic
{
    public static class PageHelper
    {
        public static IWebElement WaitFor<TPage>(Expression<Func<TPage, IWebElement>> expression, int timeout = 10)
        {
            var driver = WebDriverContext.GetInstance().Driver;

            var compiledExp = expression.Compile();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            return wait.Until((webDriver) =>
            {
                var p = PageFactory.InitElements<TPage>(webDriver);
                return compiledExp.Invoke(p);
            });
        }

        public static IWebElement WaitForMap(Func<IWebElement> mapProp, int timeout = 10)
        {
            var driver = WebDriverContext.GetInstance().Driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return mapProp();
        }

        public static void WaitUntilVisible(Func<IWebElement> mapProp, int timeout = 10)
        {
            var driver = WebDriverContext.GetInstance().Driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            wait.Until((webDriver) => (mapProp()?.Displayed).GetValueOrDefault());
        }

        public static void WaitUntilHidden(Func<IWebElement> mapProp, int timeout = 10)
        {
            var driver = WebDriverContext.GetInstance().Driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            wait.Until((webDriver) => !(mapProp()?.Displayed).GetValueOrDefault());
        }
    }
}
