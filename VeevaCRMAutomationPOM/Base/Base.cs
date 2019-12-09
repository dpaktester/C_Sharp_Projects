using OpenQA.Selenium;
using System;


namespace VeevaCRMAutomationPOM.Base
{
    public class Base
    {
        public static string formattedStartDate="";
        public static string formattedEndDate="";
        public static string Date()
        {
            //var today = DateTime.Today;
            var startDate = DateTime.Today.AddDays(2);
            formattedStartDate = startDate.ToString("MM-dd-yyyy");
            var endDate = DateTime.Today.AddDays(4);
            formattedEndDate  = endDate.ToString("MM-dd-yyyy");
            return "sss";
        }

        public Base CurrentPage { get; set; }

        private IWebDriver _driver { get; set; }

        //private RemoteWebDriver driver;
        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = DriverContext.Driver;
            }
        }


       /* public TPage GetInstance<TPage>() where TPage : HookInitialize, new()
        {
            TPage pageInstance = new TPage();
            {
                _driver = DriverContext.Driver;
            }
            
            return pageInstance;
        }*/
        protected void terminateBrowser()
        {
           // _driver.Close();
            DriverContext.Driver.Close();
        }
       /* public TPage As<TPage>() where TPage : Base
        {
            return (TPage)this;
        }*/

        /*public Base CurrentPage { get; set; }

        public RemoteWebDriver _driver;

        protected TPage GetInstance<TPage>() where TPage : HookInitialize, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : Base
        {
            return (TPage)this;
        }
*/

    }
}
