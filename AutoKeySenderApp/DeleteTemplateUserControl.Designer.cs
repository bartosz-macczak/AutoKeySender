namespace AutoKeySenderApp
{
    partial class DeleteTemplateUserControl
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
            this.editTemplateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.deleteTemplateButton = new System.Windows.Forms.Button();
            this.templatesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // editTemplateTextBox
            // 
            this.editTemplateTextBox.Location = new System.Drawing.Point(402, 21);
            this.editTemplateTextBox.Multiline = true;
            this.editTemplateTextBox.Name = "editTemplateTextBox";
            this.editTemplateTextBox.Size = new System.Drawing.Size(380, 170);
            this.editTemplateTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz szablon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edytuj szablon:";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(490, 197);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(96, 23);
            this.saveChangesButton.TabIndex = 4;
            this.saveChangesButton.Text = "Zapisz zmiany";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // deleteTemplateButton
            // 
            this.deleteTemplateButton.Location = new System.Drawing.Point(592, 197);
            this.deleteTemplateButton.Name = "deleteTemplateButton";
            this.deleteTemplateButton.Size = new System.Drawing.Size(101, 23);
            this.deleteTemplateButton.TabIndex = 5;
            this.deleteTemplateButton.Text = "Usuń szablon";
            this.deleteTemplateButton.UseVisualStyleBackColor = true;
            this.deleteTemplateButton.Click += new System.EventHandler(this.deleteTemplateButton_Click);
            // 
            // templatesListView
            // 
            this.templatesListView.Location = new System.Drawing.Point(7, 21);
            this.templatesListView.Name = "templatesListView";
            this.templatesListView.Size = new System.Drawing.Size(225, 373);
            this.templatesListView.TabIndex = 6;
            this.templatesListView.UseCompatibleStateImageBehavior = false;
            this.templatesListView.View = System.Windows.Forms.View.List;
            this.templatesListView.SelectedIndexChanged += new System.EventHandler(this.templatesListView_SelectedIndexChanged);
            // 
            // DeleteTemplateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.templatesListView);
            this.Controls.Add(this.deleteTemplateButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editTemplateTextBox);
            this.Name = "DeleteTemplateUserControl";
            this.Size = new System.Drawing.Size(809, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox editTemplateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button deleteTemplateButton;
        private System.Windows.Forms.ListView templatesListView;
    }
}
