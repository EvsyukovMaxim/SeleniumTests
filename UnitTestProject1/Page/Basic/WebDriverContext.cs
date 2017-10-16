using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Page.Basic
{
    public class WebDriverContext : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        public static bool HasInstance => _singleton != null;

        private static WebDriverContext _singleton;

        private WebDriverContext()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddExcludedArgument("ignore-certifcate-errors");
            chromeOptions.AddArgument("test-type");

            var capabilities = DesiredCapabilities.Chrome();
            capabilities.SetCapability(ChromeOptions.Capability, chromeOptions);

            Driver = new ChromeDriver(chromeOptions) { Url = EnvironmentsConfiguration.CurrentEnvironmentBaseUrl };
        }


        public static void Navigate(string relativePage)
        {
            //var builder = new UriBuilder(EnvironmentsConfiguration.CurrentEnvironmentBaseUrl)
            //{
            //    Path = relativePage
            //};

            var path = $"{EnvironmentsConfiguration.CurrentEnvironmentBaseUrl}/{relativePage}";


            GetInstance().Driver.Navigate().GoToUrl(path);
        }
        public static void OpenNewTab()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)GetInstance().Driver;
            js.ExecuteScript("window.open();");
            GetInstance().Driver.SwitchTo().Window(GetInstance().Driver.WindowHandles.First());
        }

        public static WebDriverContext GetInstance()
        {
            return _singleton ?? (_singleton = new WebDriverContext());
        }

        private void ReleaseUnmanagedResources()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }

            Driver = null;
        }

        public void Dispose()
        {            
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
            _singleton = null;
        }

        ~WebDriverContext()
        {
            ReleaseUnmanagedResources();
        }
    }
}