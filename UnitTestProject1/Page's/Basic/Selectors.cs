using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Page_s.Basic
{
    public class Selectors : PageBase
    {
        public IWebElement ByXPath(string path)
        {
            var element = driver.FindElement(By.XPath(path));
            return element;
        }

        public IWebElement ByCssSelector(string path)
        {
            var element = driver.FindElement(By.CssSelector(path));
            return element;
        }

        public string TextedSelector(IWebElement selector)
        {
            var element = selector.Text;
            return element;
        }

        

    }

}
