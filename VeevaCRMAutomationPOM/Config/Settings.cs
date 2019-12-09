using VeevaCRMAutomationPOM.Base;

namespace VeevaCRMAutomationPOM.Config
{
    public class Settings
    {
        public Settings()
        {
            ConfigReader.setFrameworkSettings();
        }
        public static string TestType { get; set; }

        public static string AUT { get; set; }

        public static string Build { get; set; }

        public static BrowserType BrowserType { get; set; }

        public static string IsLog { get; set; }

        public static string LogPath { get; set; }

        public static string IsReporting { get; set; }

        public static string StartTime { get; set; }

        public static string EndTime { get; set; }

        public static string SubjectField { get; set; }
    }
}
