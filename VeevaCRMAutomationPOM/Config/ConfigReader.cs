using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
namespace VeevaCRMAutomationPOM.Config
{
    public class ConfigReader
    {
        public static void setFrameworkSettings()
        {
            XPathItem aut;
            XPathItem Browser;
            XPathItem TestType;
            XPathItem IsLog;
            XPathItem LogPath;
            XPathItem IsReport;
            XPathItem UserName;
            XPathItem BuildName;
            XPathItem StartTime;
            XPathItem EndTime;
            XPathItem SubjectField;


            //string streamFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            
            string streamFileName = "C:\\Users\\dmahapatra\\source\\repos\\VeevaCRM\\VeevaCRMAutomationPOM\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(streamFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            aut = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/Aut");
            Browser = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/Browser");
            TestType = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/TestType");
            IsLog = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/IsLog");
            LogPath = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/LogPath");
            IsReport = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/IsReport");
            UserName = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/UserName");
            BuildName = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/BuildName");
            StartTime = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/Start_Time");
            EndTime = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/End_Time");
            SubjectField = navigator.SelectSingleNode("VeevaCRMAutomation/RunSettings/SubField");


            Settings.AUT = aut.Value.ToString();
            Settings.Build = BuildName.Value.ToString();
            Settings.IsLog = IsLog.Value.ToString();
            Settings.LogPath = LogPath.Value.ToString();
            Settings.TestType = TestType.Value.ToString();
            Settings.IsReporting = IsReport.Value.ToString();
            Settings.StartTime = StartTime.Value.ToString();
            Settings.EndTime = EndTime.Value.ToString();
            Settings.SubjectField = SubjectField.Value.ToString();


        }

    }
}
