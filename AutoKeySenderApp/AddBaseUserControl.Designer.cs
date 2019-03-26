namespace AutoKeySenderApp
{
    partial class AddBaseUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.baseNameTextBox = new System.Windows.Forms.TextBox();
            this.addBaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa bazy:";
            // 
            // baseNameTextBox
            // 
            this.baseNameTextBox.Location = new System.Drawing.Point(4, 21);
            this.baseNameTextBox.Name = "baseNameTextBox";
            this.baseNameTextBox.Size = new System.Drawing.Size(215, 20);
            this.baseNameTextBox.TabIndex = 1;
            // 
            // addBaseButton
            // 
            this.addBaseButton.Location = new System.Drawing.Point(4, 48);
            this.addBaseButton.Name = "addBaseButton";
            this.addBaseButton.Size = new System.Drawing.Size(75, 23);
            this.addBaseButton.TabIndex = 2;
            this.addBaseButton.Text = "Dodaj bazę";
            this.addBaseButton.UseVisualStyleBackColor = true;
            this.addBaseButton.Click += new System.EventHandler(this.addBaseButton_Click);
            // 
            // AddBaseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addBaseButton);
            this.Controls.Add(this.baseNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddBaseUserControl";
            this.Size = new System.Drawing.Size(809, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baseNameTextBox;
        private System.Windows.Forms.Button addBaseButton;
    }
}
