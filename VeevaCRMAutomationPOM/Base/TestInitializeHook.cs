using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using VeevaCRMAutomationPOM.Config;
using VeevaCRMAutomationPOM.Helpers;
namespace VeevaCRMAutomationPOM.Base
{
    public abstract class TestInitializeHook : Base
    {
        public readonly BrowserType Browser;
        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
            
        }
        public void InitializeSettings()
        {
            //set all the settings for  the framework
            ConfigReader.setFrameworkSettings();

            //set all the Logs for Framework
            LogHelpers.CreateLogFile();

            //open browser
            openBrowser(Browser);
            LogHelpers.Write("Initialized Framework");

        }

        private void openBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExploer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver("E:\\Drivers");
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    DriverContext.Driver = new ChromeDriver("E:\\Drivers");
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

        //This is virtual to change the values as per the assignee (over Write)
        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            DriverContext.Driver.Manage().Window.Maximize();
            LogHelpers.Write("The Url Of Veeva is opened!!!!!!!!!!");
        }
    }
}
