namespace Wuzzuf
{
    partial class JobReport
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
            this.generateButton = new System.Windows.Forms.Button();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.jobsCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.generateButton.Location = new System.Drawing.Point(289, 43);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(208, 52);
            this.generateButton.TabIndex = 26;
            this.generateButton.Text = "Generate Report";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.releaseDateLabel.Location = new System.Drawing.Point(63, 6);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(166, 29);
            this.releaseDateLabel.TabIndex = 23;
            this.releaseDateLabel.Text = "Release Date";
            // 
            // jobsCrystalReportViewer
            // 
            this.jobsCrystalReportViewer.ActiveViewIndex = -1;
            this.jobsCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobsCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.jobsCrystalReportViewer.Location = new System.Drawing.Point(3, 102);
            this.jobsCrystalReportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.jobsCrystalReportViewer.Name = "jobsCrystalReportViewer";
            this.jobsCrystalReportViewer.Size = new System.Drawing.Size(795, 342);
            this.jobsCrystalReportViewer.TabIndex = 21;
            this.jobsCrystalReportViewer.ToolPanelWidth = 267;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(246, 13);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(306, 22);
            this.dateTimePicker.TabIndex = 27;
            // 
            // JobReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.jobsCrystalReportViewer);
            this.Name = "JobReport";
            this.Text = "JobReport";
            this.Load += new System.EventHandler(this.JobReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label releaseDateLabel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer jobsCrystalReportViewer;
        private System.Windows.Forms.DateTimePicker dateTimePicker;

    }
}