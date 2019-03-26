using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKeySenderApp
{
    public partial class DeleteTemplateUserControl : UserControl
    {
        public string login;
        DataBaseClass DB = new DataBaseClass();

        public DeleteTemplateUserControl()
        {
            InitializeComponent();
        }

        //Load templates to listView
        public void loadTemplates()
        {
            templatesListView.Items.Clear();
            DataTable tableList = DB.selectFromDB("SELECT name FROM templates_" + login);
            foreach (DataRow row in tableList.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                templatesListView.Items.Add(item);
            }
        }

        //Load text of selected template
        private void templatesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.templatesListView.SelectedItems.Count == 0)
                return;
            string selectedItem = this.templatesListView.SelectedItems[0].Text;
            editTemplateTextBox.Clear();
            DataTable dt = DB.selectFromDB("SELECT text FROM templates_" + login + " WHERE name = '" + selectedItem + "'");
            editTemplateTextBox.Text = DB.singleDsToString(dt);
        }

        //Save changes in template's text
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (this.templatesListView.SelectedItems.Count == 0)
                return;
            string selectedItem = this.templatesListView.SelectedItems[0].Text;
            DB.executeDB("UPDATE templates_" + login + " SET text = '" + editTemplateTextBox.Text + "' WHERE name = '" + selectedItem + "'");
        }

        //Delete selected template from DB table
        private void deleteTemplateButton_Click(object sender, EventArgs e)
        {
            if (this.templatesListView.SelectedItems.Count == 0)
                return;
            string selectedItem = this.templatesListView.SelectedItems[0].Text;
            DB.executeDB("DELETE FROM templates_" + login + " WHERE name = '" + selectedItem + "'");
            loadTemplates();
            editTemplateTextBox.Clear();
        }
    }
}
