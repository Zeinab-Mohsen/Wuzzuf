namespace Wuzzuf
{
    partial class Search
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
            this.jobsDataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.searchButton = new System.Windows.Forms.Button();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jobsDataGridView
            // 
            this.jobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsDataGridView.Location = new System.Drawing.Point(80, 104);
            this.jobsDataGridView.Name = "jobsDataGridView";
            this.jobsDataGridView.RowHeadersWidth = 51;
            this.jobsDataGridView.RowTemplate.Height = 24;
            this.jobsDataGridView.Size = new System.Drawing.Size(640, 233);
            this.jobsDataGridView.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.searchButton.Location = new System.Drawing.Point(310, 354);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(197, 67);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.jobTitleLabel.Location = new System.Drawing.Point(280, 30);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(203, 29);
            this.jobTitleLabel.TabIndex = 11;
            this.jobTitleLabel.Text = "Enter the job title";
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.jobTitleTextBox.Location = new System.Drawing.Point(80, 62);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(640, 26);
            this.jobTitleTextBox.TabIndex = 10;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jobsDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.jobTitleTextBox);
            this.Name = "Search";
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_FormClosing);
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jobsDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.TextBox jobTitleTextBox;
    }
}