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
            NormalTestButton = new Button();
            FailedTestButton = new Button();
            MegaTestButton = new Button();
            SuspendLayout();
            // 
            // StatusRTBox
            // 
            StatusRTBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusRTBox.BorderStyle = BorderStyle.FixedSingle;
            StatusRTBox.Font = new Font("Segoe UI", 18F);
            StatusRTBox.Location = new Point(22, 156);
            StatusRTBox.Margin = new Padding(6);
            StatusRTBox.Name = "StatusRTBox";
            StatusRTBox.ReadOnly = true;
            StatusRTBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            StatusRTBox.Size = new Size(2299, 1438);
            StatusRTBox.TabIndex = 0;
            StatusRTBox.Text = "";
            // 
            // ClearStatusBoxButton
            // 
            ClearStatusBoxButton.Font = new Font("Segoe UI", 18F);
            ClearStatusBoxButton.Location = new Point(1591, 15);
            ClearStatusBoxButton.Margin = new Padding(6);
            ClearStatusBoxButton.Name = "ClearStatusBoxButton";
            ClearStatusBoxButton.Size = new Size(730, 128);
            ClearStatusBoxButton.TabIndex = 1;
            ClearStatusBoxButton.Text = "Clear Status Box";
            ClearStatusBoxButton.UseVisualStyleBackColor = true;
            ClearStatusBoxButton.Click += ClearStatusBoxButton_Click;
            // 
            // NormalTestButton
            // 
            NormalTestButton.Font = new Font("Segoe UI", 18F);
            NormalTestButton.Location = new Point(22, 15);
            NormalTestButton.Name = "NormalTestButton";
            NormalTestButton.Size = new Size(516, 132);
            NormalTestButton.TabIndex = 2;
            NormalTestButton.Text = "Click for Normal Test";
            NormalTestButton.UseVisualStyleBackColor = true;
            NormalTestButton.Click += NormalTestButton_Click;
            // 
            // FailedTestButton
            // 
            FailedTestButton.Font = new Font("Segoe UI", 18F);
            FailedTestButton.Location = new Point(544, 15);
            FailedTestButton.Name = "FailedTestButton";
            FailedTestButton.Size = new Size(516, 132);
            FailedTestButton.TabIndex = 3;
            FailedTestButton.Text = "Click for Failed Test";
            FailedTestButton.UseVisualStyleBackColor = true;
            FailedTestButton.Click += FailedTestButton_Click;
            // 
            // MegaTestButton
            // 
            MegaTestButton.Font = new Font("Segoe UI", 18F);
            MegaTestButton.Location = new Point(1066, 15);
            MegaTestButton.Name = "MegaTestButton";
            MegaTestButton.Size = new Size(516, 132);
            MegaTestButton.TabIndex = 4;
            MegaTestButton.Text = "Click for Mega Test";
            MegaTestButton.UseVisualStyleBackColor = true;
            MegaTestButton.Click += MegaTestButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2347, 1623);
            Controls.Add(MegaTestButton);
            Controls.Add(FailedTestButton);
            Controls.Add(NormalTestButton);
            Controls.Add(ClearStatusBoxButton);
            Controls.Add(StatusRTBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
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
        private Button NormalTestButton;
        private Button FailedTestButton;
        private Button MegaTestButton;
    }
}
