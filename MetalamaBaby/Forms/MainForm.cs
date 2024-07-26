#region Namespace Imports


using System.Text;
using MetalamaBaby.Aspects;


#endregion Namespace Imports


namespace MetalamaBaby.Forms
{


    public partial class MainForm : Form
    {


        #region Constructor


        public MainForm()
        {
            InitializeComponent();
        }


        #endregion Constructor


        #region Control Events


        private void ClearStatusBoxButton_Click(object sender, EventArgs e)
        {
            ClearStatusBox();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            WriteToStatusBox("Status text box initialized.", 0);
        }


        private void NormalTestButton_Click(object sender, EventArgs e)
        {
            TopLevel_TestMethod1();
        }


        private void FailedTestButton_Click(object sender, EventArgs e)
        {
            TopLevel_TestMethod2();
        }

        private void MegaTestButton_Click(object sender, EventArgs e)
        {
            TopLevel_TestMethod3();
        }


        #endregion Control Events


        #region Methods (Status Box Support)


        public void ClearStatusBox()
        {
            StatusRTBox.Clear();
        }


        public void WriteToStatusBox(String message)
        {
            // If no entry depth is specified, assume it's a top level (i.e., depth 1)
            // entry and call the overload.
            WriteToStatusBox(message, 2);
        }


        public void WriteToStatusBox(String message, Int32 depth)
        {
            String textboxContent = StatusRTBox.Text;
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
            StatusRTBox.Text = textboxContent;
        }


        #endregion Methods  (Status Box Support)


        #region Methods (Private)


        [LoggingToStatusTextBox]
        private void TopLevel_TestMethod1()
        {
            WriteToStatusBox("This test method will succeed without issue.");
            // Do some work here
            WriteToStatusBox("Successfully reached the end of the test method.");
        }


        [LoggingToStatusTextBox]
        private void TopLevel_TestMethod2()
        {
            WriteToStatusBox("This test method will encounter an exception.");
            // Do some work here
            var mainFormBustedRef = Application.OpenForms[4]; // Only one active form. This will fail.
            WriteToStatusBox("Successfully reached the end of the test method.");
        }


        [LoggingToStatusTextBox]
        [MethodTimingAspect]
        private void TopLevel_TestMethod3()
        {
            WriteToStatusBox("This test method has two aspects attached.");
            // Do some work here
            var randomGen = new Random();
            Int32 sleepTime = randomGen.Next(1000);
            Thread.Sleep(sleepTime);
        }


        #endregion Methods (Private)


    }
}