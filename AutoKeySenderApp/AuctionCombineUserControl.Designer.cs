namespace AutoKeySenderApp
{
    partial class AuctionCombineUserControl
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
            this.auctionsListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.basesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.templatesComboBox = new System.Windows.Forms.ComboBox();
            this.auctionNameLabel = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.downloadAuctionsButton = new System.Windows.Forms.Button();
            this.monitNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.activeRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // auctionsListView
            // 
            this.auctionsListView.HideSelection = false;
            this.auctionsListView.Location = new System.Drawing.Point(4, 26);
            this.auctionsListView.MultiSelect = false;
            this.auctionsListView.Name = "auctionsListView";
            this.auctionsListView.Size = new System.Drawing.Size(234, 312);
            this.auctionsListView.TabIndex = 0;
            this.auctionsListView.UseCompatibleStateImageBehavior = false;
            this.auctionsListView.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista aukcji:";
            // 
            // basesComboBox
            // 
            this.basesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basesComboBox.FormattingEnabled = true;
            this.basesComboBox.Location = new System.Drawing.Point(476, 77);
            this.basesComboBox.Name = "basesComboBox";
            this.basesComboBox.Size = new System.Drawing.Size(223, 21);
            this.basesComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Szablon";
            // 
            // templatesComboBox
            // 
            this.templatesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templatesComboBox.FormattingEnabled = true;
            this.templatesComboBox.Location = new System.Drawing.Point(476, 118);
            this.templatesComboBox.Name = "templatesComboBox";
            this.templatesComboBox.Size = new System.Drawing.Size(223, 21);
            this.templatesComboBox.TabIndex = 6;
            // 
            // auctionNameLabel
            // 
            this.auctionNameLabel.AutoSize = true;
            this.auctionNameLabel.Location = new System.Drawing.Point(473, 48);
            this.auctionNameLabel.Name = "auctionNameLabel";
            this.auctionNameLabel.Size = new System.Drawing.Size(0, 13);
            this.auctionNameLabel.TabIndex = 7;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(476, 168);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(223, 23);
            this.saveChangesButton.TabIndex = 8;
            this.saveChangesButton.Text = "Zapisz zmiany";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // downloadAuctionsButton
            // 
            this.downloadAuctionsButton.Location = new System.Drawing.Point(4, 344);
            this.downloadAuctionsButton.Name = "downloadAuctionsButton";
            this.downloadAuctionsButton.Size = new System.Drawing.Size(234, 23);
            this.downloadAuctionsButton.TabIndex = 11;
            this.downloadAuctionsButton.Text = "Załaduj aukcje";
            this.downloadAuctionsButton.UseVisualStyleBackColor = true;
            this.downloadAuctionsButton.Click += new System.EventHandler(this.downloadAuctionsButton_Click);
            // 
            // monitNameTextBox
            // 
            this.monitNameTextBox.Location = new System.Drawing.Point(476, 38);
            this.monitNameTextBox.Name = "monitNameTextBox";
            this.monitNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.monitNameTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nazwa:";
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Location = new System.Drawing.Point(476, 145);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(66, 17);
            this.activeRadioButton.TabIndex = 10;
            this.activeRadioButton.TabStop = true;
            this.activeRadioButton.Text = "Aktywna";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            // 
            // AuctionCombineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monitNameTextBox);
            this.Controls.Add(this.downloadAuctionsButton);
            this.Controls.Add(this.activeRadioButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.auctionNameLabel);
            this.Controls.Add(this.templatesComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.basesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.auctionsListView);
            this.Name = "AuctionCombineUserControl";
            this.Size = new System.Drawing.Size(809, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView auctionsListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox basesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox templatesComboBox;
        private System.Windows.Forms.Label auctionNameLabel;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button downloadAuctionsButton;
        private System.Windows.Forms.TextBox monitNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton activeRadioButton;
    }
}
