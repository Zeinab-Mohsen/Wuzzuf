namespace Wuzzuf
{
    partial class SearchForEmployer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.generateButton = new System.Windows.Forms.Button();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTitleLabel = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(2, 105);
            this.crystalReportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(795, 342);
            this.crystalReportViewer.TabIndex = 10;
            this.crystalReportViewer.ToolPanelWidth = 267;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.generateButton.Location = new System.Drawing.Point(288, 46);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(208, 52);
            this.generateButton.TabIndex = 20;
            this.generateButton.Text = "Generate Report";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lNameLabel.Location = new System.Drawing.Point(428, 14);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(136, 29);
            this.lNameLabel.TabIndex = 19;
            this.lNameLabel.Text = "Last Name";
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lNameTextBox.Location = new System.Drawing.Point(570, 14);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(188, 26);
            this.lNameTextBox.TabIndex = 18;
            // 
            // fNameTitleLabel
            // 
            this.fNameTitleLabel.AutoSize = true;
            this.fNameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fNameTitleLabel.Location = new System.Drawing.Point(8, 9);
            this.fNameTitleLabel.Name = "fNameTitleLabel";
            this.fNameTitleLabel.Size = new System.Drawing.Size(137, 29);
            this.fNameTitleLabel.TabIndex = 17;
            this.fNameTitleLabel.Text = "First Name";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fNameTextBox.Location = new System.Drawing.Point(151, 12);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(188, 26);
            this.fNameTextBox.TabIndex = 16;
            // 
            // SearchForEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTitleLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "SearchForEmployer";
            this.Text = "SearchForEmployer";
            this.Load += new System.EventHandler(this.SearchForEmployer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.Label fNameTitleLabel;
        private System.Windows.Forms.TextBox fNameTextBox;
    }
}