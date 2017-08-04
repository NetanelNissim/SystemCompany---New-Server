using System;
using System.Diagnostics;

namespace SystemCustomers.MessageUtils
{
    public class LogUtils
    {
        private const string sLog = "Application";
        private const string sAppName = "System Customers";

        /// <summary>
        /// Writes to log.
        /// </summary>
        /// <param name="logString">The log string.</param>
        public static void WriteToLog(string logString)
        {
            string appPath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            if (!appPath.EndsWith("\\"))
            {
                appPath = appPath + "\\";
            }
            // create a writer and open the file
            System.IO.TextWriter tw = new System.IO.StreamWriter(appPath + DateTime.Today.ToString("MMM dd yyyy") + " log.txt", true);
            // write a line of text to the file
            tw.WriteLine(DateTime.Now + ": " + logString);
            // close the stream
            tw.Close();
        }

        /// <summary>
        /// Systems event logs Information.
        /// </summary>
        /// <param name="sEventLog">The s event log.</param>
        public static void SystemEventLogsInformation(string sEventLog)
        {
            try
            {
                if (!EventLog.SourceExists(sAppName))
                    EventLog.CreateEventSource(sAppName, sLog);

                EventLog.WriteEntry(sAppName, sEventLog,
                    EventLogEntryType.Information, 200);
            }
            catch (System.Security.SecurityException ex)
            {
                WriteToLog(ex.Message);
            }
        }

        /// <summary>
        /// Systems event logs Warning
        /// </summary>
        /// <param name="sEvent">The Message log</param>
        public static void SystemEventLogsWarning(string sEvent)
        {
            try
            {
                if (!EventLog.SourceExists(sAppName))
                    EventLog.CreateEventSource(sAppName, sLog);

                EventLog.WriteEntry(sAppName, sEvent,
                    EventLogEntryType.Warning, 211);
            }
            catch (System.Security.SecurityException ex)
            {
                WriteToLog(ex.Message);
            }
        }
        /// <summary>
        /// Systems event logs Error
        /// </summary>
        /// <param name="sEvent">The message log</param>
        public static void SystemEventLogsError(string sEvent)
        {
            try
            {
                if (!EventLog.SourceExists(sAppName))
                    EventLog.CreateEventSource(sAppName, sLog);

                EventLog.WriteEntry(sAppName, sEvent,
                    EventLogEntryType.Error, 222);
            }
            catch (System.Security.SecurityException ex)
            {
                WriteToLog(ex.Message);
            }
        }
    }
}
