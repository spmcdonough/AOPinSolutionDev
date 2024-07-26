namespace MetalamaBaby.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            StatusRTBox = new RichTextBox();
            ClearStatusBoxButton = new Button();
            SuspendLayout();
            // 
            // StatusRTBox
            // 
            StatusRTBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusRTBox.BorderStyle = BorderStyle.FixedSingle;
            StatusRTBox.Location = new Point(12, 73);
            StatusRTBox.Name = "StatusRTBox";
            StatusRTBox.ReadOnly = true;
            StatusRTBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            StatusRTBox.Size = new Size(1240, 676);
            StatusRTBox.TabIndex = 0;
            StatusRTBox.Text = "";
            // 
            // ClearStatusBoxButton
            // 
            ClearStatusBoxButton.Location = new Point(1050, 12);
            ClearStatusBoxButton.Name = "ClearStatusBoxButton";
            ClearStatusBoxButton.Size = new Size(202, 55);
            ClearStatusBoxButton.TabIndex = 1;
            ClearStatusBoxButton.Text = "Clear Status Box";
            ClearStatusBoxButton.UseVisualStyleBackColor = true;
            ClearStatusBoxButton.Click += ClearStatusBoxButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(ClearStatusBoxButton);
            Controls.Add(StatusRTBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Metalama Baby!";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        internal RichTextBox StatusRTBox;
        private Button ClearStatusBoxButton;
    }
}
