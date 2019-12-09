using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace VeevaCRMAutomationPOM.Base 
{
    public static class DriverContext 
    {
        private static IWebDriver driver;
        public static IWebDriver Driver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
        public static Browser Browser { get; set; }

    }
}
