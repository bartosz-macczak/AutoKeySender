namespace AutoKeySenderApp
{
    partial class DeleteBaseUserControl
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
            this.basesListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBaseButton = new System.Windows.Forms.Button();
            this.baseNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // basesListView
            // 
            this.basesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.baseNameColumn});
            this.basesListView.Location = new System.Drawing.Point(7, 20);
            this.basesListView.MultiSelect = false;
            this.basesListView.Name = "basesListView";
            this.basesListView.Size = new System.Drawing.Size(300, 345);
            this.basesListView.TabIndex = 0;
            this.basesListView.UseCompatibleStateImageBehavior = false;
            this.basesListView.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz bazę kodów:";
            // 
            // deleteBaseButton
            // 
            this.deleteBaseButton.Location = new System.Drawing.Point(7, 371);
            this.deleteBaseButton.Name = "deleteBaseButton";
            this.deleteBaseButton.Size = new System.Drawing.Size(75, 23);
            this.deleteBaseButton.TabIndex = 2;
            this.deleteBaseButton.Text = "Usuń bazę";
            this.deleteBaseButton.UseVisualStyleBackColor = true;
            this.deleteBaseButton.Click += new System.EventHandler(this.deleteBaseButton_Click);
            // 
            // baseNameColumn
            // 
            this.baseNameColumn.Text = "Baza kodów";
            this.baseNameColumn.Width = 300;
            // 
            // DeleteBaseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBaseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basesListView);
            this.Name = "DeleteBaseUserControl";
            this.Size = new System.Drawing.Size(809, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView basesListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBaseButton;
        private System.Windows.Forms.ColumnHeader baseNameColumn;
    }
}
