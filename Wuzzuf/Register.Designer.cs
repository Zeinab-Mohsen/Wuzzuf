namespace Wuzzuf
{
    partial class Register
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.CVLabel = new System.Windows.Forms.Label();
            this.employeeRadioButton = new System.Windows.Forms.RadioButton();
            this.employerRadioButton = new System.Windows.Forms.RadioButton();
            this.CVTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Enabled = false;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleTextBox.Location = new System.Drawing.Point(34, 395);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(236, 26);
            this.titleTextBox.TabIndex = 46;
            this.titleTextBox.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Enabled = false;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.titleLabel.Location = new System.Drawing.Point(29, 363);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(61, 29);
            this.titleLabel.TabIndex = 45;
            this.titleLabel.Text = "Title";
            this.titleLabel.Visible = false;
            // 
            // CVLabel
            // 
            this.CVLabel.AutoSize = true;
            this.CVLabel.Enabled = false;
            this.CVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CVLabel.Location = new System.Drawing.Point(535, 76);
            this.CVLabel.Name = "CVLabel";
            this.CVLabel.Size = new System.Drawing.Size(55, 29);
            this.CVLabel.TabIndex = 44;
            this.CVLabel.Text = "C.V";
            this.CVLabel.Visible = false;
            // 
            // employeeRadioButton
            // 
            this.employeeRadioButton.AutoSize = true;
            this.employeeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.employeeRadioButton.Location = new System.Drawing.Point(623, 33);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Size = new System.Drawing.Size(148, 33);
            this.employeeRadioButton.TabIndex = 43;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Employee";
            this.employeeRadioButton.UseVisualStyleBackColor = true;
            this.employeeRadioButton.CheckedChanged += new System.EventHandler(this.employeeRadioButton_CheckedChanged);
            // 
            // employerRadioButton
            // 
            this.employerRadioButton.AutoSize = true;
            this.employerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.employerRadioButton.Location = new System.Drawing.Point(359, 33);
            this.employerRadioButton.Name = "employerRadioButton";
            this.employerRadioButton.Size = new System.Drawing.Size(142, 33);
            this.employerRadioButton.TabIndex = 42;
            this.employerRadioButton.TabStop = true;
            this.employerRadioButton.Text = "Employer";
            this.employerRadioButton.UseVisualStyleBackColor = true;
            this.employerRadioButton.CheckedChanged += new System.EventHandler(this.employerRadioButton_CheckedChanged);
            // 
            // CVTextBox
            // 
            this.CVTextBox.Enabled = false;
            this.CVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CVTextBox.Location = new System.Drawing.Point(359, 123);
            this.CVTextBox.Multiline = true;
            this.CVTextBox.Name = "CVTextBox";
            this.CVTextBox.Size = new System.Drawing.Size(412, 227);
            this.CVTextBox.TabIndex = 41;
            this.CVTextBox.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.registerButton.Location = new System.Drawing.Point(322, 375);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(167, 52);
            this.registerButton.TabIndex = 40;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordTextBox.Location = new System.Drawing.Point(34, 315);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(236, 26);
            this.passwordTextBox.TabIndex = 39;
            // 
            // emailNameTextBox
            // 
            this.emailNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailNameTextBox.Location = new System.Drawing.Point(34, 232);
            this.emailNameTextBox.Name = "emailNameTextBox";
            this.emailNameTextBox.Size = new System.Drawing.Size(236, 26);
            this.emailNameTextBox.TabIndex = 38;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastNameTextBox.Location = new System.Drawing.Point(34, 150);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(236, 26);
            this.lastNameTextBox.TabIndex = 37;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstNameTextBox.Location = new System.Drawing.Point(34, 67);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(236, 26);
            this.firstNameTextBox.TabIndex = 36;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordLabel.Location = new System.Drawing.Point(29, 283);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(124, 29);
            this.passwordLabel.TabIndex = 35;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.emailLabel.Location = new System.Drawing.Point(29, 200);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(85, 29);
            this.emailLabel.TabIndex = 34;
            this.emailLabel.Text = "E-Mail";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lastNameLabel.Location = new System.Drawing.Point(29, 118);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(132, 29);
            this.lastNameLabel.TabIndex = 33;
            this.lastNameLabel.Text = "Last name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.firstNameLabel.Location = new System.Drawing.Point(29, 24);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(133, 29);
            this.firstNameLabel.TabIndex = 32;
            this.firstNameLabel.Text = "First name";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.CVLabel);
            this.Controls.Add(this.employeeRadioButton);
            this.Controls.Add(this.employerRadioButton);
            this.Controls.Add(this.CVTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label CVLabel;
        private System.Windows.Forms.RadioButton employeeRadioButton;
        private System.Windows.Forms.RadioButton employerRadioButton;
        private System.Windows.Forms.TextBox CVTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
    }
}