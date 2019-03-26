namespace AutoKeySenderApp
{
    partial class RegisterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.confirmRegisterButton = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordBox = new System.Windows.Forms.TextBox();
            this.regCheckBox = new System.Windows.Forms.CheckBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmRegisterButton
            // 
            this.confirmRegisterButton.Location = new System.Drawing.Point(314, 340);
            this.confirmRegisterButton.Name = "confirmRegisterButton";
            this.confirmRegisterButton.Size = new System.Drawing.Size(75, 23);
            this.confirmRegisterButton.TabIndex = 0;
            this.confirmRegisterButton.Text = "Register";
            this.confirmRegisterButton.UseVisualStyleBackColor = true;
            this.confirmRegisterButton.Click += new System.EventHandler(this.confirmRegisterButton_Click);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(355, 91);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 20);
            this.loginBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Repeat password:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(355, 121);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(355, 148);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 7;
            // 
            // repeatPasswordBox
            // 
            this.repeatPasswordBox.Location = new System.Drawing.Point(355, 175);
            this.repeatPasswordBox.Name = "repeatPasswordBox";
            this.repeatPasswordBox.PasswordChar = '*';
            this.repeatPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.repeatPasswordBox.TabIndex = 8;
            // 
            // regCheckBox
            // 
            this.regCheckBox.AutoSize = true;
            this.regCheckBox.Location = new System.Drawing.Point(314, 201);
            this.regCheckBox.Name = "regCheckBox";
            this.regCheckBox.Size = new System.Drawing.Size(173, 17);
            this.regCheckBox.TabIndex = 9;
            this.regCheckBox.Text = "I accept regulations and policy.";
            this.regCheckBox.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(396, 339);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RegisterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.regCheckBox);
            this.Controls.Add(this.repeatPasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.confirmRegisterButton);
            this.Name = "RegisterUserControl";
            this.Size = new System.Drawing.Size(815, 428);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmRegisterButton;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox repeatPasswordBox;
        private System.Windows.Forms.CheckBox regCheckBox;
        private System.Windows.Forms.Button backButton;
    }
}
