namespace Wuzzuf
{
    partial class SearchForCandidates
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
            this.candidatesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.candidatesTitleLabel = new System.Windows.Forms.Label();
            this.candidatesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // candidatesDataGridView
            // 
            this.candidatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatesDataGridView.Location = new System.Drawing.Point(80, 104);
            this.candidatesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.candidatesDataGridView.Name = "candidatesDataGridView";
            this.candidatesDataGridView.RowHeadersWidth = 51;
            this.candidatesDataGridView.RowTemplate.Height = 24;
            this.candidatesDataGridView.Size = new System.Drawing.Size(640, 233);
            this.candidatesDataGridView.TabIndex = 13;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.searchButton.Location = new System.Drawing.Point(311, 354);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(197, 66);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // candidatesTitleLabel
            // 
            this.candidatesTitleLabel.AutoSize = true;
            this.candidatesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.candidatesTitleLabel.Location = new System.Drawing.Point(235, 31);
            this.candidatesTitleLabel.Name = "candidatesTitleLabel";
            this.candidatesTitleLabel.Size = new System.Drawing.Size(297, 29);
            this.candidatesTitleLabel.TabIndex = 15;
            this.candidatesTitleLabel.Text = "Enter the candidates\' title";
            // 
            // candidatesTextBox
            // 
            this.candidatesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.candidatesTextBox.Location = new System.Drawing.Point(80, 62);
            this.candidatesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.candidatesTextBox.Name = "candidatesTextBox";
            this.candidatesTextBox.Size = new System.Drawing.Size(640, 26);
            this.candidatesTextBox.TabIndex = 14;
            // 
            // SearchForCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.candidatesDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.candidatesTitleLabel);
            this.Controls.Add(this.candidatesTextBox);
            this.Name = "SearchForCandidates";
            this.Text = "SearchForCandidates";
            this.Load += new System.EventHandler(this.SearchForCandidates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView candidatesDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label candidatesTitleLabel;
        private System.Windows.Forms.TextBox candidatesTextBox;
    }
}