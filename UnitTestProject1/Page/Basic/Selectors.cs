using OpenQA.Selenium;

namespace Page.Basic
{

    public static class Selectors //исп веб контекст
    {
        public static IWebElement ByXPath(this IWebDriver driver, string path)
        {
            var element = driver.FindElement(By.XPath(path));
            return element;
        }

        public static IWebElement ByCssSelector(this IWebDriver driver, string path)
        {
            var element = driver.FindElement(By.CssSelector(path));
            return element;
        }
        public static IWebElement ById(this IWebDriver driver, string path)
        {
            var element = driver.FindElement(By.Id(path));
            return element;
        }
        public static IWebElement ByClassName(this IWebDriver driver, string path)
        {
            var element = driver.FindElement(By.ClassName(path));
            return element;
        }
    }

}
