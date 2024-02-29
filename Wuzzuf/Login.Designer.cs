namespace Wuzzuf
{
    partial class Login
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
            this.EmployeeRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployerRadioButton = new System.Windows.Forms.RadioButton();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordText_box = new System.Windows.Forms.TextBox();
            this.passwordLoginLabel = new System.Windows.Forms.Label();
            this.emailLoginLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmployeeRadioButton
            // 
            this.EmployeeRadioButton.AutoSize = true;
            this.EmployeeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EmployeeRadioButton.Location = new System.Drawing.Point(450, 37);
            this.EmployeeRadioButton.Name = "EmployeeRadioButton";
            this.EmployeeRadioButton.Size = new System.Drawing.Size(148, 33);
            this.EmployeeRadioButton.TabIndex = 31;
            this.EmployeeRadioButton.TabStop = true;
            this.EmployeeRadioButton.Text = "Employee";
            this.EmployeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmployerRadioButton
            // 
            this.EmployerRadioButton.AutoSize = true;
            this.EmployerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EmployerRadioButton.Location = new System.Drawing.Point(203, 37);
            this.EmployerRadioButton.Name = "EmployerRadioButton";
            this.EmployerRadioButton.Size = new System.Drawing.Size(142, 33);
            this.EmployerRadioButton.TabIndex = 30;
            this.EmployerRadioButton.TabStop = true;
            this.EmployerRadioButton.Text = "Employer";
            this.EmployerRadioButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.loginButton.Location = new System.Drawing.Point(337, 360);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(157, 54);
            this.loginButton.TabIndex = 29;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordText_box
            // 
            this.passwordText_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordText_box.Location = new System.Drawing.Point(203, 268);
            this.passwordText_box.Name = "passwordText_box";
            this.passwordText_box.Size = new System.Drawing.Size(395, 26);
            this.passwordText_box.TabIndex = 28;
            // 
            // passwordLoginLabel
            // 
            this.passwordLoginLabel.AutoSize = true;
            this.passwordLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordLoginLabel.Location = new System.Drawing.Point(332, 236);
            this.passwordLoginLabel.Name = "passwordLoginLabel";
            this.passwordLoginLabel.Size = new System.Drawing.Size(124, 29);
            this.passwordLoginLabel.TabIndex = 27;
            this.passwordLoginLabel.Text = "Password";
            // 
            // emailLoginLabel
            // 
            this.emailLoginLabel.AutoSize = true;
            this.emailLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.emailLoginLabel.Location = new System.Drawing.Point(364, 129);
            this.emailLoginLabel.Name = "emailLoginLabel";
            this.emailLoginLabel.Size = new System.Drawing.Size(86, 29);
            this.emailLoginLabel.TabIndex = 26;
            this.emailLoginLabel.Text = "E-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailTextBox.Location = new System.Drawing.Point(203, 161);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(395, 26);
            this.emailTextBox.TabIndex = 25;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeRadioButton);
            this.Controls.Add(this.EmployerRadioButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordText_box);
            this.Controls.Add(this.passwordLoginLabel);
            this.Controls.Add(this.emailLoginLabel);
            this.Controls.Add(this.emailTextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton EmployeeRadioButton;
        private System.Windows.Forms.RadioButton EmployerRadioButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordText_box;
        private System.Windows.Forms.Label passwordLoginLabel;
        private System.Windows.Forms.Label emailLoginLabel;
        private System.Windows.Forms.TextBox emailTextBox;

    }
}