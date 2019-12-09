using System;
using System.Collections.Generic;
using System.Text;
using VeevaCRMAutomationPOM.Base;
using VeevaCRMAutomationPOM.Config;
using VeevaCRMAutomationPOM.Helpers;

namespace VeevaCRM.Pages
{
    public abstract class BaseStep : Base
    {
        Base b = new Base();
       
       public virtual void NavigateSite()
        {
            //initializeDriver();
            Base b = new Base();
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("The Veeva URl is opened!!!!!!!!!!");
        }
    }
}
