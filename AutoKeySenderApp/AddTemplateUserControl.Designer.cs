namespace AutoKeySenderApp
{
    partial class AddTemplateUserControl
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
            this.addTemplateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addTemplateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.templateNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addTemplateRichTextBox
            // 
            this.addTemplateRichTextBox.Location = new System.Drawing.Point(3, 62);
            this.addTemplateRichTextBox.Name = "addTemplateRichTextBox";
            this.addTemplateRichTextBox.Size = new System.Drawing.Size(427, 188);
            this.addTemplateRichTextBox.TabIndex = 0;
            this.addTemplateRichTextBox.Text = "";
            // 
            // addTemplateButton
            // 
            this.addTemplateButton.Location = new System.Drawing.Point(3, 299);
            this.addTemplateButton.Name = "addTemplateButton";
            this.addTemplateButton.Size = new System.Drawing.Size(104, 23);
            this.addTemplateButton.TabIndex = 1;
            this.addTemplateButton.Text = "Dodaj szablon";
            this.addTemplateButton.UseVisualStyleBackColor = true;
            this.addTemplateButton.Click += new System.EventHandler(this.addTemplateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stwórz szablon wiadomości, w miejsce umieszczanego kodu wpisz \"[CODE]\":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa szablonu:";
            // 
            // templateNameTextBox
            // 
            this.templateNameTextBox.Location = new System.Drawing.Point(3, 273);
            this.templateNameTextBox.Name = "templateNameTextBox";
            this.templateNameTextBox.Size = new System.Drawing.Size(427, 20);
            this.templateNameTextBox.TabIndex = 4;
            // 
            // AddTemplateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.templateNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTemplateButton);
            this.Controls.Add(this.addTemplateRichTextBox);
            this.Name = "AddTemplateUserControl";
            this.Size = new System.Drawing.Size(809, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox addTemplateRichTextBox;
        private System.Windows.Forms.Button addTemplateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox templateNameTextBox;
    }
}
