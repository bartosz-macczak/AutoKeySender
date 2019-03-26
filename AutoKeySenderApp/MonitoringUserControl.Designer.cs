namespace AutoKeySenderApp
{
    partial class MonitoringUserControl
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
            this.monitsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteMonitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.monitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // monitsDataGridView
            // 
            this.monitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitsDataGridView.Location = new System.Drawing.Point(3, 33);
            this.monitsDataGridView.Name = "monitsDataGridView";
            this.monitsDataGridView.Size = new System.Drawing.Size(803, 274);
            this.monitsDataGridView.TabIndex = 0;
            // 
            // deleteMonitButton
            // 
            this.deleteMonitButton.Location = new System.Drawing.Point(328, 340);
            this.deleteMonitButton.Name = "deleteMonitButton";
            this.deleteMonitButton.Size = new System.Drawing.Size(131, 23);
            this.deleteMonitButton.TabIndex = 1;
            this.deleteMonitButton.Text = "Usuń monit";
            this.deleteMonitButton.UseVisualStyleBackColor = true;
            this.deleteMonitButton.Click += new System.EventHandler(this.deleteMonitButton_Click);
            // 
            // MonitoringUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteMonitButton);
            this.Controls.Add(this.monitsDataGridView);
            this.Name = "MonitoringUserControl";
            this.Size = new System.Drawing.Size(809, 397);
            ((System.ComponentModel.ISupportInitialize)(this.monitsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView monitsDataGridView;
        private System.Windows.Forms.Button deleteMonitButton;
    }
}
