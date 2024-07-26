#region Namespace Imports


using System;
using System.Text;
using System.Windows.Forms;


#endregion Namespace Imports


namespace AOPinSolutionDev.Plumbing
{


    /// <summary>
    /// This class takes care of writing messages to a "log" - which, in the
    /// case of this sample project, is just a Textbox. In a normal
    /// production application, this class would likely be more complex and
    /// include support for the standard logs, Windows Event Log, etc.
    /// </summary>
    public static class LoggingSupport
    {


        #region Methods


        public static void Clear()
        {
            LoggingTextBox.Clear();
        }


        public static void WriteToLog(String message)
        {
            // If no entry depth is specified, assume it's a top level (i.e., depth 1)
            // entry and call the overload.
            WriteToLog(message, 2);
        }


        public static void WriteToLog(String message, Int32 depth)
        {
            String textboxContent = LoggingTextBox.Text;
            StringBuilder logEntryBuilder = new StringBuilder();
            
            // Format the log entry to distinguish it from the functional entries
            logEntryBuilder.Append(new String('+', depth * 3));
            logEntryBuilder.Append(" " + message);

            // If the entry was passed in without a new line, add it to keep the output
            // looking relatively clean
            if (!message.EndsWith("\r\n"))
            {
                logEntryBuilder.Append("\r\n");
            }

            textboxContent += logEntryBuilder.ToString();
            LoggingTextBox.Text = textboxContent;
        }


        #endregion Methods


        #region Properties


        /// <summary>
        /// Maintains a reference to the form's Textbox so log entries can be
        /// written to it.
        /// </summary>
        internal static TextBox LoggingTextBox { get; set; }


        #endregion Properties


    }
}
