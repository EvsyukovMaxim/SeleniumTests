using Page_s.Basic;

namespace Page_s.Basic
{
    public abstract class WebDriverTestsBase<T> where T : PageBase, new()
    {
        /// <summary>
        /// Page object instance
        /// </summary>
        protected T PageBase { get; set; }

        /// <summary>
        /// Relative Url to target Page Object
        /// </summary>
        protected abstract string PageUrl { get; }


        public void BeforeScenario()
        {
            //if (WebDriverContext.HasInstance)
            //{
            //    var instance = WebDriverContext.GetInstance();
            //    instance.Dispose();
            //}

            PageBase = new T();
        }

        public static void AfterFeature()
        {
            if (WebDriverContext.HasInstance)
            {
                var instance = WebDriverContext.GetInstance();
                instance.Dispose();
            }
        }

    }
}