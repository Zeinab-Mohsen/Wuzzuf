namespace Wuzzuf
{
    partial class SelectPostJobs
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
            this.employerIDLabel = new System.Windows.Forms.Label();
            this.jobPostIDLabel = new System.Windows.Forms.Label();
            this.employerIDTextBox = new System.Windows.Forms.TextBox();
            this.jobPostIDTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.jobIDLabel = new System.Windows.Forms.Label();
            this.jobIDComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // employerIDLabel
            // 
            this.employerIDLabel.AutoSize = true;
            this.employerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.employerIDLabel.Location = new System.Drawing.Point(538, 173);
            this.employerIDLabel.Name = "employerIDLabel";
            this.employerIDLabel.Size = new System.Drawing.Size(152, 29);
            this.employerIDLabel.TabIndex = 21;
            this.employerIDLabel.Text = "Employer ID";
            // 
            // jobPostIDLabel
            // 
            this.jobPostIDLabel.AutoSize = true;
            this.jobPostIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.jobPostIDLabel.Location = new System.Drawing.Point(117, 173);
            this.jobPostIDLabel.Name = "jobPostIDLabel";
            this.jobPostIDLabel.Size = new System.Drawing.Size(143, 29);
            this.jobPostIDLabel.TabIndex = 20;
            this.jobPostIDLabel.Text = "Job Post ID";
            // 
            // employerIDTextBox
            // 
            this.employerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.employerIDTextBox.Location = new System.Drawing.Point(508, 205);
            this.employerIDTextBox.Name = "employerIDTextBox";
            this.employerIDTextBox.Size = new System.Drawing.Size(199, 26);
            this.employerIDTextBox.TabIndex = 19;
            // 
            // jobPostIDTextBox
            // 
            this.jobPostIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.jobPostIDTextBox.Location = new System.Drawing.Point(93, 205);
            this.jobPostIDTextBox.Name = "jobPostIDTextBox";
            this.jobPostIDTextBox.Size = new System.Drawing.Size(199, 26);
            this.jobPostIDTextBox.TabIndex = 18;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SearchButton.Location = new System.Drawing.Point(299, 360);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(182, 62);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // jobIDLabel
            // 
            this.jobIDLabel.AutoSize = true;
            this.jobIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.jobIDLabel.Location = new System.Drawing.Point(314, 28);
            this.jobIDLabel.Name = "jobIDLabel";
            this.jobIDLabel.Size = new System.Drawing.Size(156, 29);
            this.jobIDLabel.TabIndex = 16;
            this.jobIDLabel.Text = "Select job ID";
            // 
            // jobIDComboBox
            // 
            this.jobIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.jobIDComboBox.FormattingEnabled = true;
            this.jobIDComboBox.Location = new System.Drawing.Point(272, 73);
            this.jobIDComboBox.Name = "jobIDComboBox";
            this.jobIDComboBox.Size = new System.Drawing.Size(231, 28);
            this.jobIDComboBox.TabIndex = 15;
            // 
            // SlectPostJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employerIDLabel);
            this.Controls.Add(this.jobPostIDLabel);
            this.Controls.Add(this.employerIDTextBox);
            this.Controls.Add(this.jobPostIDTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.jobIDLabel);
            this.Controls.Add(this.jobIDComboBox);
            this.Name = "SlectPostJobs";
            this.Text = "SlectPostJobs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SlectPostJobs_FormClosing);
            this.Load += new System.EventHandler(this.SlectPostJobs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employerIDLabel;
        private System.Windows.Forms.Label jobPostIDLabel;
        private System.Windows.Forms.TextBox employerIDTextBox;
        private System.Windows.Forms.TextBox jobPostIDTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label jobIDLabel;
        private System.Windows.Forms.ComboBox jobIDComboBox;
    }
}