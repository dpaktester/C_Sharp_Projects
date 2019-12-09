using System;
using System.IO;

namespace VeevaCRMAutomationPOM.Helpers
{
    public class LogHelpers
    {
        //Global Declaration
        private static string _logFileName = string.Format("{0:yyyyddmmhhss}", DateTime.Now);
        private static StreamWriter _stream = null;

        //Create a File which can store the log information

        public static void CreateLogFile()
        {
            string dir = @"E:\C_Sharp_Logs\" + _logFileName;
            if (Directory.Exists(dir))
            {
                _stream = File.AppendText(dir + ".log");
            }
            else
            {
                // Directory.CreateDirectory(dir);
                _stream = File.AppendText(dir + ".log");

            }

        }
        public static void Write(string logMessage)
        {
            _stream.Write("{0}  {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _stream.WriteLine("       {0}", logMessage);
            _stream.Flush();
        }

       
    }
}
