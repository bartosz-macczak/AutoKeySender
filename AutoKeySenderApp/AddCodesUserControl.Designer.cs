namespace AutoKeySenderApp
{
    partial class AddCodesUserControl
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
            this.chooseAddCodeListView = new System.Windows.Forms.ListView();
            this.chooseBaseButton = new System.Windows.Forms.Button();
            this.codesListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteCodeButton = new System.Windows.Forms.Button();
            this.addCodesTextBox = new System.Windows.Forms.TextBox();
            this.addCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz bazę:";
            // 
            // chooseAddCodeListView
            // 
            this.chooseAddCodeListView.Location = new System.Drawing.Point(3, 21);
            this.chooseAddCodeListView.Name = "chooseAddCodeListView";
            this.chooseAddCodeListView.Size = new System.Drawing.Size(300, 344);
            this.chooseAddCodeListView.TabIndex = 1;
            this.chooseAddCodeListView.UseCompatibleStateImageBehavior = false;
            this.chooseAddCodeListView.View = System.Windows.Forms.View.List;
            // 
            // chooseBaseButton
            // 
            this.chooseBaseButton.Location = new System.Drawing.Point(3, 371);
            this.chooseBaseButton.Name = "chooseBaseButton";
            this.chooseBaseButton.Size = new System.Drawing.Size(119, 23);
            this.chooseBaseButton.TabIndex = 2;
            this.chooseBaseButton.Text = "Wybierz";
            this.chooseBaseButton.UseVisualStyleBackColor = true;
            this.chooseBaseButton.Click += new System.EventHandler(this.chooseBaseButton_Click);
            // 
            // codesListView
            // 
            this.codesListView.Location = new System.Drawing.Point(475, 21);
            this.codesListView.Name = "codesListView";
            this.codesListView.Size = new System.Drawing.Size(300, 141);
            this.codesListView.TabIndex = 3;
            this.codesListView.UseCompatibleStateImageBehavior = false;
            this.codesListView.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista kodów:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dodaj kody (każdy w nowym wierszu):";
            // 
            // deleteCodeButton
            // 
            this.deleteCodeButton.Location = new System.Drawing.Point(394, 57);
            this.deleteCodeButton.Name = "deleteCodeButton";
            this.deleteCodeButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCodeButton.TabIndex = 7;
            this.deleteCodeButton.Text = "Usuń";
            this.deleteCodeButton.UseVisualStyleBackColor = true;
            this.deleteCodeButton.Click += new System.EventHandler(this.deleteCodeButton_Click);
            // 
            // addCodesTextBox
            // 
            this.addCodesTextBox.Location = new System.Drawing.Point(475, 185);
            this.addCodesTextBox.Multiline = true;
            this.addCodesTextBox.Name = "addCodesTextBox";
            this.addCodesTextBox.Size = new System.Drawing.Size(300, 180);
            this.addCodesTextBox.TabIndex = 8;
            // 
            // addCodeButton
            // 
            this.addCodeButton.Location = new System.Drawing.Point(394, 257);
            this.addCodeButton.Name = "addCodeButton";
            this.addCodeButton.Size = new System.Drawing.Size(75, 23);
            this.addCodeButton.TabIndex = 9;
            this.addCodeButton.Text = "Dodaj";
            this.addCodeButton.UseVisualStyleBackColor = true;
            this.addCodeButton.Click += new System.EventHandler(this.addCodeButton_Click);
            // 
            // AddCodesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCodeButton);
            this.Controls.Add(this.addCodesTextBox);
            this.Controls.Add(this.deleteCodeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codesListView);
            this.Controls.Add(this.chooseBaseButton);
            this.Controls.Add(this.chooseAddCodeListView);
            this.Controls.Add(this.label1);
            this.Name = "AddCodesUserControl";
            this.Size = new System.Drawing.Size(809, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView chooseAddCodeListView;
        private System.Windows.Forms.Button chooseBaseButton;
        private System.Windows.Forms.ListView codesListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteCodeButton;
        private System.Windows.Forms.TextBox addCodesTextBox;
        private System.Windows.Forms.Button addCodeButton;
    }
}
