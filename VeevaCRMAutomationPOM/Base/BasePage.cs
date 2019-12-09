using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace VeevaCRMAutomationPOM.Base
{
    public abstract class HookInitialize : Base
    {


        //private IWebDriver IWebDriver;
        public IWebDriver _driver;
        public HookInitialize() 
        {
            //this.IWebDriver = DriverContext.Driver;
            _driver = DriverContext.Driver;
        }


    }
}
