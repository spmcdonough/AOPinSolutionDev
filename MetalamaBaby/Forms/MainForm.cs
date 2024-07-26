#region Namespace Imports


using MetalamaBaby.Plumbing;


#endregion Namespace Imports


namespace MetalamaBaby.Forms
{


    public partial class MainForm : Form
    {


        #region Constructor


        public MainForm()
        {
            InitializeComponent(); 
            StatusBoxSupportRef = new StatusBoxSupport(StatusRTBox, this);
        }


        #endregion Constructor


        #region Control Events


        private void ClearStatusBoxButton_Click(object sender, EventArgs e)
        {
            StatusBoxSupportRef.Clear();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            StatusBoxSupportRef.WriteToStatusBox("Status text box initialized.", 0);
        }


        #endregion Control Events


        #region Properties


        /// <summary>
        /// Maintains a reference to the form's Textbox so log entries can be
        /// written to it.
        /// </summary>
        public StatusBoxSupport StatusBoxSupportRef { get; }


        #endregion Properties


    }
}