using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeevaCRMAutomationPOM.Base;

namespace VeevaCRM
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.Chrome)
        {
           
            InitializeSettings();
            NavigateSite();
        }
    }
}
