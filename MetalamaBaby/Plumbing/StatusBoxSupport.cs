#region Namespace Imports


using System.Text;
using MetalamaBaby.Forms;

#endregion Namespace Imports


namespace MetalamaBaby.Plumbing
{

    
    /// <summary>
    /// This class takes care of writing messages to a "log" - which, in the
    /// case of this sample project, is just a Textbox. In a normal
    /// production application, this class would likely be more complex and
    /// include support for the standard logs, Windows Event Log, etc.
    /// </summary>
    public class StatusBoxSupport
    {

        #region Constructor


        public StatusBoxSupport(RichTextBox statusTextBox, MainForm parentFormRef) {
            StatusTextBox = statusTextBox;
            MainFormRef = parentFormRef;
        }


        #endregion Constructor


        #region Methods


        public void Clear()
        {
            StatusTextBox.Clear();
        }


        public void WriteToStatusBox(String message)
        {
            // If no entry depth is specified, assume it's a top level (i.e., depth 1)
            // entry and call the overload.
            WriteToStatusBox(message, 2);
        }


        public void WriteToStatusBox(String message, Int32 depth)
        {
            String textboxContent = StatusTextBox.Text;
            StringBuilder statusEntryBuilder = new StringBuilder();

            // Format the log entry to distinguish it from the functional entries
            statusEntryBuilder.Append(new String('+', depth * 3));
            statusEntryBuilder.Append(" " + message);

            // If the entry was passed in without a new line, add it to keep the output
            // looking relatively clean
            if (!message.EndsWith("\r\n"))
            {
                statusEntryBuilder.Append("\r\n");
            }

            textboxContent += statusEntryBuilder.ToString();
            StatusTextBox.Text = textboxContent;
        }


        #endregion Methods


        #region Properties


        public RichTextBox StatusTextBox { get; set; }


        public MainForm MainFormRef { get; set; }


        #endregion Properties


    }
}
