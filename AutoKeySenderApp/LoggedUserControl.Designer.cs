namespace AutoKeySenderApp
{
    partial class LoggedUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedUserControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.basesStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.dodajBazęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamplatesStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.assignTemplateBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.logOutButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.clientSecretTextBox = new System.Windows.Forms.TextBox();
            this.authorizeButton = new System.Windows.Forms.Button();
            this.saveDetailsCheckBox = new System.Windows.Forms.CheckBox();
            this.startSendingButton = new System.Windows.Forms.Button();
            this.sendingTimer = new System.Windows.Forms.Timer(this.components);
            this.sendStatusLabel = new System.Windows.Forms.Label();
            this.monitoringUserControl = new AutoKeySenderApp.MonitoringUserControl();
            this.deleteBaseUserControl = new AutoKeySenderApp.DeleteBaseUserControl();
            this.addBaseUserControl = new AutoKeySenderApp.AddBaseUserControl();
            this.auctionCombineUserControl = new AutoKeySenderApp.AuctionCombineUserControl();
            this.deleteTemplateUserControl = new AutoKeySenderApp.DeleteTemplateUserControl();
            this.addTemplateUserControl = new AutoKeySenderApp.AddTemplateUserControl();
            this.addCodesUserControl = new AutoKeySenderApp.AddCodesUserControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basesStripDropDownButton,
            this.tamplatesStripDropDownButton,
            this.auctionsToolStripDropDownButton,
            this.monitoringToolStripButton,
            this.logOutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(815, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // basesStripDropDownButton
            // 
            this.basesStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.basesStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajBazęToolStripMenuItem,
            this.deleteBaseToolStripMenuItem,
            this.addCodesToolStripMenuItem});
            this.basesStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("basesStripDropDownButton.Image")));
            this.basesStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.basesStripDropDownButton.Name = "basesStripDropDownButton";
            this.basesStripDropDownButton.Size = new System.Drawing.Size(83, 22);
            this.basesStripDropDownButton.Text = "Bazy kodów";
            // 
            // dodajBazęToolStripMenuItem
            // 
            this.dodajBazęToolStripMenuItem.Name = "dodajBazęToolStripMenuItem";
            this.dodajBazęToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dodajBazęToolStripMenuItem.Text = "Dodaj bazę";
            this.dodajBazęToolStripMenuItem.Click += new System.EventHandler(this.addBaseToolStripMenuItem_Click);
            // 
            // deleteBaseToolStripMenuItem
            // 
            this.deleteBaseToolStripMenuItem.Name = "deleteBaseToolStripMenuItem";
            this.deleteBaseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteBaseToolStripMenuItem.Text = "Usuń bazę";
            this.deleteBaseToolStripMenuItem.Click += new System.EventHandler(this.deleteBaseToolStripMenuItem_Click);
            // 
            // addCodesToolStripMenuItem
            // 
            this.addCodesToolStripMenuItem.Name = "addCodesToolStripMenuItem";
            this.addCodesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addCodesToolStripMenuItem.Text = "Dodaj kody";
            this.addCodesToolStripMenuItem.Click += new System.EventHandler(this.addCodesToolStripMenuItem_Click);
            // 
            // tamplatesStripDropDownButton
            // 
            this.tamplatesStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tamplatesStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTemplateToolStripMenuItem,
            this.deleteTemplateToolStripMenuItem});
            this.tamplatesStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("tamplatesStripDropDownButton.Image")));
            this.tamplatesStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tamplatesStripDropDownButton.Name = "tamplatesStripDropDownButton";
            this.tamplatesStripDropDownButton.Size = new System.Drawing.Size(67, 22);
            this.tamplatesStripDropDownButton.Text = "Szablony";
            // 
            // addTemplateToolStripMenuItem
            // 
            this.addTemplateToolStripMenuItem.Name = "addTemplateToolStripMenuItem";
            this.addTemplateToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addTemplateToolStripMenuItem.Text = "Dodaj szablon";
            this.addTemplateToolStripMenuItem.Click += new System.EventHandler(this.addTemplateToolStripMenuItem_Click);
            // 
            // deleteTemplateToolStripMenuItem
            // 
            this.deleteTemplateToolStripMenuItem.Name = "deleteTemplateToolStripMenuItem";
            this.deleteTemplateToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.deleteTemplateToolStripMenuItem.Text = "Edytuj lub usuń szablon";
            this.deleteTemplateToolStripMenuItem.Click += new System.EventHandler(this.deleteTemplateToolStripMenuItem_Click);
            // 
            // auctionsToolStripDropDownButton
            // 
            this.auctionsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.auctionsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignTemplateBaseToolStripMenuItem});
            this.auctionsToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("auctionsToolStripDropDownButton.Image")));
            this.auctionsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.auctionsToolStripDropDownButton.Name = "auctionsToolStripDropDownButton";
            this.auctionsToolStripDropDownButton.Size = new System.Drawing.Size(56, 22);
            this.auctionsToolStripDropDownButton.Text = "Aukcje";
            // 
            // assignTemplateBaseToolStripMenuItem
            // 
            this.assignTemplateBaseToolStripMenuItem.Name = "assignTemplateBaseToolStripMenuItem";
            this.assignTemplateBaseToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.assignTemplateBaseToolStripMenuItem.Text = "Przypisz szablon i bazę";
            this.assignTemplateBaseToolStripMenuItem.Click += new System.EventHandler(this.assignTemplateBaseToolStripMenuItem_Click);
            // 
            // monitoringToolStripButton
            // 
            this.monitoringToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.monitoringToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("monitoringToolStripButton.Image")));
            this.monitoringToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.monitoringToolStripButton.Name = "monitoringToolStripButton";
            this.monitoringToolStripButton.Size = new System.Drawing.Size(74, 22);
            this.monitoringToolStripButton.Text = "Monitoringi";
            this.monitoringToolStripButton.Click += new System.EventHandler(this.monitoringToolStripButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logOutButton.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton.Image")));
            this.logOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(55, 22);
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Autoryzacja konta Allegro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Client ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client Secret:";
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(80, 83);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(437, 20);
            this.clientIdTextBox.TabIndex = 10;
            // 
            // clientSecretTextBox
            // 
            this.clientSecretTextBox.Location = new System.Drawing.Point(80, 115);
            this.clientSecretTextBox.Name = "clientSecretTextBox";
            this.clientSecretTextBox.PasswordChar = '*';
            this.clientSecretTextBox.Size = new System.Drawing.Size(437, 20);
            this.clientSecretTextBox.TabIndex = 11;
            // 
            // authorizeButton
            // 
            this.authorizeButton.Location = new System.Drawing.Point(80, 153);
            this.authorizeButton.Name = "authorizeButton";
            this.authorizeButton.Size = new System.Drawing.Size(210, 23);
            this.authorizeButton.TabIndex = 14;
            this.authorizeButton.Text = "Autoryzuj";
            this.authorizeButton.UseVisualStyleBackColor = true;
            this.authorizeButton.Click += new System.EventHandler(this.authorizeButton_Click);
            // 
            // saveDetailsCheckBox
            // 
            this.saveDetailsCheckBox.AutoSize = true;
            this.saveDetailsCheckBox.Location = new System.Drawing.Point(437, 157);
            this.saveDetailsCheckBox.Name = "saveDetailsCheckBox";
            this.saveDetailsCheckBox.Size = new System.Drawing.Size(78, 17);
            this.saveDetailsCheckBox.TabIndex = 15;
            this.saveDetailsCheckBox.Text = "Zapamiętaj";
            this.saveDetailsCheckBox.UseVisualStyleBackColor = true;
            // 
            // startSendingButton
            // 
            this.startSendingButton.Location = new System.Drawing.Point(650, 389);
            this.startSendingButton.Name = "startSendingButton";
            this.startSendingButton.Size = new System.Drawing.Size(162, 23);
            this.startSendingButton.TabIndex = 17;
            this.startSendingButton.Text = "Rozpocznij wysyłkę";
            this.startSendingButton.UseVisualStyleBackColor = true;
            this.startSendingButton.Click += new System.EventHandler(this.startSendingButton_Click);
            // 
            // sendingTimer
            // 
            this.sendingTimer.Interval = 10000;
            this.sendingTimer.Tick += new System.EventHandler(this.sendingTimer_Tick);
            // 
            // sendStatusLabel
            // 
            this.sendStatusLabel.AutoSize = true;
            this.sendStatusLabel.BackColor = System.Drawing.Color.Red;
            this.sendStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendStatusLabel.Location = new System.Drawing.Point(539, 389);
            this.sendStatusLabel.Name = "sendStatusLabel";
            this.sendStatusLabel.Size = new System.Drawing.Size(95, 20);
            this.sendStatusLabel.TabIndex = 18;
            this.sendStatusLabel.Text = "Nie wysyłam";
            // 
            // monitoringUserControl
            // 
            this.monitoringUserControl.Location = new System.Drawing.Point(3, 31);
            this.monitoringUserControl.Name = "monitoringUserControl";
            this.monitoringUserControl.Size = new System.Drawing.Size(809, 397);
            this.monitoringUserControl.TabIndex = 16;
            this.monitoringUserControl.Visible = false;
            // 
            // deleteBaseUserControl
            // 
            this.deleteBaseUserControl.Location = new System.Drawing.Point(3, 31);
            this.deleteBaseUserControl.Name = "deleteBaseUserControl";
            this.deleteBaseUserControl.Size = new System.Drawing.Size(809, 397);
            this.deleteBaseUserControl.TabIndex = 2;
            this.deleteBaseUserControl.Visible = false;
            // 
            // addBaseUserControl
            // 
            this.addBaseUserControl.Location = new System.Drawing.Point(3, 31);
            this.addBaseUserControl.login = null;
            this.addBaseUserControl.Name = "addBaseUserControl";
            this.addBaseUserControl.Size = new System.Drawing.Size(809, 397);
            this.addBaseUserControl.TabIndex = 1;
            this.addBaseUserControl.Visible = false;
            // 
            // auctionCombineUserControl
            // 
            this.auctionCombineUserControl.Location = new System.Drawing.Point(3, 31);
            this.auctionCombineUserControl.Name = "auctionCombineUserControl";
            this.auctionCombineUserControl.Size = new System.Drawing.Size(809, 397);
            this.auctionCombineUserControl.TabIndex = 6;
            this.auctionCombineUserControl.Visible = false;
            // 
            // deleteTemplateUserControl
            // 
            this.deleteTemplateUserControl.Location = new System.Drawing.Point(3, 28);
            this.deleteTemplateUserControl.Name = "deleteTemplateUserControl";
            this.deleteTemplateUserControl.Size = new System.Drawing.Size(809, 397);
            this.deleteTemplateUserControl.TabIndex = 5;
            this.deleteTemplateUserControl.Visible = false;
            // 
            // addTemplateUserControl
            // 
            this.addTemplateUserControl.Location = new System.Drawing.Point(3, 28);
            this.addTemplateUserControl.Name = "addTemplateUserControl";
            this.addTemplateUserControl.Size = new System.Drawing.Size(809, 397);
            this.addTemplateUserControl.TabIndex = 4;
            this.addTemplateUserControl.Visible = false;
            // 
            // addCodesUserControl
            // 
            this.addCodesUserControl.Location = new System.Drawing.Point(3, 31);
            this.addCodesUserControl.Name = "addCodesUserControl";
            this.addCodesUserControl.Size = new System.Drawing.Size(809, 397);
            this.addCodesUserControl.TabIndex = 3;
            this.addCodesUserControl.Visible = false;
            // 
            // LoggedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendStatusLabel);
            this.Controls.Add(this.startSendingButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.addBaseUserControl);
            this.Controls.Add(this.auctionCombineUserControl);
            this.Controls.Add(this.deleteTemplateUserControl);
            this.Controls.Add(this.addTemplateUserControl);
            this.Controls.Add(this.addCodesUserControl);
            this.Controls.Add(this.monitoringUserControl);
            this.Controls.Add(this.deleteBaseUserControl);
            this.Controls.Add(this.saveDetailsCheckBox);
            this.Controls.Add(this.authorizeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.clientSecretTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LoggedUserControl";
            this.Size = new System.Drawing.Size(815, 428);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton basesStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem dodajBazęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tamplatesStripDropDownButton;
        private AddBaseUserControl addBaseUserControl;
        private System.Windows.Forms.ToolStripMenuItem addCodesToolStripMenuItem;
        private DeleteBaseUserControl deleteBaseUserControl;
        private AddCodesUserControl addCodesUserControl;
        private System.Windows.Forms.ToolStripButton logOutButton;
        private System.Windows.Forms.ToolStripMenuItem addTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTemplateToolStripMenuItem;
        private AddTemplateUserControl addTemplateUserControl;
        private DeleteTemplateUserControl deleteTemplateUserControl;
        private System.Windows.Forms.ToolStripDropDownButton auctionsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem assignTemplateBaseToolStripMenuItem;
        private AuctionCombineUserControl auctionCombineUserControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button authorizeButton;
        public System.Windows.Forms.TextBox clientSecretTextBox;
        public System.Windows.Forms.TextBox clientIdTextBox;
        public System.Windows.Forms.CheckBox saveDetailsCheckBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton monitoringToolStripButton;
        private MonitoringUserControl monitoringUserControl;
        private System.Windows.Forms.Button startSendingButton;
        private System.Windows.Forms.Timer sendingTimer;
        private System.Windows.Forms.Label sendStatusLabel;
    }
}
