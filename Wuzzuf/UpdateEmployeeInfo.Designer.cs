namespace Wuzzuf
{
    partial class UpdateEmployeeInfo
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
            this.infoDataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveButton = new System.Windows.Forms.Button();
            this.emailTitleLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loadInformationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infoDataGridView
            // 
            this.infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataGridView.Location = new System.Drawing.Point(75, 153);
            this.infoDataGridView.Name = "infoDataGridView";
            this.infoDataGridView.RowHeadersWidth = 51;
            this.infoDataGridView.RowTemplate.Height = 24;
            this.infoDataGridView.Size = new System.Drawing.Size(640, 233);
            this.infoDataGridView.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.saveButton.Location = new System.Drawing.Point(282, 392);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(197, 46);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // emailTitleLabel
            // 
            this.emailTitleLabel.AutoSize = true;
            this.emailTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.emailTitleLabel.Location = new System.Drawing.Point(12, 25);
            this.emailTitleLabel.Name = "emailTitleLabel";
            this.emailTitleLabel.Size = new System.Drawing.Size(85, 29);
            this.emailTitleLabel.TabIndex = 11;
            this.emailTitleLabel.Text = "E-Mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailTextBox.Location = new System.Drawing.Point(103, 25);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(253, 26);
            this.emailTextBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordLabel.Location = new System.Drawing.Point(401, 25);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(124, 29);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordTextBox.Location = new System.Drawing.Point(540, 28);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(253, 26);
            this.passwordTextBox.TabIndex = 13;
            // 
            // loadInformationButton
            // 
            this.loadInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.loadInformationButton.Location = new System.Drawing.Point(200, 85);
            this.loadInformationButton.Name = "loadInformationButton";
            this.loadInformationButton.Size = new System.Drawing.Size(369, 52);
            this.loadInformationButton.TabIndex = 15;
            this.loadInformationButton.Text = "Load Information";
            this.loadInformationButton.UseVisualStyleBackColor = true;
            this.loadInformationButton.Click += new System.EventHandler(this.loadInformationButton_Click);
            // 
            // UpdateEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadInformationButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.infoDataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.emailTitleLabel);
            this.Controls.Add(this.emailTextBox);
            this.Name = "UpdateEmployeeInfo";
            this.Text = "UpdateEmployeeInfo";
            this.Load += new System.EventHandler(this.UpdateEmployeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView infoDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label emailTitleLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loadInformationButton;
    }
}