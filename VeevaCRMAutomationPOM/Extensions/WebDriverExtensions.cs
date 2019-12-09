using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using VeevaCRMAutomationPOM.Base;

namespace VeevaCRMAutomationPOM.Extensions
{
    public static class WebDriverExtensions
    {
        //To Wait the page until  the page loads
        public static void WaitForPageLoaded(this IWebDriver driver)
        {
            driver.WaitForCondition(dri =>
            {
                string state = dri.ExecuteJs("return document.readyState").ToString();
                return state == "complete";
            }, 10);
        }

        public static void WaitForPageLoad()
        {
            //DriverContext.Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(500));
           
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        }

        public static void WaitToLoadPage()
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(7));
        }

        //Conditions to wait untill the page loads..This method is used in WaitForPageLoaded()
        public static void WaitForCondition<T>(this T obj, Func<T, bool> condtion, int timeOut)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condtion(arg);
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                };
            var stopWatch = Stopwatch.StartNew();
            while (stopWatch.ElapsedMilliseconds < timeOut)
            {
                if (execute(obj))
                {
                    break;
                }
            }
        }

        //To Execute the Jav Script to Execute the WaitForCondition()
        internal static object ExecuteJs(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript(script);
        }

    }
}
