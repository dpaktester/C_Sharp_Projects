using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace VeevaCRMAutomationPOM.Base
{
    public class Browser : Base
    {
        private readonly IWebDriver _driver;
        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }
        public BrowserType Type { get; set; }

        public void GoToUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }
    }

    public enum BrowserType
    {
        InternetExploer,
        Chrome,
        FireFox
    }
}
