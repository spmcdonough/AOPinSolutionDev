#region Namespace Imports


using System;
using System.Windows.Forms;
using AOPinSolutionDev.Plumbing;

#endregion Namespace Imports


namespace AOPinSolutionDev.Forms
{

    
    public partial class MainForm : Form
    {


        #region Constructor


        public MainForm()
        {
            InitializeComponent();
            LoggingSupport.LoggingTextBox = LogTextBox;
        }


        #endregion Constructor


        #region Control Events


        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LoggingSupport.Clear();
        }


        private void ExampleButton01_Click(object sender, EventArgs e)
        {
            var businessProcess = new Example01();
            businessProcess.OrchestrateBusinessProcess();
        }

        private void ExampleButton02_Click(object sender, EventArgs e)
        {
            var businessProcess = new Example02();
            businessProcess.OrchestrateBusinessProcess();
        }

        private void ExampleButton03_Click(object sender, EventArgs e)
        {
            var businessProcess = new Example03();
            businessProcess.OrchestrateBusinessProcess();
        }


        private void ExampleButton04_Click(object sender, EventArgs e)
        {
            var businessProcess = new Example04();
            businessProcess.OrchestrateBusinessProcess();
        }


        private void ExampleButton05_Click(object sender, EventArgs e)
        {
            var businessProcess = new Example05();
            businessProcess.OrchestrateBusinessProcess();
        }


        private void ExampleButton06_Click(object sender, EventArgs e)
        {
            var businessProcess = new Example06();
            businessProcess.OrchestrateBusinessProcess();
        }


        private void ExampleButton07_Click(object sender, EventArgs e)
        {
            var businessProcess = new Example07();
            businessProcess.OrchestrateBusinessProcess();
        }


        #endregion Control Events


    }
}
